using CRBBWeb.Models;
using CRBICommonLib;
using CRBIReportLib.ReportBase;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace CRBBWeb.Controllers
{
    public class WarningController : Controller
    {
        // GET: Warning
        public ActionResult Index()
        {
            int siteId = int.Parse(System.Configuration.ConfigurationManager.AppSettings["SiteId"]);
            DataTable dt = CRBIYYBBReportProjectRule.Intance().GetY_WarnFault(siteId);
            List<Y_WarnFaultViewModels> list = CRBICommonLib.ModelConvertHelper<Y_WarnFaultViewModels>.ConvertToModel(dt);
            foreach (var item in list)
            {
                try
                {
                    using (var httpClient = new HttpClient())
                    {
                        var url = new Uri(System.Configuration.ConfigurationManager.AppSettings["Knowledge"]);
                        var response = httpClient.GetAsync(url + "/GetExpertKnowledge?val="+ item.EventName + "&pageNo=1&pageSize=1&strOrder=CreateTime%20DESC&equipmentCategory=-1&keyWord=").Result;
                        var data = response.Content.ReadAsStringAsync().Result;
                        data = "{ExpertKnowledgeViewModel:" + data.Substring(0, data.LastIndexOf(']') + 1).Substring(data.IndexOf('[')) + "}";
                        data = data.Replace(@"\", "");
                        var model = JsonConvert.DeserializeObjectAsync<ExpertKnowledgesViewModel>(data).Result;
                        if (model.ExpertKnowledgeViewModel.Count > 0)
                        {
                            item.ExpertAdvice = model.ExpertKnowledgeViewModel[0].Solution ?? "";
                        }
                    }
                }
                catch
                {
                    item.ExpertAdvice = "";
                }
                
            }
            return View(list);
        }

        [HttpPost]
        public JsonResult PollingBroadcast(bool isChecked)
        {
            var json = new JsonResults();
            var rm = new ResultModel();
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Setting.ini");
                IniFile ini = new IniFile(filePath);
                ini.WriteString("PollingBroadcast", "Checked", isChecked.ToString());
                rm.Status = true;
            }
            catch (Exception ex)
            {
                rm.Message = ex.Message;
                rm.Status = false;
            }
            json.Data = rm;
            return json;
        }
    }
}
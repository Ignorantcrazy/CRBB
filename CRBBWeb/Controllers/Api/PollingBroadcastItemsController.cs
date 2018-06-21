using CRBBWeb.Models;
using CRBICommonLib;
using CRBIReportLib.ReportBase;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRBBWeb.Controllers.Api
{
    public class PollingBroadcastItemsController : ApiController
    {
        public ApiResultViewModel<List<Y_WarnFaultViewModels>> Get()
        {
            ApiResultViewModel<List<Y_WarnFaultViewModels>> result = new ApiResultViewModel<List<Y_WarnFaultViewModels>>();
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Setting.ini");
                IniFile ini = new IniFile(filePath);
                var isChecked = bool.Parse(ini.ReadString("PollingBroadcast", "Checked", ""));
                if (isChecked)
                {
                    int siteId = int.Parse(System.Configuration.ConfigurationManager.AppSettings["SiteId"]);
                    DataTable dt = CRBIYYBBReportProjectRule.Intance().GetY_WarnFault(siteId);
                    List<Y_WarnFaultViewModels> list = CRBICommonLib.ModelConvertHelper<Y_WarnFaultViewModels>.ConvertToModel(dt);
                    //string existItem = ini.ReadString("PollingBroadcast", "ExistItem", "");
                    //if (!string.IsNullOrEmpty(existItem))
                    //{
                    //    List<string> existItems = existItem.Split(',').ToList();
                    //    list = list.Where(m => !existItem.Contains(m.ID.ToString())).ToList();
                    //}
                    if (list.Count <= 0)
                    {
                        result.Status = false;
                        return result;
                    }
                    foreach (var item in list)
                    {
                        //string strTemp = ini.ReadString("PollingBroadcast", "ExistItem", "");
                        //ini.WriteString("PollingBroadcast", "ExistItem", (strTemp == "" ? "" : (strTemp + ",")) + item.ID.ToString());
                        try
                        {
                            using (var httpClient = new HttpClient())
                            {
                                var url = new Uri(System.Configuration.ConfigurationManager.AppSettings["Knowledge"]);
                                var response = httpClient.GetAsync(url + "/GetExpertKnowledge?val=" + item.EventName + "&pageNo=1&pageSize=1&strOrder=CreateTime%20DESC&equipmentCategory=-1&keyWord=").Result;
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
                    result.Status = true;
                    result.Obj = list;
                }
                else
                {
                    result.Status = false;
                    //result.Message = "";
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.Status = false;
                result.Message = ex.Message;
            }
            return result;
        }
    }
}

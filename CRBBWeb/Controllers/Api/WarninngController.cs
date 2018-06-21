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
    public class WarninngController : ApiController
    {
        public ApiResultViewModel<WarnFaultPopViewModel> Get()
        {
            ApiResultViewModel<WarnFaultPopViewModel> result = new ApiResultViewModel<WarnFaultPopViewModel>();
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Setting.ini");
                IniFile ini = new IniFile(filePath);
                bool isPop = bool.Parse(ini.ReadString("Warning", "Pop",""));
                bool isVoice = bool.Parse(ini.ReadString("Warning", "Voice", ""));
                if (isPop)
                {
                    int siteId = int.Parse(System.Configuration.ConfigurationManager.AppSettings["SiteId"]);
                    DataTable dt = CRBIYYBBReportProjectRule.Intance().GetWarnFaultPop(siteId);
                    List<WarnFaultPopViewModel> list = CRBICommonLib.ModelConvertHelper<WarnFaultPopViewModel>.ConvertToModel(dt);
                    if (list.Count <= 0)
                    {
                        result.Status = true;
                        result.Obj = null;
                        return result;
                    }
                    try
                    {
                        using (var httpClient = new HttpClient())
                        {
                            var url = new Uri(System.Configuration.ConfigurationManager.AppSettings["Knowledge"]);
                            var response = httpClient.GetAsync(url + "/GetExpertKnowledge?val=" + list[0].EventName + "&pageNo=1&pageSize=1&strOrder=CreateTime%20DESC&equipmentCategory=-1&keyWord=").Result;
                            var data = response.Content.ReadAsStringAsync().Result;
                            data = "{ExpertKnowledgeViewModel:" + data.Substring(0, data.LastIndexOf(']') + 1).Substring(data.IndexOf('[')) + "}";
                            data = data.Replace(@"\", "");
                            var model = JsonConvert.DeserializeObjectAsync<ExpertKnowledgesViewModel>(data).Result;
                            if (model.ExpertKnowledgeViewModel.Count > 0)
                            {
                                list[0].ExpertAdvice = model.ExpertKnowledgeViewModel[0].Solution ?? "";
                            }
                        }
                    }
                    catch
                    {
                        list[0].ExpertAdvice = "";
                    }
                    result.Status = true;
                    result.Obj = list[0];
                    if (isVoice)
                    {
                        result.Obj.IsVoice = true;
                    }
                }
                else
                {
                    result.Status = true;
                    result.Obj = null;
                }
            }
            catch (Exception ex)
            {
                result.Status = false;
                result.Message = ex.Message;
            }
            return result;
        }

        public ApiResultViewModel<bool> Post([FromBody]string postParam)
        {
            ApiResultViewModel<bool> result = new ApiResultViewModel<bool>();
            try
            {
                PostParamViewModel ppvm = JsonConvert.DeserializeObject<PostParamViewModel>(postParam);
                var isDelete = CRBIYYBBReportProjectRule.Intance().DeleteWarnFault(ppvm.ID);
                result.Status = true;
                result.Obj = isDelete;
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
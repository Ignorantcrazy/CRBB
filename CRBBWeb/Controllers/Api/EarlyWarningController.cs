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
    public class EarlyWarningController : ApiController
    {
        public ApiResultViewModel<EarlyWarningPopViewModel> Get()
        {
            ApiResultViewModel<EarlyWarningPopViewModel> result = new ApiResultViewModel<EarlyWarningPopViewModel>();
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Setting.ini");
                IniFile ini = new IniFile(filePath);
                bool isPop = bool.Parse(ini.ReadString("EarlyWarning", "Pop", ""));
                bool isVoice = bool.Parse(ini.ReadString("EarlyWarning", "Voice", ""));
                if (isPop)
                {
                    int siteId = int.Parse(System.Configuration.ConfigurationManager.AppSettings["SiteId"]);
                    DataTable dt = CRBIYYBBReportProjectRule.Intance().GetEarlyWarningPop(siteId);
                    List<EarlyWarningPopViewModel> list = CRBICommonLib.ModelConvertHelper<EarlyWarningPopViewModel>.ConvertToModel(dt);
                    if (list.Count <= 0)
                    {
                        result.Status = true;
                        result.Obj = null;
                        return result;
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
                var isDelete = CRBIYYBBReportProjectRule.Intance().DeleteEarlyWarning(ppvm.ID);
                result.Status = true;
                result.Obj = isDelete;
                return result;
            }
            catch (Exception ex)
            {
                result.Status = false;
                result.Message = ex.Message;
                return result;
            }
        }
    }
}

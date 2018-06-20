using CRBBWeb.Models;
using CRBICommonLib;
using CRBIReportLib.ReportBase;
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
    public class IsPopController : ApiController
    {
        public ApiResultViewModel<bool> Get()
        {
            ApiResultViewModel<bool> result = new ApiResultViewModel<bool>();
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
                        result.Status = false;
                        result.Obj = false;
                    }
                    else
                    {
                        result.Status = true;
                        result.Obj = true;
                    }
                }
                else
                {
                    result.Status = false;
                    result.Obj = false;
                }
                isPop = bool.Parse(ini.ReadString("Warning", "Pop", ""));
                if (isPop)
                {
                    int siteId = int.Parse(System.Configuration.ConfigurationManager.AppSettings["SiteId"]);
                    DataTable dt = CRBIYYBBReportProjectRule.Intance().GetWarnFaultPop(siteId);
                    List<WarnFaultPopViewModel> list = CRBICommonLib.ModelConvertHelper<WarnFaultPopViewModel>.ConvertToModel(dt);
                    if (list.Count <= 0)
                    {
                        if (!result.Status)
                        {
                            result.Status = false;
                            result.Obj = false;
                        }
                    }
                    else
                    {
                        result.Status = true;
                        result.Obj = true;
                    }
                }
                else
                {
                    if (!result.Status)
                    {
                        result.Status = false;
                        result.Obj = false;
                    }
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

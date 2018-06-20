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
    public class EWarningPollingBroadcastItemsController : ApiController
    {
        public ApiResultViewModel<List<Models.Y_EarlyWarningViewModels>> Get()
        {
            ApiResultViewModel<List<Y_EarlyWarningViewModels>> result = new ApiResultViewModel<List<Y_EarlyWarningViewModels>>();
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Setting.ini");
                IniFile ini = new IniFile(filePath);
                var isChecked = bool.Parse(ini.ReadString("PollingBroadcast", "Checked", ""));
                if (isChecked)
                {
                    int siteId = int.Parse(System.Configuration.ConfigurationManager.AppSettings["SiteId"]);
                    DataTable dt = CRBIYYBBReportProjectRule.Intance().GetEarlyWarning(siteId);
                    List<Y_EarlyWarningViewModels> list = CRBICommonLib.ModelConvertHelper<Y_EarlyWarningViewModels>.ConvertToModel(dt);
                    if (list.Count <= 0)
                    {
                        result.Status = false;
                        return result;
                    }
                    result.Status = true;
                    result.Obj = list;
                }
                else
                {
                    result.Status = false;
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

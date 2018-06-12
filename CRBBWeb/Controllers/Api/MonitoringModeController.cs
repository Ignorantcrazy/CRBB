using CRBBWeb.Models;
using CRBIReportLib.ReportBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRBBWeb.Controllers.Api
{
    public class MonitoringModeController : ApiController
    {
        public ApiResultViewModel<MonitoringModeViewModel> Get()
        {
            ApiResultViewModel<MonitoringModeViewModel> result = new ApiResultViewModel<MonitoringModeViewModel>();
            try
            {
                MonitoringModeViewModel model = new MonitoringModeViewModel();
                int siteId = int.Parse(System.Configuration.ConfigurationManager.AppSettings["SiteId"]);
                int count = 0;
                count = CRBIYYBBReportProjectRule.Intance().GetWarnFaultCount(siteId);
                if (count == 0)
                {
                    count = CRBIYYBBReportProjectRule.Intance().GetEarlyWarningCount(siteId);
                    if (count == 0)
                    {
                        model.Text = "正常";
                        model.Count = count;
                    }
                    else
                    {
                        model.Text = "预警";
                        model.Count = count;
                    }
                }
                else
                {
                    model.Text = "告警";
                    model.Count = count;
                }
                result.Status = true;
                result.Obj = model;
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

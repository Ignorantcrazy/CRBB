using CRBBWeb.Models;
using CRBIReportLib.ReportBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRBBWeb.Controllers
{
    public class ResourceMonitoringController : Controller
    {
        // GET: ResourceMonitoring
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetServiceResource()
        {
            var json = new JsonResults();
            var rm = new ResultModel();
            try
            {
                int siteId = int.Parse(System.Configuration.ConfigurationManager.AppSettings["SiteId"]);
                DataTable dt = CRBIYYBBReportProjectRule.Intance().GetServiceResource();
                List<ResourceMonitoringViewModel> list = CRBICommonLib.ModelConvertHelper<ResourceMonitoringViewModel>.ConvertToModel(dt);
                if (list.Count <= 0)
                {
                    rm.Message = "未查询到相关数据！";
                    rm.Status = false;
                    json.Data = rm;
                    return json;
                }
                ResourceMonitoringViewModel model = list[0];
                rm.Result = model;
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
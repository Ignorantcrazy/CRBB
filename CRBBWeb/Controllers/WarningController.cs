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
    public class WarningController : Controller
    {
        // GET: Warning
        public ActionResult Index()
        {
            int siteId = int.Parse(System.Configuration.ConfigurationManager.AppSettings["SiteId"]);
            DataTable dt = CRBIYYBBReportProjectRule.Intance().GetY_WarnFault(siteId);
            List<Y_WarnFaultViewModels> list = CRBICommonLib.ModelConvertHelper<Y_WarnFaultViewModels>.ConvertToModel(dt);
            return View(list);
        }
    }
}
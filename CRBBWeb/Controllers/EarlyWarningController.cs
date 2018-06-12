using CRBBWeb.Models;
using CRBICommonLib;
using CRBIReportLib.ReportBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRBBWeb.Controllers
{
    public class EarlyWarningController : Controller
    {
        // GET: EarlyWarning
        public ActionResult Index()
        {
            int siteId = int.Parse(System.Configuration.ConfigurationManager.AppSettings["SiteId"]);
            DataTable dt = CRBIYYBBReportProjectRule.Intance().GetEarlyWarning(siteId);
            List<Y_EarlyWarningViewModels> list = CRBICommonLib.ModelConvertHelper<Y_EarlyWarningViewModels>.ConvertToModel(dt);
            return View(list);
        }
    }
}
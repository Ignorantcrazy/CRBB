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
    public class ZeroFaultVendorController : Controller
    {
        // GET: ZeroFaultVendor
        public ActionResult Index()
        {
            int siteId = int.Parse(System.Configuration.ConfigurationManager.AppSettings["SiteId"]);
            DataTable dt = CRBIYYBBReportProjectRule.Intance().GetZeroFaultVendor(siteId);
            List<ZeroFaultVendorViewModel> list = CRBICommonLib.ModelConvertHelper<ZeroFaultVendorViewModel>.ConvertToModel(dt);
            return View(list);
        }
    }
}
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
    public class ZeroFaultEquipmentController : Controller
    {
        // GET: ZeroFaultEquipment
        public ActionResult Index()
        {
            int siteId = int.Parse(System.Configuration.ConfigurationManager.AppSettings["SiteId"]);
            DataTable dt = CRBIYYBBReportProjectRule.Intance().GetZeroFaultEquipment(siteId);
            List<ZeroFaultEquipmentViewModel> list = CRBICommonLib.ModelConvertHelper<ZeroFaultEquipmentViewModel>.ConvertToModel(dt);
            return View(list);
        }
    }
}
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
    public class RoomNewsletterController : Controller
    {
        // GET: RoomNewsletter
        public ActionResult Index()
        {
            int siteId = int.Parse(System.Configuration.ConfigurationManager.AppSettings["SiteId"]);
            DataTable dt = CRBIYYBBReportProjectRule.Intance().GetRoomNewsletter(siteId);
            List<EngineRoomReportViewModel> list = CRBICommonLib.ModelConvertHelper<EngineRoomReportViewModel>.ConvertToModel(dt);
            return View(list);
        }
    }
}
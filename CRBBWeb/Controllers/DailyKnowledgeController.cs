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
    public class DailyKnowledgeController : Controller
    {
        // GET: DailyKnowledge
        public ActionResult Index()
        {
            DataTable dt = CRBIYYBBReportProjectRule.Intance().GetDailyKnowledgePop();
            List<TipsViewModel> list = CRBICommonLib.ModelConvertHelper<TipsViewModel>.ConvertToModel(dt);
            Random r = new Random();
            int i = r.Next(1, list.Count);
            return View(list[i]);
        }
    }
}
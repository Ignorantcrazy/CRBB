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
    public class WeeklyCurveController : Controller
    {
        // GET: WeeklyCurve
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetWarnFault()
        {
            var json = new JsonResults();
            var rm = new ResultModel();
            try
            {
                int siteId = int.Parse(System.Configuration.ConfigurationManager.AppSettings["SiteId"]);
                string monday = DateTime.Now.AddDays(-((int)DateTime.Now.DayOfWeek - 1)).ToShortDateString();
                string sunday = DateTime.Now.AddDays(7 - ((int)DateTime.Now.DayOfWeek)).ToShortDateString();
                DataTable dtWeek = CRBIYYBBReportProjectRule.Intance().GetWarnFault(siteId, monday, sunday);
                List<WarnFaultViewModal> listWeek = CRBICommonLib.ModelConvertHelper<WarnFaultViewModal>.ConvertToModel(dtWeek);
                WeeklyCurveViewModal modalWeek = GetModal(monday, listWeek);

                sunday = DateTime.Now.AddDays(-((int)DateTime.Now.DayOfWeek)).ToShortDateString();
                monday = DateTime.Now.AddDays(-((int)DateTime.Now.DayOfWeek)).AddDays(-6).ToShortDateString();
                DataTable dtLastWeek = CRBIYYBBReportProjectRule.Intance().GetWarnFault(siteId, monday, sunday);
                List<WarnFaultViewModal> listLastWeek = CRBICommonLib.ModelConvertHelper<WarnFaultViewModal>.ConvertToModel(dtLastWeek);
                WeeklyCurveViewModal modalLastWeek = GetModal(monday, listLastWeek);
                WeeklyCurveResultViewModal modal = new WeeklyCurveResultViewModal();
                modal.WeeklyCurveWeek = modalWeek;
                modal.WeeklyCurveLastWeek = modalLastWeek;
                rm.Result = modal;
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

        private static WeeklyCurveViewModal GetModal(string monday, List<WarnFaultViewModal> list)
        {
            WeeklyCurveViewModal model = new WeeklyCurveViewModal();
            foreach (var item in list)
            {
                if (DateTime.Parse(item.WarnTime) == DateTime.Parse(monday))
                {
                    model.MondayNumber = item.Number;
                }
                if (DateTime.Parse(item.WarnTime) == DateTime.Parse(monday).AddDays(1))
                {
                    model.TuesdayNumber = item.Number;
                }
                if (DateTime.Parse(item.WarnTime) == DateTime.Parse(monday).AddDays(2))
                {
                    model.WednesdayNumber = item.Number;
                }
                if (DateTime.Parse(item.WarnTime) == DateTime.Parse(monday).AddDays(3))
                {
                    model.ThursdayNumber = item.Number;
                }
                if (DateTime.Parse(item.WarnTime) == DateTime.Parse(monday).AddDays(4))
                {
                    model.FridayNumber = item.Number;
                }
                if (DateTime.Parse(item.WarnTime) == DateTime.Parse(monday).AddDays(5))
                {
                    model.SaturdayNumber = item.Number;
                }
                if (DateTime.Parse(item.WarnTime) == DateTime.Parse(monday).AddDays(6))
                {
                    model.SundayNumber = item.Number;
                }
            }

            return model;
        }
    }
}
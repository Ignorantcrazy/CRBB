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
    public class EquipmentPerformanceController : Controller
    {
        // GET: EquipmentPerformance
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetEquipmentPerformance()
        {
            var json = new JsonResults();
            var rm = new ResultModel();
            try
            {
                int siteId = int.Parse(System.Configuration.ConfigurationManager.AppSettings["SiteId"]);
                DataTable dt = CRBIYYBBReportProjectRule.Intance().GetEquipmentPerformance(siteId);
                List<PerformanceViewModel> list = CRBICommonLib.ModelConvertHelper<PerformanceViewModel>.ConvertToModel(dt);
                PerformanceResultViewModel model = new PerformanceResultViewModel();
                model.Equipments = list.Select(m => m.EquipmentName).ToList();
                model.PerformanceData = new List<PerformanceDataViewModel>();
                PerformanceDataViewModel pdvm = GetPerformanceData(list, model,0);
                model.PerformanceData.Add(pdvm);
                pdvm = GetPerformanceData(list, model, 1);
                model.PerformanceData.Add(pdvm);
                pdvm = GetPerformanceData(list, model, 2);
                model.PerformanceData.Add(pdvm);
                pdvm = GetPerformanceData(list, model, 3);
                model.PerformanceData.Add(pdvm);
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

        private static PerformanceDataViewModel GetPerformanceData(List<PerformanceViewModel> list, PerformanceResultViewModel model,int grade)
        {
            PerformanceDataViewModel pdvm = new PerformanceDataViewModel();
            pdvm.Grade = Enum.GetName(typeof(GradeEnum), grade);
            pdvm.Score = new List<double>();
            foreach (var equipment in model.Equipments)
            {
                var listTemp = list.Where(m => m.EquipmentName == equipment && m.ScoreResult == grade).ToList();
                if (listTemp.Count > 0)
                {
                    pdvm.Score.Add(listTemp[0].EquipmentScore);
                }
                else
                {
                    pdvm.Score.Add(0);
                }
            }

            return pdvm;
        }
    }
}
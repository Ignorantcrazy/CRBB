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
    public class DutyOnDutyController : Controller
    {
        // GET: DutyOnDuty
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetDutyOnDuty()
        {
            var json = new JsonResults();
            var rm = new ResultModel();
            try
            {
                int siteId = int.Parse(System.Configuration.ConfigurationManager.AppSettings["SiteId"]);
                DataTable dtDutyOnDuty = CRBIYYBBReportProjectRule.Intance().GetDutyOnDuty(siteId);
                DataTable dtDutyOnDutyRemaining = CRBIYYBBReportProjectRule.Intance().GetDutyOnDutyRemaining(siteId);
                List<DutyOnDutyViewModel> listdd = CRBICommonLib.ModelConvertHelper<DutyOnDutyViewModel>.ConvertToModel(dtDutyOnDuty);
                List<DutyOnDutyRemainingViewModel> listddr = CRBICommonLib.ModelConvertHelper<DutyOnDutyRemainingViewModel>.ConvertToModel(dtDutyOnDutyRemaining);
                DutyOnDutyListViewModel dutyOnDutyListViewModel = new DutyOnDutyListViewModel();
                dutyOnDutyListViewModel.DutyOnDutyRemainingViewModel = listddr.Where(m => DateTime.Now > DateTime.Parse(m.ExecuteTime).AddDays(-7)).ToList();
                dutyOnDutyListViewModel.DutyOnDutyViewModel = listdd.Where(m => DateTime.Now > DateTime.Parse(m.PlanTime).AddDays(-7)).ToList();
                rm.Result = dutyOnDutyListViewModel;
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
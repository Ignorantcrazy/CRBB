using CRBBWeb.Models;
using CRBICommonLib;
using CRBIReportLib.ReportBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

        [HttpPost]
        public JsonResult PollingBroadcast(bool isChecked)
        {
            var json = new JsonResults();
            var rm = new ResultModel();
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Setting.ini");
                IniFile ini = new IniFile(filePath);
                ini.WriteString("EWarningPollingBroadcast", "Checked", isChecked.ToString());
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
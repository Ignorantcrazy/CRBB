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
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Setting.ini");
            IniFile ini = new IniFile(filePath);
            string defalutDate = ini.ReadString("FristOpenDate", "DateTime","");
            if (string.IsNullOrEmpty(defalutDate))
            {
                defalutDate = DateTime.Now.ToShortDateString();
                ini.WriteString("FristOpenDate", "DateTime", defalutDate);
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public JsonResult GetAlarmStatistics()
        {
            var json = new JsonResults();
            var rm = new ResultModel();
            try
            {
                int siteId = int.Parse(System.Configuration.ConfigurationManager.AppSettings["SiteId"]);
                DataTable dt = CRBIYYBBReportProjectRule.Intance().GetAlarmStatistics(siteId);
                List<AlarmStatisticsModel> list = CRBICommonLib.ModelConvertHelper<AlarmStatisticsModel>.ConvertToModel(dt);
                AlarmStatisticsViewModel asvm = new AlarmStatisticsViewModel();
                foreach (var item in list.Where(m => m.EventLevel == "一级告警"))
                {
                    if (item.EventType == 1)
                    {
                        asvm.OneMalfunctionNumber = item.Number;
                    }
                    if (item.EventType == 0)
                    {
                        asvm.OneWarningNumber = item.Number;
                    }
                }
                foreach (var item in list.Where(m => m.EventLevel == "二级告警"))
                {
                    if (item.EventType == 1)
                    {
                        asvm.TwoMalfunctionNumber = item.Number;
                    }
                    if (item.EventType == 0)
                    {
                        asvm.TwoWarningNumber = item.Number;
                    }
                }
                rm.Result = asvm;
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

        [HttpPost]
        public JsonResult GetEngineRoomScore()
        {
            var json = new JsonResults();
            var rm = new ResultModel();
            try
            {
                int siteId = int.Parse(System.Configuration.ConfigurationManager.AppSettings["SiteId"]);
                DataTable dt = CRBIYYBBReportProjectRule.Intance().GetEngineRoomScore(siteId);
                List<Y_EngineRoomScoreViewModel> list = CRBICommonLib.ModelConvertHelper<Y_EngineRoomScoreViewModel>.ConvertToModel(dt);
                Y_EngineRoomScoreViewModel model = list[0];
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

        [HttpPost]
        public JsonResult GetOperationCycle()
        {
            var json = new JsonResults();
            var rm = new ResultModel();
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Setting.ini");
                IniFile ini = new IniFile(filePath);
                string defaultDateStr = ini.ReadString("FristOpenDate", "DateTime", "");
                if (string.IsNullOrEmpty(defaultDateStr))
                {
                    defaultDateStr = DateTime.Now.ToShortDateString();
                }
                DateTime nowDate = DateTime.Now;
                DateTime defaultDate = DateTime.Parse(defaultDateStr);
                TimeSpan ts = nowDate - defaultDate;
                rm.Result = ts.Days.ToString();
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

        [HttpPost]
        public JsonResult GetEngineRoomScoreItem(int scoreId)
        {
            var json = new JsonResults();
            var rm = new ResultModel();
            try
            {
                DataTable dt = CRBIYYBBReportProjectRule.Intance().GetEngineRoomScoreItem(scoreId);
                List<Y_EngineRoomScoreItemModel> list = CRBICommonLib.ModelConvertHelper<Y_EngineRoomScoreItemModel>.ConvertToModel(dt);
                Y_EngineRoomScoreItemViewModel model = new Y_EngineRoomScoreItemViewModel();
                foreach (var item in list)
                {
                    switch ((EngineScoreItem)item.ScoreItemID)
                    {
                        case EngineScoreItem.支撑时间:
                            model.SupportTimeBaseScore = item.BaseScore;
                            model.SupportTimeScore = item.Score;
                            break;
                        case EngineScoreItem.健康状态:
                            model.HealthStatusBaseScore = item.BaseScore;
                            model.HealthStatusScore = item.Score;
                            break;
                        case EngineScoreItem.供电质量:
                            model.PowerQualityBaseScore = item.BaseScore;
                            model.PowerQualityScore = item.Score;
                            break;
                        case EngineScoreItem.设备容量富裕量:
                            model.CapacitySurplusBaseScore = item.BaseScore;
                            model.CapacitySurplusScore = item.Score;
                            break;
                        case EngineScoreItem.接地电阻:
                            model.EarthResistanceBaseScore = item.BaseScore;
                            model.EarthResistanceScore = item.Score;
                            break;
                        default:
                            break;
                    }
                }
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
    }
}
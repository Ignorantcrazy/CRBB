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
    public class SupportTimeController : Controller
    {
        // GET: SupportTime
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetSupportTime()
        {
            var json = new JsonResults();
            var rm = new ResultModel();
            try
            {
                int siteId = int.Parse(System.Configuration.ConfigurationManager.AppSettings["SiteId"]);
                int dc = (int)EquipmentTypeEnum.开关电源蓄电池组;
                int ups = (int)EquipmentTypeEnum.UPS蓄电池组;
                int generator = (int)EquipmentTypeEnum.发电机组;
                List<int> typeList = new List<int>();
                typeList.Add(dc);
                typeList.Add(ups);
                typeList.Add(generator);
                DataTable dt = CRBIYYBBReportProjectRule.Intance().GetSupportTime(siteId, typeList);
                List<SupportTimeModel> list = CRBICommonLib.ModelConvertHelper<SupportTimeModel>.ConvertToModel(dt);
                SupportTimeViewModel model = new SupportTimeViewModel();
                foreach (var item in list)
                {
                    switch ((EquipmentTypeEnum)item.EquipmentType)
                    {
                        case EquipmentTypeEnum.UPS蓄电池组:
                            if (model.UPSKeepTime == 0 || (item.KeepTime < model.UPSKeepTime && item.KeepTime != 0))
                            {
                                model.UPSKeepTime = item.KeepTime;
                                model.UPSEqName = item.EquipmentName;
                                model.UPSLifeTime = item.LifeTime;
                            }
                            break;
                        case EquipmentTypeEnum.开关电源蓄电池组:
                            if (model.DCKeepTime == 0 || (item.KeepTime < model.DCKeepTime && item.KeepTime != 0))
                            {
                                model.DCKeepTime = item.KeepTime;
                                model.DCEqName = item.EquipmentName;
                                model.DCLifeTime = item.LifeTime;
                            }
                            break;
                        case EquipmentTypeEnum.发电机组:
                            if (model.GeneratorKeepTime == 0 || (item.KeepTime < model.GeneratorKeepTime && item.KeepTime != 0))
                            {
                                model.GeneratorKeepTime = item.KeepTime;
                                model.GeneratorEqName = item.EquipmentName;
                                model.GeneratorLifeTime = item.LifeTime;
                            }
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
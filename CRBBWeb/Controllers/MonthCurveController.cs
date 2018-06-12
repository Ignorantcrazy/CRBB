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
    public class MonthCurveController : Controller
    {
        // GET: MonthCurve
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetMonthCurve()
        {
            var json = new JsonResults();
            var rm = new ResultModel();
            try
            {
                int siteId = int.Parse(System.Configuration.ConfigurationManager.AppSettings["SiteId"]);
                string firstday = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).ToShortDateString();
                string lastday = DateTime.Parse(firstday).AddMonths(1).AddDays(-1).ToShortDateString();
                DataTable dt = CRBIYYBBReportProjectRule.Intance().GetMonthCurve(siteId, firstday, lastday);
                List<MonthCurveViewModal> list = CRBICommonLib.ModelConvertHelper<MonthCurveViewModal>.ConvertToModel(dt);
                MonthCurveResultModal modal = new MonthCurveResultModal();
                modal.WarnTime = GetWarnTime(firstday, lastday);
                //modal.EqType = new List<string>();
                List<int> eqTypeTemp = new List<int>();
                foreach (var eqType in list.Select(m => m.EqType).Distinct().ToList())
                {
                    //modal.EqType.Add(Enum.GetName(typeof(EquipmentTypeEnum), eqType));
                    eqTypeTemp.Add(eqType);
                }
                modal.MonthCurveDataModal = new List<MonthCurveDataModal>();
                foreach (var eqType in eqTypeTemp)
                {
                    MonthCurveDataModal mcdm = new MonthCurveDataModal();

                    switch ((EquipmentTypeEnum)eqType)
                    {
                        case EquipmentTypeEnum.设备列表:
                            mcdm = GetMonthCurveDataModal(list, modal, eqType);
                            modal.MonthCurveDataModal.Add(mcdm);
                            break;
                        case EquipmentTypeEnum.ATS:
                            mcdm = GetMonthCurveDataModal(list, modal, eqType);
                            modal.MonthCurveDataModal.Add(mcdm);
                            break;
                        case EquipmentTypeEnum.交流配电柜:
                            mcdm = GetMonthCurveDataModal(list, modal, eqType);
                            modal.MonthCurveDataModal.Add(mcdm);
                            break;
                        case EquipmentTypeEnum.直流配电柜:
                            mcdm = GetMonthCurveDataModal(list, modal, eqType);
                            modal.MonthCurveDataModal.Add(mcdm);
                            break;
                        case EquipmentTypeEnum.交流列头柜:
                            mcdm = GetMonthCurveDataModal(list, modal, eqType);
                            modal.MonthCurveDataModal.Add(mcdm);
                            break;
                        case EquipmentTypeEnum.直流列头柜:
                            mcdm = GetMonthCurveDataModal(list, modal, eqType);
                            modal.MonthCurveDataModal.Add(mcdm);
                            break;
                        case EquipmentTypeEnum.UPS蓄电池组:
                            mcdm = GetMonthCurveDataModal(list, modal, eqType);
                            modal.MonthCurveDataModal.Add(mcdm);
                            break;
                        case EquipmentTypeEnum.开关电源蓄电池组:
                            mcdm = GetMonthCurveDataModal(list, modal, eqType);
                            modal.MonthCurveDataModal.Add(mcdm);
                            break;
                        case EquipmentTypeEnum.发电机组:
                            mcdm = GetMonthCurveDataModal(list, modal, eqType);
                            modal.MonthCurveDataModal.Add(mcdm);
                            break;
                        case EquipmentTypeEnum.开关电源:
                            mcdm = GetMonthCurveDataModal(list, modal, eqType);
                            modal.MonthCurveDataModal.Add(mcdm);
                            break;
                        case EquipmentTypeEnum.高频开关:
                            mcdm = GetMonthCurveDataModal(list, modal, eqType);
                            modal.MonthCurveDataModal.Add(mcdm);
                            break;
                        case EquipmentTypeEnum.主输出断路器:
                            mcdm = GetMonthCurveDataModal(list, modal, eqType);
                            modal.MonthCurveDataModal.Add(mcdm);
                            break;
                        case EquipmentTypeEnum.逆变电源:
                            mcdm = GetMonthCurveDataModal(list, modal, eqType);
                            modal.MonthCurveDataModal.Add(mcdm);
                            break;
                        case EquipmentTypeEnum.AS03:
                            mcdm = GetMonthCurveDataModal(list, modal, eqType);
                            modal.MonthCurveDataModal.Add(mcdm);
                            break;
                        case EquipmentTypeEnum.AS05:
                            mcdm = GetMonthCurveDataModal(list, modal, eqType);
                            modal.MonthCurveDataModal.Add(mcdm);
                            break;
                        case EquipmentTypeEnum.UPS设备:
                            mcdm = GetMonthCurveDataModal(list, modal, eqType);
                            modal.MonthCurveDataModal.Add(mcdm);
                            break;
                        case EquipmentTypeEnum.其它:
                            mcdm = GetMonthCurveDataModal(list, modal, eqType);
                            modal.MonthCurveDataModal.Add(mcdm);
                            break;
                        case EquipmentTypeEnum.接地电阻:
                            mcdm = GetMonthCurveDataModal(list, modal, eqType);
                            modal.MonthCurveDataModal.Add(mcdm);
                            break;
                        default:
                            break;
                    }
                }
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

        private MonthCurveDataModal GetMonthCurveDataModal(List<MonthCurveViewModal> list, MonthCurveResultModal modal, int eqType)
        {
            MonthCurveDataModal mcdm = new MonthCurveDataModal();
            mcdm.EqType = Enum.GetName(typeof(EquipmentTypeEnum), eqType);
            mcdm.Number = new List<int>();
            var mcvmListTemp = list.Where(m => m.EqType == eqType).ToList();
            if (mcvmListTemp.Count == 0)
            {
                foreach (var item in modal.WarnTime)
                {
                    mcdm.Number.Add(0);
                }
            }
            else
            {
                var listTemp = list.Where(m => m.EqType == eqType).ToList();
                    foreach (var item in modal.WarnTime)
                    {
                    bool flag = false;
                    foreach (var mcvm in listTemp)
                    {
                        if (DateTime.Parse(item) == DateTime.Parse(mcvm.WarnTime))
                        {
                            mcdm.Number.Add(mcvm.Number);
                            flag = true;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        mcdm.Number.Add(0);
                    }
                }
            }
            return mcdm;
        }

        private List<string> GetWarnTime(string firstday, string lastday)
        {
            List<string> list = new List<string>();
            list.Add(firstday);
            string tempTime = DateTime.Parse(firstday).AddDays(1).ToShortDateString();
            while (true)
            {
                list.Add(tempTime);
                if (tempTime == lastday)
                {
                    break;
                }
                tempTime = DateTime.Parse(tempTime).AddDays(1).ToShortDateString();
            }
            return list;
        }
    }
}
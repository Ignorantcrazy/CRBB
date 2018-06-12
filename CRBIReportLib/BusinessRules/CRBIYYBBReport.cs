using CRBIReportLib.DataAccessors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRBIReportLib.BusinessRules
{
    /// <summary>
    /// 运维保镖报表业务实体
    /// </summary>
    public class CRBIYYBBReport
    {
        #region 单例
        private static CRBIYYBBReport _report;
        private CRBIYYBBReport()
        { }
        public static CRBIYYBBReport Intance()
        {
            if (_report == null)
                _report = new CRBIYYBBReport();
            return _report;
        }
        #endregion

        #region  基本信息
        /// <summary>
        /// 电池型号
        /// </summary>
        public static string C0_DCXH;
        /// <summary>
        ///  生产厂家
        /// </summary>
        public static string C1_SCCJ;
        /// <summary>
        ///  安装日期
        /// </summary>
        public static string C2_ANRQ;
        /// <summary>
        ///  生产工艺
        /// </summary>
        public static string C3_SCGY;
        /// <summary>
        /// 机房名称
        /// </summary>
        public static string C4_JFMC;
        /// <summary>
        ///  电池组号
        /// </summary>
        public static string C5_DCZH;
        /// <summary>
        ///  整组类型
        /// </summary>
        public static string C6_ZZLX;
        /// <summary>
        ///  单体类型
        /// </summary>
        public static string C7_DTLX;
        /// <summary>
        /// 电池组数
        /// </summary>
        public static string C8_DCZS;
        /// <summary>
        /// 每组节数
        /// </summary>
        public static string C9_MZJS;
        /// <summary>
        /// 标称容量
        /// </summary>
        public static string C10_BCRL;
        /// <summary>
        ///  单节排序
        /// </summary>
        public static string C11_DJPX;
        /// <summary>
        /// 均充电压
        /// </summary>
        public static string C12_JCDY;
        /// <summary>
        /// 浮充电压
        /// </summary>
        public static string C13_FCDY;
        /// <summary>
        /// 充电时间
        /// </summary>
        public static string C14_CDSJ;
        /// <summary>
        /// 充电电流
        /// </summary>
        public static string C15_CDDL;
        /// <summary>
        /// 单体电压限
        /// </summary>
        public static string C16_DDDYX;
        /// <summary>
        /// 充入容量限
        /// </summary>
        public static string C17_CRRLX;
        /// <summary>
        /// 环境温度
        /// </summary>
        public static string C18_HJWD;
        /// <summary>
        /// 测试开始时间
        /// </summary>
        public static string C19_CSKSSJ;
        /// <summary>
        /// 终止原因
        /// </summary>
        public static string C20_ZZYY;
        /// <summary>
        /// 环境湿度
        /// </summary>
        public static string C21_HJSD;
        /// <summary>
        /// 测试持续时间
        /// </summary>
        public static string C22_CCCXSJ;
        /// <summary>
        /// 结论和方案
        /// </summary>
        public static DataTable C23_JLFATable;
        /// <summary>
        ///  正常节数
        /// </summary>
        public static string C25_ZCJS;
        /// <summary>
        /// 正常明细
        /// </summary>
        public static string C26_ZCMX;
        /// <summary>
        /// 落后节数
        /// </summary>
        public static string C27_LHJS;
        /// <summary>
        /// 落后明细
        /// </summary>
        public static string C28_LHMX;
        /// <summary>
        /// 严重落后节数
        /// </summary>
        public static string C29_YZLHJS;
        /// <summary>
        /// 严重落后明细
        /// </summary>
        public static string C30_YZLHMX;
        /// <summary>
        /// 电流曲线
        /// </summary>
        public static string C33_DLQXChart;
        /// <summary>
        /// 电压曲线
        /// </summary>
        public static string C32_DYQXChart;
        /// <summary>
        /// 充电曲线
        /// </summary>
        public static string C31_CDQXChart;

        #endregion

        #region 字段


        #endregion

        #region 图
        //public static string 
        #endregion


        #region 表

        #endregion

        /// <summary>
        /// 查询设备信息
        /// 存储过程 查询电池设备信息-PRT_QueryBatEquipmentInfo
        /// </summary>
        /// <param name="machineId"></param>
        /// <param name="groupNo"></param>
        /// <returns></returns>
        public DataTable GetBatEquipmentInfo(int machineId, int groupNo)
        {
            return CRBIYYBBDataAccessor.Instance().GetBatEquipmentInfo(machineId, groupNo);

        }

        public DataTable GetY_KeepTime(int sitedId, List<int> equipmentTypeList)
        {
            return CRBIYYBBDataAccessor.Instance().GetY_KeepTime(sitedId, equipmentTypeList);

        }

        public DataTable GetEarlyWarning(int siteId)
        {
            return CRBIYYBBDataAccessor.Instance().GetEarlyWarning(siteId);

        }

        public DataTable GetRoomNewsletter(int siteId)
        {
            return CRBIYYBBDataAccessor.Instance().GetRoomNewsletter(siteId);

        }

        public DataTable GetEngineRoomScore(int siteId)
        {
            return CRBIYYBBDataAccessor.Instance().GetEngineRoomScore(siteId);

        }

        public DataTable GetAlarmStatistics(int siteId)
        {
            return CRBIYYBBDataAccessor.Instance().GetAlarmStatistics(siteId);

        }

        public int GetEarlyWarningCount(int siteId)
        {
            return CRBIYYBBDataAccessor.Instance().GetEarlyWarningCount(siteId);

        }

        public int GetWarnFaultCount(int siteId)
        {
            return CRBIYYBBDataAccessor.Instance().GetWarnFaultCount(siteId);

        }

        public DataTable GetWarnFaultPop(int siteId)
        {
            return CRBIYYBBDataAccessor.Instance().GetWarnFaultPop(siteId);

        }
        public DataTable GetDailyKnowledgePop()
        {
            return CRBIYYBBDataAccessor.Instance().GetDailyKnowledgePop();

        }

        public DataTable GetEarlyWarningPop(int siteId)
        {
            return CRBIYYBBDataAccessor.Instance().GetEarlyWarningPop(siteId);

        }

        public bool DeleteEarlyWarning(int id)
        {
            return CRBIYYBBDataAccessor.Instance().DeleteEarlyWarning(id);
        }

        public bool DeleteWarnFault(int id)
        {
            return CRBIYYBBDataAccessor.Instance().DeleteWarnFault(id);
        }

        public DataTable GetWarnFault(int siteId, string startTime, string endTime)
        {
            return CRBIYYBBDataAccessor.Instance().GetWarnFault(siteId, startTime, endTime);

        }

        public DataTable GetMonthCurve(int siteId, string startTime, string endTime)
        {
            return CRBIYYBBDataAccessor.Instance().GetMonthCurve(siteId, startTime, endTime);

        }

        public DataTable GetEngineRoomScoreItem(int scoreId)
        {
            return CRBIYYBBDataAccessor.Instance().GetEngineRoomScoreItem(scoreId);

        }

        public DataTable GetY_WarnFault(int siteId)
        {
            return CRBIYYBBDataAccessor.Instance().GetY_WarnFault(siteId);

        }

        public DataTable GetDutyOnDuty(int siteId)
        {
            return CRBIYYBBDataAccessor.Instance().GetDutyOnDuty(siteId);

        }

        public DataTable GetDutyOnDutyRemaining(int siteId)
        {
            return CRBIYYBBDataAccessor.Instance().GetDutyOnDutyRemaining(siteId);

        }

        public DataTable GetServiceResource()
        {
            return CRBIYYBBDataAccessor.Instance().GetServiceResource();

        }

        public DataTable GetZeroFaultEquipment(int siteId)
        {
            return CRBIYYBBDataAccessor.Instance().GetZeroFaultEquipment(siteId);

        }

        public DataTable GetZeroFaultVendor(int siteId)
        {
            return CRBIYYBBDataAccessor.Instance().GetZeroFaultVendor(siteId);

        }

        public DataTable GetEquipmentPerformance(int siteId)
        {
            return CRBIYYBBDataAccessor.Instance().GetEquipmentPerformance(siteId);

        }
        /// <summary>
        /// 查询电池组信息
        /// 存储过程 查询电池组信息-PRT_QueryBatteryPackInfo
        /// </summary>
        /// <param name="machineId"></param>
        /// <param name="groupNo"></param>
        /// <returns></returns>
        public DataTable GetBetteryInfo(int machineId, int groupNo)
        {
            return CRBIYYBBDataAccessor.Instance().GetBatEquipmentInfo(machineId, groupNo);
        }
        /// <summary>
        /// 查询充电电池参数信息
        /// 存储过程 查询充电电池参数信息-PRT_QueryChargeBatteryParameter
        /// </summary>
        /// <param name="machineId"></param>
        /// <param name="groupNo"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public DataTable GetChargetParamas(int machineId, int groupNo, DateTime start, DateTime end)
        {
            return CRBIYYBBDataAccessor.Instance().GetChargetParamas(machineId, groupNo, start, end);
        }
        /// <summary>
        /// 查询放电电池参数信息
        /// 存储过程 查询放电电池参数信息-PRT_QueryDischargeBatteryParameter
        /// </summary>
        /// <param name="machineId"></param>
        /// <param name="groupNo"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public DataTable GetDisChargetParamas(int machineId, int groupNo, DateTime start, DateTime end)
        {
            return CRBIYYBBDataAccessor.Instance().GetDisChargetParamas(machineId, groupNo, start, end);
        }
        /// <summary>
        /// 查询内阻参数信息
        /// 存储过程 查询放电电池参数信息-PRT_QueryResistantParameter
        /// </summary>
        /// <param name="machineId"></param>
        /// <param name="groupNo"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public DataTable GetResistanceParamas(int machineId, int groupNo, DateTime start, DateTime end)
        {
            return CRBIYYBBDataAccessor.Instance().GetResistanceParamas(machineId, groupNo, start, end);
        }

        /// <summary>
        /// 查询放电测试结论信息
        /// </summary>
        /// <param name="machineId"></param>
        /// <param name="groupNo"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="testType"></param>
        /// <returns></returns>
        public DataTable GetDischargeTestResult(int machineId, int groupNo, DateTime start, DateTime end, int testType)
        {
            return CRBIYYBBDataAccessor.Instance().GetDischargeTestResult(machineId, groupNo, start, end, testType);
        }
        /// <summary>
        /// 查询放电测试数据信息
        /// </summary>
        /// <param name="machineId"></param>
        /// <param name="groupNo"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="testType"></param>
        /// <returns></returns>
        public DataTable GetDischargeTestData(int machineId, int groupNo, DateTime start, DateTime end, int testType)
        {
            return CRBIYYBBDataAccessor.Instance().GetDischargeTestData(machineId, groupNo, start, end, testType);
        }

        /// <summary>
        /// 查询充电测试结论信息
        /// </summary>
        /// <param name="machineId"></param>
        /// <param name="groupNo"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="testType"></param>
        /// <returns></returns>
        public DataTable GetChargeTestResult(int machineId, int groupNo, DateTime start, DateTime end, int testType)
        {
            return CRBIYYBBDataAccessor.Instance().GetChargeTestResult(machineId, groupNo, start, end, testType);
        }
        /// <summary>
        /// 查询充电测试数据信息
        /// </summary>
        /// <param name="machineId"></param>
        /// <param name="groupNo"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="testType"></param>
        /// <returns></returns>
        public DataTable GetChargeTestData(int machineId, int groupNo, DateTime start, DateTime end, int testType)
        {
            return CRBIYYBBDataAccessor.Instance().GetChargeTestData(machineId, groupNo, start, end, testType);
        }
        /// <summary>
        /// 查询内阻测试结论信息
        /// </summary>
        /// <param name="machineId"></param>
        /// <param name="groupNo"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="testType"></param>
        /// <returns></returns>
        public DataTable GetResistanceTestResult(int machineId, int groupNo, DateTime start, DateTime end, int testType)
        {
            return CRBIYYBBDataAccessor.Instance().GetResistanceTestResult(machineId, groupNo, start, end, testType);
        }
        /// <summary>
        /// 查询内阻测试数据信息
        /// </summary>
        /// <param name="machineId"></param>
        /// <param name="groupNo"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="testType"></param>
        /// <returns></returns>
        public DataTable GetResistanceTestData(int machineId, int groupNo, DateTime start, DateTime end, int testType)
        {
            return CRBIYYBBDataAccessor.Instance().GetResistanceTestData(machineId, groupNo, start, end, testType);
        }
    }
}

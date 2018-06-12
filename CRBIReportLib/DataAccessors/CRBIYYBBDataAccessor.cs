using Newegg.Oversea.Framework.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRBIReportLib.DataAccessors
{
    /// <summary>
    /// 运维保镖报表数据访问实体
    /// 该demo包含了了存储过程查询，和常规查询两种调用逻辑
    /// </summary>
    class CRBIYYBBDataAccessor
    {
        private static readonly CRBIYYBBDataAccessor _instance = new CRBIYYBBDataAccessor();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static CRBIYYBBDataAccessor Instance()
        {
            return _instance;
        }
        /// <summary>
        /// 查询设备信息
        /// 存储过程 查询电池设备信息-PRT_QueryBatEquipmentInfo
        /// </summary>
        /// <param name="machineId"></param>
        /// <param name="groupNo"></param>
        /// <returns></returns>
        public DataTable GetBatEquipmentInfo(int machineId, int groupNo)
        {
            return null;
            var dataCommand = DataCommandManager.GetDataCommand("PRT_QueryBatEquipmentInfo");
            dataCommand.SetParameterValue("@machineId", machineId);
            dataCommand.SetParameterValue("@groupNo", groupNo);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }

        public DataTable GetY_KeepTime(int sitedId, List<int> equipmentTypeList)
        {
            var dataCommand = DataCommandManager.GetDataCommand("getY_KeepTime");
            dataCommand.SetParameterValue("@StationId", sitedId);
            dataCommand.SetParameterValue("@EquipmentType1", equipmentTypeList[0]);
            dataCommand.SetParameterValue("@EquipmentType2", equipmentTypeList[1]);
            dataCommand.SetParameterValue("@EquipmentType3", equipmentTypeList[2]);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }

        public DataTable GetEarlyWarning(int siteId)
        {
            var dataCommand = DataCommandManager.GetDataCommand("getEarlyWarning");
            dataCommand.SetParameterValue("@StationId", siteId);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }

        public DataTable GetRoomNewsletter(int siteId)
        {
            var dataCommand = DataCommandManager.GetDataCommand("getEngineRoomReport");
            dataCommand.SetParameterValue("@StationId", siteId);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }

        public DataTable GetEngineRoomScore(int siteId)
        {
            var dataCommand = DataCommandManager.GetDataCommand("getY_EngineRoomScore");
            dataCommand.SetParameterValue("@StationId", siteId);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }

        public DataTable GetAlarmStatistics(int siteId)
        {
            var dataCommand = DataCommandManager.GetDataCommand("getAlarmStatistics");
            dataCommand.SetParameterValue("@StationId", siteId);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }

        public int GetEarlyWarningCount(int siteId)
        {
            var dataCommand = DataCommandManager.GetDataCommand("getEarlyWarning");
            dataCommand.SetParameterValue("@StationId", siteId);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result.Rows.Count;
        }

        public int GetWarnFaultCount(int siteId)
        {
            var dataCommand = DataCommandManager.GetDataCommand("getY_WarnFault");
            dataCommand.SetParameterValue("@StationId", siteId);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result.Rows.Count;
        }

        public DataTable GetWarnFaultPop(int siteId)
        {
            var dataCommand = DataCommandManager.GetDataCommand("getWarnFaultTemp");
            dataCommand.SetParameterValue("@StationId", siteId);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }

        public DataTable GetDailyKnowledgePop()
        {
            var dataCommand = DataCommandManager.GetDataCommand("getDailyKnowledge");
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }

        public DataTable GetEarlyWarningPop(int siteId)
        {
            var dataCommand = DataCommandManager.GetDataCommand("getEarlyWarningTemp");
            dataCommand.SetParameterValue("@StationId", siteId);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }

        public bool DeleteEarlyWarning(int id)
        {
            var dataCommand = DataCommandManager.GetDataCommand("DeleteEarlyWarningTemp");
            dataCommand.SetParameterValue("@ID", id);
            var result = dataCommand.ExecuteNonQuery();
            return result > 0;
        }

        public bool DeleteWarnFault(int id)
        {
            var dataCommand = DataCommandManager.GetDataCommand("DeleteWarnFaultTemp");
            dataCommand.SetParameterValue("@ID", id);
            var result = dataCommand.ExecuteNonQuery();
            return result > 0;
        }

        public DataTable GetWarnFault(int siteId, string startTime, string endTime)
        {
            var dataCommand = DataCommandManager.GetDataCommand("getWarnFault");
            //dataCommand.SetParameterValue("@StationId", siteId);
            dataCommand.SetParameterValue("@StartTime", startTime);
            dataCommand.SetParameterValue("@EndTime", endTime);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }

        public DataTable GetMonthCurve(int siteId, string startTime, string endTime)
        {
            var dataCommand = DataCommandManager.GetDataCommand("getWarnFaultByEqType");
            //dataCommand.SetParameterValue("@StationId", siteId);
            dataCommand.SetParameterValue("@StartTime", startTime);
            dataCommand.SetParameterValue("@EndTime", endTime);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }

        public DataTable GetEngineRoomScoreItem(int scoreId)
        {
            var dataCommand = DataCommandManager.GetDataCommand("getEngineRoomScoreItem");
            dataCommand.SetParameterValue("@scoreID", scoreId);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }

        public DataTable GetY_WarnFault(int siteId)
        {
            var dataCommand = DataCommandManager.GetDataCommand("getY_WarnFault");
            dataCommand.SetParameterValue("@StationId", siteId);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }

        public DataTable GetDutyOnDuty(int siteId)
        {
            var dataCommand = DataCommandManager.GetDataCommand("getMaintenance");
            dataCommand.SetParameterValue("@StationId", siteId);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }

        public DataTable GetDutyOnDutyRemaining(int siteId)
        {
            var dataCommand = DataCommandManager.GetDataCommand("getMaintenanceRemaining");
            dataCommand.SetParameterValue("@StationId", siteId);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }

        public DataTable GetServiceResource()
        {
            var dataCommand = DataCommandManager.GetDataCommand("getServiceResource");
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }

        public DataTable GetZeroFaultEquipment(int siteId)
        {
            var dataCommand = DataCommandManager.GetDataCommand("getZeroFaultEquipment");
            dataCommand.SetParameterValue("@StationId", siteId);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }

        public DataTable GetZeroFaultVendor(int siteId)
        {
            var dataCommand = DataCommandManager.GetDataCommand("getZeroFaultVendor");
            dataCommand.SetParameterValue("@StationId", siteId);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }

        public DataTable GetEquipmentPerformance(int siteId)
        {
            var dataCommand = DataCommandManager.GetDataCommand("getEquipmentPerformance");
            dataCommand.SetParameterValue("@StationId", siteId);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
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
            return null;
            var dataCommand = DataCommandManager.GetDataCommand("PRT_QueryBatteryPackInfo");
            dataCommand.SetParameterValue("@machineId", machineId);
            dataCommand.SetParameterValue("@groupNo", groupNo);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
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
            return null;
            var dataCommand = DataCommandManager.GetDataCommand("PRT_QueryChargeBatteryParameter");
            dataCommand.SetParameterValue("@machineId", machineId);
            dataCommand.SetParameterValue("@groupNo", groupNo);
            dataCommand.SetParameterValue("@start", start);
            dataCommand.SetParameterValue("@groupNo", end);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
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
            return null;
            var dataCommand = DataCommandManager.GetDataCommand("PRT_QueryDischargeBatteryParameter");
            dataCommand.SetParameterValue("@machineId", machineId);
            dataCommand.SetParameterValue("@groupNo", groupNo);
            dataCommand.SetParameterValue("@start", start);
            dataCommand.SetParameterValue("@groupNo", end);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
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
            return null;
            var dataCommand = DataCommandManager.GetDataCommand("PRT_QueryResistantParameter");
            dataCommand.SetParameterValue("@machineId", machineId);
            dataCommand.SetParameterValue("@groupNo", groupNo);
            dataCommand.SetParameterValue("@start", start);
            dataCommand.SetParameterValue("@groupNo", end);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
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
            return null;
            var dataCommand = DataCommandManager.GetDataCommand("loadSamplePolitApplyCityNumAndRate");
            dataCommand.SetParameterValue("@machineId", machineId);
            dataCommand.SetParameterValue("@groupNo", groupNo);
            dataCommand.SetParameterValue("@start", start);
            dataCommand.SetParameterValue("@groupNo", end);
            dataCommand.SetParameterValue("@testType", testType);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
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
            return null;
            var dataCommand = DataCommandManager.GetDataCommand("loadSamplePolitApplyCityNumAndRate");
            dataCommand.SetParameterValue("@machineId", machineId);
            dataCommand.SetParameterValue("@groupNo", groupNo);
            dataCommand.SetParameterValue("@start", start);
            dataCommand.SetParameterValue("@groupNo", end);
            dataCommand.SetParameterValue("@testType", testType);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
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
            return null;
            var dataCommand = DataCommandManager.GetDataCommand("loadSamplePolitApplyCityNumAndRate");
            dataCommand.SetParameterValue("@machineId", machineId);
            dataCommand.SetParameterValue("@groupNo", groupNo);
            dataCommand.SetParameterValue("@start", start);
            dataCommand.SetParameterValue("@groupNo", end);
            dataCommand.SetParameterValue("@testType", testType);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
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
            return null;
            var dataCommand = DataCommandManager.GetDataCommand("loadSamplePolitApplyCityNumAndRate");
            dataCommand.SetParameterValue("@machineId", machineId);
            dataCommand.SetParameterValue("@groupNo", groupNo);
            dataCommand.SetParameterValue("@start", start);
            dataCommand.SetParameterValue("@groupNo", end);
            dataCommand.SetParameterValue("@testType", testType);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
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
            return null;
            var dataCommand = DataCommandManager.GetDataCommand("loadSamplePolitApplyCityNumAndRate");
            dataCommand.SetParameterValue("@machineId", machineId);
            dataCommand.SetParameterValue("@groupNo", groupNo);
            dataCommand.SetParameterValue("@start", start);
            dataCommand.SetParameterValue("@groupNo", end);
            dataCommand.SetParameterValue("@testType", testType);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
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
            return null;
            var dataCommand = DataCommandManager.GetDataCommand("loadSamplePolitApplyCityNumAndRate");
            dataCommand.SetParameterValue("@machineId", machineId);
            dataCommand.SetParameterValue("@groupNo", groupNo);
            dataCommand.SetParameterValue("@start", start);
            dataCommand.SetParameterValue("@groupNo", end);
            dataCommand.SetParameterValue("@testType", testType);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }
    }
}

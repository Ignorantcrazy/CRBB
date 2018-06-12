using Newegg.Oversea.Framework.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRBIReportLib.DataAccessors
{
    public class CRBITBL_TestDataAccessor
    {
        private static readonly CRBITBL_TestDataAccessor _instance = new CRBITBL_TestDataAccessor();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static CRBITBL_TestDataAccessor Instance()
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


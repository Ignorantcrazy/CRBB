using CRBIReportLib.BusinessRules;
using System;                                                                                                                                                  
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRBIReportLib.ReportBase
{
    /// <summary>
    /// 运维保镖报表工程类
    /// </summary>
    public class CRBIYYBBReportProjectRule
    {
        #region 单例
        private static CRBIYYBBReportProjectRule _project;
        private CRBIYYBBReportProjectRule()
        { }
        public static CRBIYYBBReportProjectRule Intance()
        {
            if (_project == null)
                _project = new CRBIYYBBReportProjectRule();
            return _project;
        }
        #endregion

        #region 健康评估
        /// <summary>
        /// 周报数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetHealthweeklyData()
        {
            DataTable dt = new DataTable();

            return dt;
        }

        /// <summary>
        /// 区域级近一周整体健康状态
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public ChartJson LoadData_A_7D_ZTJKZT(CRBIHttpContextQuery context)
        {
            return get_A_7D_ZTJKZT_SQJsonData(context);
        }
        /// <summary>
        /// 站点级近一周整体健康状态
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public ChartJson LoadData_S_7D_ZTJKZT(CRBIHttpContextQuery context)
        {
            return get_S_7D_ZTJKZT_SQJsonData(context);
        }

        /// <summary>
        /// 区域级综合保障能力
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public ChartJson LoadData_A_ZHBBNL(CRBIHttpContextQuery context)
        {
            return get_A_ZHBBNL_SQJsonData(context);
        }
        /// <summary>
        /// 站点级综合保障能力
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public ChartJson LoadData_S_ZHBBNL(CRBIHttpContextQuery context)
        {
            return get_S_ZHBBNL_SQJsonData(context);
        }

        /// <summary>
        /// 区域级综合评估雷达
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public ChartJson LoadData_A_ZHPGLD(CRBIHttpContextQuery context)
        {
            return get_A_ZHPGLD_SQJsonData(context);
        }
        /// <summary>
        /// 站点级综合评估雷达
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public ChartJson LoadData_S_ZHPGLD(CRBIHttpContextQuery context)
        {
            return get_S_ZHPGLD_SQJsonData(context);
        }

        /// <summary>
        /// 区域级无故障运行天数
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public ChartJson LoadData_A_WGZYXTS(CRBIHttpContextQuery context)
        {
            return get_A_WGZYXTS_SQJsonData(context);
        }
       
        /// <summary>
        /// 站点级无故障运行天数
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public ChartJson LoadData_S_WGZYXTS(CRBIHttpContextQuery context)
        {
            return get_S_WGZYXTS_SQJsonData(context);
        }

        /// <summary>
        /// 获取零故障设备
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public DataTable LoadData_A_S_ZeroBugMachine(CRBIHttpContextQuery context)
        {
            return get_A_S_ZeroBugMachine(context);
        }

        /// <summary>
        /// 获取零故障设备
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public DataTable LoadData_S_ZeroBugMachine(CRBIHttpContextQuery context)
        {
            return get_A_S_ZeroBugMachine(context);
        }

        /// <summary>
        /// 获取区域级零故障设备厂商
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public DataTable LoadData_A_ZeroBugFactory(CRBIHttpContextQuery context)
        {
            return get_A_S_ZeroBugFactory(context);
        }

        /// <summary>
        /// 获取站点级零故障设备厂商
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public DataTable LoadData_S_ZeroBugFactory(CRBIHttpContextQuery context)
        {
            return get_A_S_ZeroBugFactory(context);
        }

        /// <summary>
        /// 区域级告警分布
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public DataTable LoadData_A_AlarmDistribution(CRBIHttpContextQuery context)
        {
            return get_A_S_AlarmDistribution(context);
        }

        /// <summary>
        /// 站点级告警分布
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public DataTable LoadData_S_AlarmDistribution(CRBIHttpContextQuery context)
        {
            return get_A_S_AlarmDistribution(context);
        }

        /// <summary>
        /// 站点级获取一周告警分布
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public ChartJson LoadData_S_AlarmDistributionByDate_1Week(CRBIHttpContextQuery context)
        {
            return get_S_AlarmDistributionByDate();
        }
        /// <summary>
        /// 站点级获取一周活动告警分布
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public ChartJson LoadData_S_ActiveAlarmDistributionByDate_1Week(CRBIHttpContextQuery context)
        {
            return get_S_ActiveAlarmDistributionByDate();
        }

        /// <summary>
        /// 站点级获取各站点历史告警统计
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public ChartJson LoadData_S_HistoryAlarmCountByMonth(CRBIHttpContextQuery context)
        {
            return get_S_ActiveAlarmDistributionByDate();
        }

        /// <summary>
        /// 区域级告警处理时效性分析
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public ChartJson LoadData_A_AlarmDisposeTimes(CRBIHttpContextQuery context)
        {
            return get_A_S_AlarmDisposeTimes();
        }

        /// <summary>
        /// 站点级告警处理时效性分析
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public ChartJson LoadData_S_AlarmDisposeTimes(CRBIHttpContextQuery context)
        {
            return get_A_S_AlarmDisposeTimes();
        }


        /// <summary>
        /// 区域级重点关注下周告警分布
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public ChartJson LoadData_A_AlarmDistribution_NextWeek(CRBIHttpContextQuery context)
        {
            return get_A_S_AlarmDistribution_NextWeek();
        }
        /// <summary>
        /// 站点级重点关注下周告警分布
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public ChartJson LoadData_S_AlarmDistribution_NextWeek(CRBIHttpContextQuery context)
        {
            return get_A_S_AlarmDistribution_NextWeek();
        }

        /// <summary>
        /// 站点级重点关注设备
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public ChartJson LoadData_S_VIPMachine(CRBIHttpContextQuery context)
        {
            return get_A_S_VIPMachine();
        }
        
        /// <summary>
        /// 站点级维护任务燃尽图
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public ChartJson LoadData_S_TaskBrunDownChart(CRBIHttpContextQuery context)
        {
            return get_A_S_TaskBrunDownChar();
        }

        /// <summary>
        /// 站点级每日知识
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public DataTable LoadData_S_DailyKnowledge(CRBIHttpContextQuery context)
        {
            return get_S_DailyKnowledge();
        }


        /// <summary>
        /// 站点级维护计划
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public DataTable LoadData_S_TodoTask(CRBIHttpContextQuery context)
        {
            return get_S_TodoTask();
        }

        /// <summary>
        /// 站点设备信息
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public DataTable LoadData_S_MachineInfo(CRBIHttpContextQuery context)
        {
            return get_A_S_MachineInfo();
        }

        /// <summary>
        /// 区域级支撑时间
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public DataTable LoadData_A_SupportTime(CRBIHttpContextQuery context)
        {
            return get_A_S_SupportTime();
        }
        /// <summary>
        /// 站点级支撑时间
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public DataTable LoadData_S_SupportTime(CRBIHttpContextQuery context)
        {
            return get_A_S_SupportTime();
        }

        /// <summary>
        /// 服务器信息
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public DataTable LoadData_IMUInfo(CRBIHttpContextQuery context)
        {
            return get_IMUInfo();
        }

        /// <summary>
        /// 当前值机信息
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public DataTable LoadData_CurrentPCinfo(CRBIHttpContextQuery context)
        {
            return get_CurrentPCinfo();
        }

        
        


        /// <summary>
        ///  区域级近一周整体健康状态
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private ChartJson get_A_7D_ZTJKZT_SQJsonData(CRBIHttpContextQuery context)
        {
            return new ChartJson();
            //throw new NotImplementedException();
        }
        /// <summary>
        /// 站点级近一周整体健康状态
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private ChartJson get_S_7D_ZTJKZT_SQJsonData(CRBIHttpContextQuery context)
        {
            ChartJson json = new ChartJson();
            json.charttype = context.charttype;
            json.xAxis.Add(new xAxisItemJson() { categories = new List<string>() { }, crosshair = true });
            if (context.querydateflag == 0)
            {
                context.startDate = DateTime.Now.AddDays(-7);
            }
            //else 
            //{
            //    context.startDate = DateTime.Now.AddMonths(-1);
            //}
            
            context.endDate = DateTime.Now;
            for (int i = 0; i < 7; i++) //添加近一周日期
            {
                json.series.Add(new SeriesItemJson(context.startDate.AddDays(i).ToString("mm-dd")));
            }

            DataTable table = null;

            //查询某站点各设备运行数据
            table = CRBIYYBBReport.Intance().GetBatEquipmentInfo(0, 0);

            //GDPAPatentChartBaseDataQuery query = new GDPAPatentChartBaseDataQuery()
            //{
            //    n_PatentStatus = context.type,
            //    d_StartDate = context.startDate,
            //    d_EndDate = context.endDate,
            //    n_PatentType = context.patenttype
            //};

           
            //table = (context.patenttype == 0) ? GDPAPatentChartBaseDataAccessor.Instance().loadDataWZLXSQRZLSQSLT(query) :
            //                      GDPAPatentChartBaseDataAccessor.Instance().loadDataXXXLX_ZLSQRLXZKT(query);

            //申请人类型：1：大专院校，2：科研机构，3：企业，4：机关团体，5：个人
            StringBuilder categories = new StringBuilder("[");
            //#region //获取大专院校
            //var t_fm = table.Select(String.Format("(n_ApplicanterType ={0})", 1));
            //json.series[0].data.Add(t_fm.Length > 0 ? Int32.Parse(t_fm[0]["n_Count"].ToString()) : 0);
            //#endregion

            //#region  //获取科研机构
            //t_fm = table.Select(String.Format("(n_ApplicanterType ={0} )", 2));
            //json.series[1].data.Add(t_fm.Length > 0 ? Int32.Parse(t_fm[0]["n_Count"].ToString()) : 0);
            //#endregion

            //#region //获取企业
            //t_fm = table.Select(String.Format("(n_ApplicanterType ={0} )", 3));
            //json.series[2].data.Add(t_fm.Length > 0 ? Int32.Parse(t_fm[0]["n_Count"].ToString()) : 0);
            //#endregion

            //#region //获取机关团体
            //t_fm = table.Select(String.Format("(n_ApplicanterType ={0} )", 4));
            //json.series[3].data.Add(t_fm.Length > 0 ? Int32.Parse(t_fm[0]["n_Count"].ToString()) : 0);
            //#endregion

            //#region //获取个人
            //t_fm = table.Select(String.Format("(n_ApplicanterType ={0} )", 5));
            //json.series[4].data.Add(t_fm.Length > 0 ? Int32.Parse(t_fm[0]["n_Count"].ToString()) : 0);
            //#endregion

            return json;
        }
       

        /// <summary>
        /// 区域级综合保障能力
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private ChartJson get_A_ZHBBNL_SQJsonData(CRBIHttpContextQuery context)
        {
            ChartJson json = new ChartJson();
            json.charttype = context.charttype;
            json.xAxis.Add(new xAxisItemJson() { categories = new List<string>() { }, crosshair = true });
            

            return json;
        }
        /// <summary>
        /// 站点级综合保证能力
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private ChartJson get_S_ZHBBNL_SQJsonData(CRBIHttpContextQuery context)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 区域级综合评估雷达
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private ChartJson get_A_ZHPGLD_SQJsonData(CRBIHttpContextQuery context)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 站点级综合评估雷达
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private ChartJson get_S_ZHPGLD_SQJsonData(CRBIHttpContextQuery context)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 区域级无故障运行天数
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private ChartJson get_A_WGZYXTS_SQJsonData(CRBIHttpContextQuery context)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 站点级无故障运行天数
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private ChartJson get_S_WGZYXTS_SQJsonData(CRBIHttpContextQuery context)
        {
            throw new NotImplementedException();
        }
       
        /// <summary>
        /// 获取零故障设备
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private DataTable get_A_S_ZeroBugMachine(CRBIHttpContextQuery context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取零故障设备厂商
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private DataTable get_A_S_ZeroBugFactory(CRBIHttpContextQuery context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取区域级，站点级告警分布
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private DataTable get_A_S_AlarmDistribution(CRBIHttpContextQuery context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 基于时间获取站点级告警分布
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private ChartJson get_S_AlarmDistributionByDate()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 基于时间获取活动告警分布
        /// </summary>
        /// <returns></returns>
        private ChartJson get_S_ActiveAlarmDistributionByDate()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 告警处理时效性分析
        /// </summary>
        /// <returns></returns>
        private ChartJson get_A_S_AlarmDisposeTimes()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  重点关注下周告警分布
        /// </summary>
        /// <returns></returns>
        private ChartJson get_A_S_AlarmDistribution_NextWeek()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 重点关注设备
        /// </summary>
        /// <returns></returns>
        private ChartJson get_A_S_VIPMachine()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  维护任务燃尽图
        /// </summary>
        /// <returns></returns>
        private ChartJson get_A_S_TaskBrunDownChar()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 站点级每日知识
        /// </summary>
        /// <returns></returns>
        private DataTable get_S_DailyKnowledge()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 站点级维护计划
        /// </summary>
        /// <returns></returns>
        private DataTable get_S_TodoTask()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取区域，站点设备信息
        /// </summary>
        /// <returns></returns>
        private DataTable get_A_S_MachineInfo()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 支撑时间
        /// </summary>
        /// <returns></returns>
        private DataTable get_A_S_SupportTime()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 服务器信息
        /// </summary>
        /// <returns></returns>
        private DataTable get_IMUInfo()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 当前值机信息
        /// </summary>
        /// <returns></returns>
        private DataTable get_CurrentPCinfo()
        {
            throw new NotImplementedException();
        }


        
        #endregion

        #region 运维保镖
        /// <summary>
        /// 支撑时间
        /// </summary>
        /// <returns></returns>
        public DataTable GetSupportTime(int siteId,List<int> equipmentTypeList)
        {
           return CRBIYYBBReport.Intance().GetY_KeepTime(siteId, equipmentTypeList); 
        }

        /// <summary>
        /// 预警
        /// </summary>
        /// <returns></returns>
        public DataTable GetEarlyWarning(int siteId)
        {
            return CRBIYYBBReport.Intance().GetEarlyWarning(siteId);
        }

        public DataTable GetRoomNewsletter(int siteId)
        {
            return CRBIYYBBReport.Intance().GetRoomNewsletter(siteId);
        }

        public DataTable GetEngineRoomScore(int siteId)
        {
            return CRBIYYBBReport.Intance().GetEngineRoomScore(siteId);
        }
        public DataTable GetAlarmStatistics(int siteId)
        {
            return CRBIYYBBReport.Intance().GetAlarmStatistics(siteId);
        }


        public int GetEarlyWarningCount(int siteId)
        {
            return CRBIYYBBReport.Intance().GetEarlyWarningCount(siteId);
        }

        public int GetWarnFaultCount(int siteId)
        {
            return CRBIYYBBReport.Intance().GetWarnFaultCount(siteId);
        }

        public DataTable GetWarnFaultPop(int siteId)
        {
            return CRBIYYBBReport.Intance().GetWarnFaultPop(siteId);
        }

        public DataTable GetDailyKnowledgePop()
        {
            return CRBIYYBBReport.Intance().GetDailyKnowledgePop();
        }

        public DataTable GetEarlyWarningPop(int siteId)
        {
            return CRBIYYBBReport.Intance().GetEarlyWarningPop(siteId);
        }

        public bool DeleteEarlyWarning(int id)
        {
            return CRBIYYBBReport.Intance().DeleteEarlyWarning(id);
        }

        public bool DeleteWarnFault(int id)
        {
            return CRBIYYBBReport.Intance().DeleteWarnFault(id);
        }

        public DataTable GetWarnFault(int siteId,string startTime,string endTime)
        {
            return CRBIYYBBReport.Intance().GetWarnFault(siteId, startTime, endTime);
        }

        public DataTable GetMonthCurve(int siteId, string startTime, string endTime)
        {
            return CRBIYYBBReport.Intance().GetMonthCurve(siteId, startTime, endTime);
        }

        public DataTable GetEngineRoomScoreItem(int scoreId)
        {
            return CRBIYYBBReport.Intance().GetEngineRoomScoreItem(scoreId);
        }

        public DataTable GetY_WarnFault(int siteId)
        {
            return CRBIYYBBReport.Intance().GetY_WarnFault(siteId);
        }

        public DataTable GetDutyOnDuty(int siteId)
        {
            return CRBIYYBBReport.Intance().GetDutyOnDuty(siteId);
        }

        public DataTable GetDutyOnDutyRemaining(int siteId)
        {
            return CRBIYYBBReport.Intance().GetDutyOnDutyRemaining(siteId);
        }

        public DataTable GetServiceResource()
        {
            return CRBIYYBBReport.Intance().GetServiceResource();
        }

        public DataTable GetZeroFaultEquipment(int siteId)
        {
            return CRBIYYBBReport.Intance().GetZeroFaultEquipment(siteId);
        }

        public DataTable GetZeroFaultVendor(int siteId)
        {
            return CRBIYYBBReport.Intance().GetZeroFaultVendor(siteId);
        }

        public DataTable GetEquipmentPerformance(int siteId)
        {
            return CRBIYYBBReport.Intance().GetEquipmentPerformance(siteId);
        }
        #endregion


        #region 广东省申请，授权数据
        /// <summary>
        /// 数据来源：GDPAPatentChartBaseData
        /// 历年
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private void getChartJsonData_AllYear(CRBIHttpContextQuery query, ChartJson json, out DataTable table)
        {
            var startYear = 1985;
            var endYear = 2017;// query.d_EndDate.Year;
            var zeroYear = 2000;
            table = new DataTable();
            //table = GDPAPatentChartBaseDataAccessor.Instance().loadDataZLSQSLQST_LN(query);
            //json.series.Add(new SeriesItemJson("总量"));
            //json.series.Add(new SeriesItemJson("总量增长率"));
            //string xAxisName = "";
            //for (int i = zeroYear; i <= endYear; i++)
            //{
            //    if (i <= zeroYear)
            //    {
            //        xAxisName = string.Format("{0}-{1}年", startYear, zeroYear);
            //        json.xAxis[0].categories.Add(xAxisName);
            //        getSeriesDataByPatentType(query.n_PatentType, json, table, i, "(n_PatentType ={0} )And ((n_Year>=1985)And (n_Year<={1}))",true);
            //    }
            //    else
            //    {
            //        xAxisName = string.Format("{0}年", i);
            //        json.xAxis[0].categories.Add(xAxisName);
            //        getSeriesDataByPatentType(query.n_PatentType, json, table, i, "(n_PatentType ={0} )And (n_Year={1})", true);
            //    }
            //}
            //统计总量
            //for (int i = 0; i < json.series[0].data.Count; i++)
            //{
            //    var sum = json.series[0].data[i] + json.series[1].data[i] + json.series[2].data[i];
            //    var szzl = json.series[0].data_f[i] + json.series[1].data_f[i] + json.series[2].data_f[i];
            //    json.series[3].data.Add(sum);
            //    json.series[3].data_f.Add(szzl);
            //}
        }
        /// <summary>
        /// 数据来源：GDPAPatentChartBaseData
        /// 当年
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private void getChartJsonData_ThisYear(CRBIHttpContextQuery query, ChartJson json, out DataTable table)
        {
            table = new DataTable();
            //table = GDPAPatentChartBaseDataAccessor.Instance().loadDataZLSQSLQST_Y(query);

            //for (int i = query.d_StartDate.Month; i <= query.d_EndDate.Month; i++)
            //{
            //    string month = (i < 10) ? string.Format("0{0}月", i) : string.Format("{0}月", i);
            //    json.xAxis[0].categories.Add(month);
            //    getSeriesDataByPatentType(query.n_PatentType, json, table, i, "(n_PatentType ={0})And (n_Month={1})");
            //}
        }
        private void getSeriesDataByPatentType(int patenttype, ChartJson json, DataTable table, int year, string sWhere, bool isCount = false)
        {
            DataRow[] t_fm = null;
            var count = 0;
            var zzl = 0.0;
            #region //获取发明数据
            if (patenttype == 0 || patenttype == 1)
            {
                t_fm = table.Select(String.Format(sWhere, 1, year));
                count = 0;
                zzl = 0.0;
                for (int i = 0; i < t_fm.Length; i++)
                {
                    count += Int32.Parse(t_fm[i]["n_Count"].ToString());
                    zzl += Math.Round(Convert.ToDouble(t_fm[i]["ZZL"].ToString()), 4);
                }
                json.series[0].data.Add(count);
                json.series[0].data_f.Add(zzl);
                if (patenttype == 1)
                {
                    json.series[1].data.Add(0);
                    json.series[1].data_f.Add(0);
                    json.series[2].data.Add(0);
                    json.series[2].data_f.Add(0);
                }

            }
            #endregion

            #region  //获取实用新型
            if (patenttype == 0 || patenttype == 2)
            {
                t_fm = table.Select(String.Format(sWhere, 2, year));
                count = 0;
                zzl = 0.0;
                for (int i = 0; i < t_fm.Length; i++)
                {
                    count += Int32.Parse(t_fm[i]["n_Count"].ToString());
                    zzl += Math.Round(Convert.ToDouble(t_fm[i]["ZZL"].ToString()), 4);
                }
                json.series[1].data.Add(count);
                json.series[1].data_f.Add(zzl);
                if (patenttype == 2)
                {
                    json.series[0].data.Add(0);
                    json.series[0].data_f.Add(0);
                    json.series[2].data.Add(0);
                    json.series[2].data_f.Add(0);
                }
            }
            #endregion

            #region //获取外观设计
            if (patenttype == 0 || patenttype == 3)
            {
                t_fm = table.Select(String.Format(sWhere, 3, year));
                count = 0;
                zzl = 0.0;
                for (int i = 0; i < t_fm.Length; i++)
                {
                    count += Int32.Parse(t_fm[i]["n_Count"].ToString());
                    zzl += Math.Round(Convert.ToDouble(t_fm[i]["ZZL"].ToString()), 4);
                }
                json.series[2].data.Add(count);
                json.series[2].data_f.Add(zzl);
                if (patenttype == 3)
                {
                    json.series[0].data.Add(0);
                    json.series[0].data_f.Add(0);
                    json.series[1].data.Add(0);
                    json.series[1].data_f.Add(0);
                }
            }
            #endregion

            #region //总和
            if (patenttype == 0 && isCount == true)
            {
                t_fm = table.Select(String.Format(sWhere, 0, year));
                count = 0;
                zzl = 0.0;
                for (int i = 0; i < t_fm.Length; i++)
                {
                    count += Int32.Parse(t_fm[i]["n_Count"].ToString());
                    zzl += Math.Round(Convert.ToDouble(t_fm[i]["ZZL"].ToString()), 4);
                }
                json.series[3].data.Add(count);
                json.series[3].data_f.Add(zzl);
            }
            #endregion
        }

        /// <summary>
        /// 数据来源：GDPAPatentChartBaseData
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private ChartJson getChartJsonData(CRBIHttpContextQuery context)
        {
            DataTable table = null;
            ChartJson json = new ChartJson();
            json.charttype = context.charttype;
            json.xAxis.Add(new xAxisItemJson() { categories = new List<string>() { }, crosshair = true });
            json.series.Add(new SeriesItemJson("发明"));
            json.series.Add(new SeriesItemJson("实用新型"));
            json.series.Add(new SeriesItemJson("外观设计"));
            json.series.Add(new SeriesItemJson("同比增长"));
            json.series.Add(new SeriesItemJson("同比增长"));
            json.series.Add(new SeriesItemJson("同比增长"));
            //GDPAPatentChartBaseDataQuery query = new GDPAPatentChartBaseDataQuery()
            //{
            //    n_PatentStatus = context.type,
            //    d_StartDate = context.startDate,
            //    d_EndDate = context.endDate
            //};
            if (context.isallyear == true)
            {
                //getChartJsonData_AllYear(query, json,out table);
            }
            else
            {
                // getChartJsonData_ThisYear(query, json, out table);
            }

            return json;
        }

        /// <summary>
        /// 广东省三种专利类型申请受理（/授权）状况图(年月)
        /// 数据来源：GDPAPatentChartBaseData
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private ChartJson getData_3Z_ZLLX_SQSL_ZKT(CRBIHttpContextQuery context)
        {
            ChartJson json = new ChartJson();
            json.charttype = context.charttype;
            json.xAxis.Add(new xAxisItemJson() { categories = new List<string>() { }, crosshair = true });
            json.series.Add(new SeriesItemJson("发明"));
            json.series.Add(new SeriesItemJson("实用新型"));
            json.series.Add(new SeriesItemJson("外观设计"));

            //GDPAPatentChartBaseDataQuery query = new GDPAPatentChartBaseDataQuery()
            CRBIHttpContextQuery query = new CRBIHttpContextQuery()
            {
                //n_PatentStatus = context.type,
                //d_StartDate = context.startDate,
                //d_EndDate = context.endDate
            };
            DataTable table = new DataTable();// GDPAPatentChartBaseDataAccessor.Instance().loadDataSZZLLXSQSLZKT(query);

            #region //获取发明数据
            var t_fm = table.Select(String.Format("(n_PatentType ={0})", 1));
            json.series[0].data.Add(t_fm.Length > 0 ? Int32.Parse(t_fm[0]["n_Count"].ToString()) : 0);
            #endregion

            #region  //获取实用新型
            t_fm = table.Select(String.Format("(n_PatentType ={0} )", 2));
            json.series[1].data.Add(t_fm.Length > 0 ? Int32.Parse(t_fm[0]["n_Count"].ToString()) : 0);
            #endregion

            #region //获取外观设计
            t_fm = table.Select(String.Format("(n_PatentType ={0} )", 3));
            json.series[2].data.Add(t_fm.Length > 0 ? Int32.Parse(t_fm[0]["n_Count"].ToString()) : 0);
            #endregion

            return json;
        }
        

        #endregion

    }


    public class CRBIHttpContextQuery
    {
        /// <summary>
        ///  查询时间标识：0：周，1：月，2：季度，3：半年，4：一年
        /// </summary>
        public int querydateflag = 0;

        /// <summary>
        /// 查询级别--1：区域级，2：站点级，3：设备级
        /// </summary>
        public int querylevel = 0;
        /// <summary>
        /// 城市
        /// </summary>
        public string citycodes = "";
        /// <summary>
        /// 省份
        /// </summary>
        public int provinceCode = 19;
        /// <summary>
        /// 
        /// </summary>
        public DateTime startDate;
        /// <summary>
        /// 
        /// </summary>
        public DateTime endDate;
        /// <summary>
        /// 图表类型
        /// </summary>
        public string charttype = "";
        /// <summary>
        /// 数据维度--m:当月，y:当年
        /// </summary>
        public string datatype = "y";
        /// <summary>
        /// 站点ID
        /// </summary>
        public int stationid = 1;
        /// <summary>
        /// 设备ID
        /// </summary>
        public int equirementid = 0;


        /// <summary>
        /// 是否历年数据
        /// </summary>
        public bool isallyear = false;
        
        /// <summary>
        /// 五种专利人类型
        /// </summary>
        //public int applicantertype = 0;
        /// <summary>
        /// 
        /// </summary>
        //public int patentdatatype;
        public CRBIHttpContextQuery(int _querylevel, int _stationid, string _citycodes, /*DateTime _startDate, DateTime _endDate,*/ string _datatype = "y", int _provinceCode = 19, string _charttype = "")
        {
            //startDate = _startDate;
            //endDate=_endDate;
            var date = DateTime.Now;
            //startDate = (datatype == "y") ? new DateTime(date.Year, 1, 1, 0, 0, 0) : new DateTime(date.Year, date.Month, 1, 0, 0, 0);
            //endDate = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);
            querylevel = _querylevel;
            stationid = _stationid;
            citycodes = _citycodes;
            provinceCode = _provinceCode;
            charttype = _charttype;
            equirementid = 0;
        }
        //*
        public CRBIHttpContextQuery(int _querylevel, int _stationid, string _citycodes, DateTime _startDate, DateTime _endDate, string _datatype = "y", int _provinceCode = 19, string _charttype = "", int _applysource = 2)
        {
            var date = DateTime.Now;
            datatype = _datatype;
            startDate = _startDate;
            endDate = _endDate;
            //startDate = (datatype == "y") ? new DateTime(date.Year, 1, 1, 0, 0, 0) : new DateTime(date.Year, date.Month, 1, 0, 0, 0);
            //endDate = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);
            querylevel = _querylevel;
            stationid = _stationid;
            citycodes = _citycodes;
            provinceCode = _provinceCode;
            charttype = _charttype;
            equirementid = _applysource;
        }
        /// <summary>
        /// 涉及到当年，当月数据查询用此函数 *
        /// </summary>
        /// <param name="_querylevel"></param>
        /// <param name="_stationid"></param>
        /// <param name="_isallyear"></param>
        /// <param name="_datatype"></param>
        /// <param name="_charttype"></param>
        public CRBIHttpContextQuery(int _querylevel, int _stationid, bool _isallyear, DateTime _startDate, DateTime _endDate, string _datatype = "y", string _charttype = "")
        {
            var date = DateTime.Now;
            querylevel = _querylevel;
            stationid = _stationid;
            charttype = _charttype;
            isallyear = _isallyear;
            datatype = _datatype;
            startDate = _startDate;
            endDate = _endDate;
            //startDate = (datatype == "y") ? new DateTime(date.Year, 1, 1, 0, 0, 0) : new DateTime(date.Year, date.Month, 1, 0, 0, 0);
            //endDate = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);
        }
        ///// <summary>
        ///// 五种专利人相关*
        ///// </summary>
        ///// <param name="_patenttype"></param>
        ///// <param name="_stationid"></param>
        ///// <param name="_isallyear"></param>
        ///// <param name="_datatype"></param>
        ///// <param name="_applicantertype"></param>
        ///// <param name="_charttype"></param>
        //public CRBIHttpContextQuery(int _querylevel, int _stationid, bool _isallyear, DateTime _startDate, DateTime _endDate, string _datatype = "y", string _charttype = "")
        //{
        //    var date = DateTime.Now;
        //    querylevel = _querylevel;
        //    stationid = _stationid;
        //    charttype = _charttype;
        //    isallyear = _isallyear;
        //    datatype = _datatype;
        //    startDate = _startDate;
        //    endDate = _endDate;
        //    //startDate = (datatype == "y") ? new DateTime(date.Year, 1, 1, 0, 0, 0) : new DateTime(date.Year, date.Month, 1, 0, 0, 0);
        //    //endDate = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);
        //}
        /// <summary>
        /// 全国 *
        /// </summary>
        /// <param name="_patenttype"></param>
        /// <param name="_type"></param>
        /// <param name="_citycodes"></param>
        /// <param name="_datatype"></param>
        /// <param name="_provinceCode"></param>
        /// <param name="_charttype"></param>
        /// <param name="_applysource"></param>
        public CRBIHttpContextQuery(int _querylevel, int _stationid, string _citycodes, DateTime _startDate, DateTime _endDate, string _datatype = "y", string _charttype = "")
        {
            var date = DateTime.Now;
            datatype = _datatype;
            startDate = _startDate;
            endDate = _endDate;
            //startDate = (datatype == "y") ? new DateTime(date.Year, 1, 1, 0, 0, 0) : new DateTime(date.Year, date.Month, 1, 0, 0, 0);
            //endDate = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);
            querylevel = _querylevel;
            stationid = _stationid;
            citycodes = _citycodes;
            charttype = _charttype;
        }
        /// <summary>
        /// 有效发明专用 *
        /// </summary>
        /// <param name="_patentdatatype"></param>
        /// <param name="_provinceCode"></param>
        /// <param name="_charttype"></param>
        public CRBIHttpContextQuery(int _stationid, int _provinceCode, DateTime _startDate, DateTime _endDate, string _datatype = "y", string _charttype = "")
        {
            stationid = _stationid;
            var date = DateTime.Now;
            charttype = _charttype;
            datatype = _datatype;
            startDate = _startDate;
            endDate = _endDate;
            //startDate = (datatype == "y") ? new DateTime(date.Year, 1, 1, 0, 0, 0) : new DateTime(date.Year, date.Month, 1, 0, 0, 0);
            //endDate = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);

        }
        public void setDateTime(DateTime _startdate, DateTime _enddate)
        {
            startDate = _startdate;
            endDate = _enddate;
        }
        public CRBIHttpContextQuery()
        {
        }

    }

}


using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using WebGD.BusinessRules.Report;
//using WebGD.DataAccessors.ApplyAndAuthorize;
//using WebGD.DataAccessors.SIPO;
//using WebGD.Entities;
//using WebGD.Entities.RequestDTO;

namespace CRBIReportLib.ReportBase
{
    class GDPAPatentChartBaseDataQuery { }
   public class CRBIReportProjectRule
   {
       #region 单例
       private static CRBIReportProjectRule _project;
        private CRBIReportProjectRule()
        { }
        public static CRBIReportProjectRule Intance()
        {
            if (_project == null)
                _project = new CRBIReportProjectRule();
            return _project;
        }
       #endregion

    

        ///// <summary>
        ///// 查询充电测试数据信息
        ///// </summary>
        ///// <param name="machineId"></param>
        ///// <param name="groupNo"></param>
        ///// <param name="start"></param>
        ///// <param name="end"></param>
        ///// <param name="testType"></param>
        ///// <returns></returns>
        //public DataTable GetChargeTestData(int machineId, int groupNo, DateTime start, DateTime end, int testType)//ChartJson GetChargeTestDataChartJsonData(HttpContextQuery context)//
        //{
        //    return CRBITBL_ChargeAccessor.Instance().GetChargeTestData(machineId, groupNo, start, end, testType);
        //}
        ///// <summary>
        ///// 查询内阻测试结论信息
        ///// </summary>
        ///// <param name="machineId"></param>
        ///// <param name="groupNo"></param>
        ///// <param name="start"></param>
        ///// <param name="end"></param>
        ///// <param name="testType"></param>
        ///// <returns></returns>
        //public DataTable GetResistanceTestResult(int machineId, int groupNo, DateTime start, DateTime end, int testType)
        //{
        //    return CRBITBL_ChargeAccessor.Instance().GetResistanceTestResult(machineId, groupNo, start, end, testType);
        //}
        ///// <summary>
        ///// 查询内阻测试数据信息
        ///// </summary>
        ///// <param name="machineId"></param>
        ///// <param name="groupNo"></param>
        ///// <param name="start"></param>
        ///// <param name="end"></param>
        ///// <param name="testType"></param>
        ///// <returns></returns>
        //public DataTable GetResistanceTestData(int machineId, int groupNo, DateTime start, DateTime end, int testType)
        //{
        //    return CRBITBL_ChargeAccessor.Instance().GetResistanceTestData(machineId, groupNo, start, end, testType);
        //}
        #region 广东省申请，授权数据
        /// <summary>
        /// 数据来源：GDPAPatentChartBaseData
        /// 历年
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private void getChartJsonData_AllYear(GDPAPatentChartBaseDataQuery query, ChartJson json,out DataTable table)
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
        private void getChartJsonData_ThisYear(GDPAPatentChartBaseDataQuery query, ChartJson json, out DataTable table)
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
        private void getSeriesDataByPatentType(int patenttype, ChartJson json, DataTable table, int year, string sWhere,bool isCount=false)
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
            if (patenttype == 0 && isCount==true)
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
        private ChartJson getChartJsonData(HttpContextQuery context)
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
        private ChartJson getData_3Z_ZLLX_SQSL_ZKT(HttpContextQuery context)
        {
            ChartJson json = new ChartJson();
            json.charttype = context.charttype;
            json.xAxis.Add(new xAxisItemJson() { categories = new List<string>() { }, crosshair = true });
            json.series.Add(new SeriesItemJson("发明"));
            json.series.Add(new SeriesItemJson("实用新型"));
            json.series.Add(new SeriesItemJson("外观设计"));

            GDPAPatentChartBaseDataQuery query = new GDPAPatentChartBaseDataQuery()
            {
                //n_PatentStatus = context.type,
                //d_StartDate = context.startDate,
                //d_EndDate = context.endDate
            };
            DataTable table = new DataTable ();// GDPAPatentChartBaseDataAccessor.Instance().loadDataSZZLLXSQSLZKT(query);

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
        /// <summary>
        /// 广东省历年专利申请受理（/授权）趋势图
        /// 数据来源：GDPAPatentChartBaseData
        /// </summary>
        /// <returns></returns>
        public ChartJson LoadDataZLSQSLQST_LN(HttpContextQuery context)
        {
            return getChartJsonData(context);
        }
        /// <summary>
        /// 广东省专利申请受理（/授权）趋势图
        /// 数据来源：GDPAPatentChartBaseData
        /// </summary>
        /// <returns></returns>
        public ChartJson LoadDataZLSQSLQST(HttpContextQuery context)
        {
            return getChartJsonData(context);
        }
        /// <summary>
        /// 广东省发明专利申请受理（/授权）趋势图
        /// 数据来源：GDPAPatentChartBaseData
        /// </summary>
        /// <returns></returns>
        public ChartJson LoadDataFMZLSQSLQST(HttpContextQuery context)
        {
            return getChartJsonData(context);
        }
        /// <summary>
        /// 广东省实用新型专利申请受理（/授权）趋势图
        /// 数据来源：GDPAPatentChartBaseData
        /// </summary>
        /// <returns></returns>
        public ChartJson LoadDataSYXXZLSQSLQST(HttpContextQuery context)
        {
            return getChartJsonData(context);
        }
        /// <summary>
        /// 广东省外观设计专利申请受理（/授权）趋势图
        /// 数据来源：GDPAPatentChartBaseData
        /// </summary>
        /// <returns></returns>
        public ChartJson LoadDataWGSJZLSQSLQST(HttpContextQuery context)
        {
            return getChartJsonData(context);
        }
        /// <summary>
        /// 广东省三种专利类型申请受理（/授权）状况图(年月)
        /// 数据来源：GDPAPatentChartBaseData
        /// </summary>
        /// <returns></returns>
        public ChartJson LoadDataSZZLLXSQSLZKT(HttpContextQuery context)
        {
            return getData_3Z_ZLLX_SQSL_ZKT(context);
        }
        
        #endregion

        #region  广东省五种类型申请人
        /// <summary>
        /// 数据来源：GDPAPatentChartBaseData
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private ChartJson getWZZLRLX_SQJsonData(HttpContextQuery context)
        {
            ChartJson json = new ChartJson();
            json.charttype = context.charttype;
            json.xAxis.Add(new xAxisItemJson() { categories = new List<string>() { }, crosshair = true });
            json.series.Add(new SeriesItemJson("大专院校"));
            json.series.Add(new SeriesItemJson("科研机构"));
            json.series.Add(new SeriesItemJson("企业"));
            json.series.Add(new SeriesItemJson("机关团体"));
            json.series.Add(new SeriesItemJson("个人"));

            //GDPAPatentChartBaseDataQuery query = new GDPAPatentChartBaseDataQuery()
            //{
            //    n_PatentStatus = context.type,
            //    d_StartDate = context.startDate,
            //    d_EndDate = context.endDate,
            //    n_PatentType = context.patenttype
            //};

            DataTable table = null;
            //table = (context.patenttype == 0) ? GDPAPatentChartBaseDataAccessor.Instance().loadDataWZLXSQRZLSQSLT(query) :
            //                      GDPAPatentChartBaseDataAccessor.Instance().loadDataXXXLX_ZLSQRLXZKT(query);

            //申请人类型：1：大专院校，2：科研机构，3：企业，4：机关团体，5：个人
            StringBuilder categories = new StringBuilder("[");
            #region //获取大专院校
            var t_fm = table.Select(String.Format("(n_ApplicanterType ={0})", 1));
            json.series[0].data.Add(t_fm.Length > 0 ? Int32.Parse(t_fm[0]["n_Count"].ToString()) : 0);
            #endregion

            #region  //获取科研机构
            t_fm = table.Select(String.Format("(n_ApplicanterType ={0} )", 2));
            json.series[1].data.Add(t_fm.Length > 0 ? Int32.Parse(t_fm[0]["n_Count"].ToString()) : 0);
            #endregion

            #region //获取企业
            t_fm = table.Select(String.Format("(n_ApplicanterType ={0} )", 3));
            json.series[2].data.Add(t_fm.Length > 0 ? Int32.Parse(t_fm[0]["n_Count"].ToString()) : 0);
            #endregion

            #region //获取机关团体
            t_fm = table.Select(String.Format("(n_ApplicanterType ={0} )", 4));
            json.series[3].data.Add(t_fm.Length > 0 ? Int32.Parse(t_fm[0]["n_Count"].ToString()) : 0);
            #endregion

            #region //获取个人
            t_fm = table.Select(String.Format("(n_ApplicanterType ={0} )", 5));
            json.series[4].data.Add(t_fm.Length > 0 ? Int32.Parse(t_fm[0]["n_Count"].ToString()) : 0);
            #endregion

            return json;
        }
        /// <summary>
        /// 广东省五种类型申请人专利申请受理（/授权）状况图(年月)
        /// 数据来源：GDPAPatentChartBaseData
        /// 针对五种类型的申请人，算发明，实用新型，外观设计的申请数据总和
        /// 申请人类型：1：大专院校，2：科研机构，3：企业，4：机关团体，5：个人
        /// </summary>
        /// <returns></returns>
        public ChartJson LoadDataWZLXSQRZLSQSLT(HttpContextQuery context)
        {
            return getWZZLRLX_SQJsonData(context);
        }

        /// <summary>
        /// 广东省发明专利申请人（/授权专利权）类型状况图(年月)
        /// 数据来源：GDPAPatentChartBaseData
        /// 针对五种类型的申请人，算发明专利的申请数据
        /// </summary>
        /// <returns></returns>
        public ChartJson LoadDataXXXLX_ZLSQRLXZKT(HttpContextQuery context)
        {
            return getWZZLRLX_SQJsonData(context);
        }
        /// <summary>
        /// 广东省工矿企业(等五种专利人)专利申请受理（/授权）状况图(年月)
        /// 数据来源：GDPAPatentChartBaseData
        /// </summary>
        /// <returns></returns>
        public ChartJson LoadDataXXXLXSQR_SZZLSQZKT(HttpContextQuery context)
        {
            ChartJson json = new ChartJson();
            json.charttype = context.charttype;
            json.xAxis.Add(new xAxisItemJson() { categories = new List<string>() { }, crosshair = true });
            json.series.Add(new SeriesItemJson("发明"));
            json.series.Add(new SeriesItemJson("实用新型"));
            json.series.Add(new SeriesItemJson("外观设计"));
            //GDPAPatentChartBaseDataQuery query = new GDPAPatentChartBaseDataQuery()
            //{
            //    n_PatentStatus = context.type,
            //    d_StartDate = context.startDate,
            //    d_EndDate = context.endDate,
            //    n_ApplicanterType = context.applicantertype
            //};
            //DataTable table = GDPAPatentChartBaseDataAccessor.Instance().loadDataXXXLXSQR_SZZLSQZKT(query);

            //#region //获取发明数据
            //var t_fm = table.Select(String.Format("(n_PatentType ={0})", 1));
            //json.series[0].data.Add(t_fm.Length > 0 ? Int32.Parse(t_fm[0]["n_Count"].ToString()) : 0);
            //#endregion

            //#region  //获取实用新型
            //t_fm = table.Select(String.Format("(n_PatentType ={0} )", 2));
            //json.series[1].data.Add(t_fm.Length > 0 ? Int32.Parse(t_fm[0]["n_Count"].ToString()) : 0);
            //#endregion

            //#region //获取外观设计
            //t_fm = table.Select(String.Format("(n_PatentType ={0} )", 3));
            //json.series[2].data.Add(t_fm.Length > 0 ? Int32.Parse(t_fm[0]["n_Count"].ToString()) : 0);
            //#endregion

            return json;

        }
        /// <summary>
        /// 广东省各区域专利申请受理（/授权）状况图(年月)
        /// 数据来源：GDPAPatentChartBaseData
        /// </summary>
        /// <returns></returns>
        public ChartJson LoadDataGQY_ZLSQ_SQZKT(HttpContextQuery context)
        {
            ChartJson json = new ChartJson();
            json.charttype = context.charttype;
            json.xAxis.Add(new xAxisItemJson() { categories = new List<string>() { "发明", "实用新型", "外观设计" }, crosshair = true });
            json.series.Add(new SeriesItemJson("珠三角"));
            json.series.Add(new SeriesItemJson("东翼"));
            json.series.Add(new SeriesItemJson("西翼"));
            json.series.Add(new SeriesItemJson("山区"));
            //GDPAPatentChartBaseDataQuery query = new GDPAPatentChartBaseDataQuery()
            //{
            //    n_PatentStatus = context.type,
            //    d_StartDate = context.startDate,
            //    d_EndDate = context.endDate
            //};
            //DataTable table = GDPAPatentChartBaseDataAccessor.Instance().loadDataGQY_ZLSQ_SQZKT(query);

            //for (var i = 1; i < 4; i++)
            //{
            //    var t_fm = table.Select(String.Format("(n_AreaType ={0}) AND (n_PatentType ={1} )", 1, i));
            //    json.series[0].data.Add(t_fm.Length > 0 ? Int32.Parse(t_fm[0]["n_Count"].ToString()) : 0);

            //    t_fm = table.Select(String.Format("(n_AreaType ={0}) AND (n_PatentType ={1} )", 2, i));
            //    json.series[1].data.Add(t_fm.Length > 0 ? Int32.Parse(t_fm[0]["n_Count"].ToString()) : 0);

            //    t_fm = table.Select(String.Format("(n_AreaType ={0}) AND (n_PatentType ={1} )", 3, i));
            //    json.series[2].data.Add(t_fm.Length > 0 ? Int32.Parse(t_fm[0]["n_Count"].ToString()) : 0);

            //    t_fm = table.Select(String.Format("(n_AreaType ={0}) AND (n_PatentType ={1} )", 4, i));
            //    json.series[3].data.Add(t_fm.Length > 0 ? Int32.Parse(t_fm[0]["n_Count"].ToString()) : 0);
            //}
            return json;
        }

        #endregion

        #region 全国数据
        /// <summary>
        /// 全国专利申请受理（/授权）趋势图
        /// 数据来源：T_SIPOData
        /// </summary>
        /// <param name="context"></param>
        public ChartJson LoadDataZLSQSLQST_CN(HttpContextQuery context)
        {
            return getChartData_CN(context);
        }
        /// <summary>
        /// 全国发明专利申请受理（/授权）趋势图
        /// 数据来源：T_SIPOData
        /// </summary>
        /// <param name="context"></param>
        public ChartJson LoadDataFMZLSQSLQST_CN(HttpContextQuery context)
        {
            return getChartData_CN(context);
        }
        /// <summary>
        /// 全国实用新型专利申请受理（/授权）趋势图
        /// 数据来源：T_SIPOData
        /// </summary>
        /// <param name="context"></param>
        public ChartJson LoadDataSYXXZLSQSLQST_CN(HttpContextQuery context)
        {
            return getChartData_CN(context);
        }
        /// <summary>
        /// 全国外观设计专利申请受理（/授权）趋势图
        /// 数据来源：T_SIPOData
        /// </summary>
        /// <param name="context"></param>
        public ChartJson LoadDataWGSJZLSQSLQST_CN(HttpContextQuery context)
        {
            return getChartData_CN(context);
        }

        /// <summary>
        /// 全国专利申请受理（授权）量图示
        /// 数据来源：T_SIPOData
        /// </summary>
        /// <param name="context"></param>
        public ChartJson LoadDataZLSQSL_TS_CN(HttpContextQuery context)
        {
            ChartJson json = new ChartJson();
            json.charttype = context.charttype;
            json.xAxis.Add(new xAxisItemJson() { categories = new List<string>() { "合计", "发明", "实用新型", "外观设计" }, crosshair = true });
            json.series.Add(new SeriesItemJson("合计"));
            json.series.Add(new SeriesItemJson("国内"));
            json.series.Add(new SeriesItemJson("国外"));

            json.series.Add(new SeriesItemJson("合计增长率"));
            json.series.Add(new SeriesItemJson("国内增长率"));
            json.series.Add(new SeriesItemJson("国外增长率"));

            ////ProviceCatch.instance().LoadData();
            //GDPAPatentChartApplicanterTypeDataQuery query = new GDPAPatentChartApplicanterTypeDataQuery()
            //{
            //    n_PatentStatus = context.type,
            //    d_StartYear = context.startDate.Year,
            //    d_EndYear = context.endDate.Year,
            //    d_StartMonth = context.startDate.Month,
            //    d_EndMonth = context.endDate.Month
            //};
            //var _3zzllx_0 = 0;
            //var _3zzllx_1 = 0;
            //var _3zzllx_2 = 0;
            //var _3zzllx_3 = 0;

            //var _3zzllx_zzl_0 = 0.0;
            //var _3zzllx_zzl_1 = 0.0;
            //var _3zzllx_zzl_2 = 0.0;
            //var _3zzllx_zzl_3 = 0.0;
            //DataTable table = GDPAPatentChartApplicanterTypeDataAccessor.Instance().loadDataZLSQSL_TS_CN(query,4,"合计");
            //DataRow[] t_fm = null;
            //List<string> list = new List<string>() { "合计","国内","国外"};

            
            //for (int i = 0; i < list.Count(); i++)//0：合计；1：国内；2：国外
            //{
            //    t_fm = table.Select(String.Format("(ISO_CN ={0})", i));
            //    _3zzllx_0 = 0;
            //    _3zzllx_1 = 0;
            //    _3zzllx_2 = 0;
            //    _3zzllx_3 = 0;

            //    _3zzllx_zzl_0 = 0.0;
            //    _3zzllx_zzl_1 = 0.0;
            //    _3zzllx_zzl_2 = 0.0;
            //    _3zzllx_zzl_3 = 0.0;
            //    for (int j = 0; j < t_fm.Length; j++)
            //    {
            //        //_3zzllx_0 += Int32.Parse(t_fm[j]["n_CurYearCount"].ToString());
            //        _3zzllx_1 += Int32.Parse(t_fm[j]["n_PCount"].ToString());
            //        _3zzllx_2 += Int32.Parse(t_fm[j]["n_UCount"].ToString());
            //        _3zzllx_3 += Int32.Parse(t_fm[j]["n_DCount"].ToString());

            //        //_3zzllx_zzl_0 += Int32.Parse(t_fm[j]["n_YearCountZZL"].ToString());
            //        _3zzllx_zzl_1 += Double.Parse(t_fm[j]["n_PCountZZL"].ToString());
            //        _3zzllx_zzl_2 += Double.Parse(t_fm[j]["n_UCountZZL"].ToString());
            //        _3zzllx_zzl_3 += Double.Parse(t_fm[j]["n_DCountZZL"].ToString());

                        
            //    }
            //    _3zzllx_0 = _3zzllx_1 + _3zzllx_2 + _3zzllx_3;
            //    _3zzllx_zzl_0 = (_3zzllx_zzl_1 + _3zzllx_zzl_2 + _3zzllx_zzl_3)/3;
            //    json.series[i].data.Add(_3zzllx_0);
            //    json.series[i].data_f.Add(_3zzllx_zzl_0);
            //    json.series[i].data.Add(_3zzllx_1);
            //    json.series[i].data_f.Add(_3zzllx_zzl_1);
            //    json.series[i].data.Add(_3zzllx_2);
            //    json.series[i].data_f.Add(_3zzllx_zzl_2);
            //    json.series[i].data.Add(_3zzllx_3);
            //    json.series[i].data_f.Add(_3zzllx_zzl_3);
                   
            //}
           
            return json;
        }

        /// <summary>
        /// 全国专利申请受理（授权）量图示
        /// 数据来源：T_SIPOData
        /// </summary>
        /// <param name="context"></param>
        public ChartJson LoadDataZLSQSL_TS_CN_NoRate(HttpContextQuery context)
        {
            ChartJson json = new ChartJson();
            json.charttype = context.charttype;
            json.xAxis.Add(new xAxisItemJson() { categories = new List<string>() { "合计", "发明", "实用新型", "外观设计" }, crosshair = true });
            json.series.Add(new SeriesItemJson("合计"));
            json.series.Add(new SeriesItemJson("国内"));
            json.series.Add(new SeriesItemJson("国外"));

            //json.series.Add(new SeriesItemJson("合计增长率"));
            //json.series.Add(new SeriesItemJson("国内增长率"));
            //json.series.Add(new SeriesItemJson("国外增长率"));

            ////ProviceCatch.instance().LoadData();
            //GDPAPatentChartApplicanterTypeDataQuery query = new GDPAPatentChartApplicanterTypeDataQuery()
            //{
            //    n_PatentStatus = context.type,
            //    d_StartYear = context.startDate.Year,
            //    d_EndYear = context.endDate.Year,
            //    d_StartMonth = context.startDate.Month,
            //    d_EndMonth = context.endDate.Month
            //};
            //var _3zzllx_0 = 0;
            //var _3zzllx_1 = 0;
            //var _3zzllx_2 = 0;
            //var _3zzllx_3 = 0;

            //var _3zzllx_zzl_0 = 0.0;
            //var _3zzllx_zzl_1 = 0.0;
            //var _3zzllx_zzl_2 = 0.0;
            //var _3zzllx_zzl_3 = 0.0;
            //DataTable table = GDPAPatentChartApplicanterTypeDataAccessor.Instance().loadDataZLSQSL_TS_CN(query, 4, "合计");
            //DataRow[] t_fm = null;
            //List<string> list = new List<string>() { "合计", "国内", "国外" };


            //for (int i = 0; i < list.Count(); i++)//0：合计；1：国内；2：国外
            //{
            //    t_fm = table.Select(String.Format("(ISO_CN ={0})", i));
            //    _3zzllx_0 = 0;
            //    _3zzllx_1 = 0;
            //    _3zzllx_2 = 0;
            //    _3zzllx_3 = 0;

            //    _3zzllx_zzl_0 = 0.0;
            //    _3zzllx_zzl_1 = 0.0;
            //    _3zzllx_zzl_2 = 0.0;
            //    _3zzllx_zzl_3 = 0.0;
            //    for (int j = 0; j < t_fm.Length; j++)
            //    {
            //        //_3zzllx_0 += Int32.Parse(t_fm[j]["n_CurYearCount"].ToString());
            //        _3zzllx_1 += Int32.Parse(t_fm[j]["n_PCount"].ToString());
            //        _3zzllx_2 += Int32.Parse(t_fm[j]["n_UCount"].ToString());
            //        _3zzllx_3 += Int32.Parse(t_fm[j]["n_DCount"].ToString());

            //        //_3zzllx_zzl_0 += Int32.Parse(t_fm[j]["n_YearCountZZL"].ToString());
            //        //_3zzllx_zzl_1 += Double.Parse(t_fm[j]["n_PCountZZL"].ToString());
            //        //_3zzllx_zzl_2 += Double.Parse(t_fm[j]["n_UCountZZL"].ToString());
            //        //_3zzllx_zzl_3 += Double.Parse(t_fm[j]["n_DCountZZL"].ToString());


            //    }
            //    _3zzllx_0 = _3zzllx_1 + _3zzllx_2 + _3zzllx_3;
            //    _3zzllx_zzl_0 = (_3zzllx_zzl_1 + _3zzllx_zzl_2 + _3zzllx_zzl_3) / 3;
            //    json.series[i].data.Add(_3zzllx_0);
            //    json.series[i].data_f.Add(_3zzllx_zzl_0);
            //    json.series[i].data.Add(_3zzllx_1);
            //    json.series[i].data_f.Add(_3zzllx_zzl_1);
            //    json.series[i].data.Add(_3zzllx_2);
            //    json.series[i].data_f.Add(_3zzllx_zzl_2);
            //    json.series[i].data.Add(_3zzllx_3);
            //    json.series[i].data_f.Add(_3zzllx_zzl_3);

            //}

            return json;
        }
         /// <summary>
        /// 全国三种专利类型申请受理（/授权）状况图(年月)--饼状图暂未用
        /// 数据来源：T_SIPOData
        /// </summary>
        /// <param name="context"></param>
        public ChartJson LoadDataSZZLLXSQSLZKT_CN(HttpContextQuery context)
        {
            ChartJson json = new ChartJson();
            json.charttype = context.charttype;
            json.xAxis.Add(new xAxisItemJson() { categories = new List<string>() { }, crosshair = true });
            json.series.Add(new SeriesItemJson("发明"));
            json.series.Add(new SeriesItemJson("实用新型"));
            json.series.Add(new SeriesItemJson("外观设计"));

            //GDPAPatentChartApplicanterTypeDataQuery query = new GDPAPatentChartApplicanterTypeDataQuery()
            //{
            //    n_PatentStatus = context.type,
            //    d_StartYear = context.startDate.Year,
            //    d_EndYear = context.endDate.Year,
            //    d_StartMonth = context.startDate.Month,
            //    d_EndMonth = context.endDate.Month
            //};

            //var _3zzllx_0 = 0;
            //var _3zzllx_1 = 0;
            //var _3zzllx_2 = 0;
            //var _3zzllx_3 = 0;

            //DataTable table = GDPAPatentChartApplicanterTypeDataAccessor.Instance().loadDataSZZLLXSQSLZKT_CN(query);
            //DataRow[] t_fm = null;

            //t_fm = table.Select("");
            //_3zzllx_0 = 0;
            //_3zzllx_1 = 0;
            //_3zzllx_2 = 0;
            //_3zzllx_3 = 0;
            //for (int j = 0; j < t_fm.Length; j++)
            //{
            //    _3zzllx_0 += Int32.Parse(t_fm[j]["n_CurYearCount"].ToString());
            //    _3zzllx_1 += Int32.Parse(t_fm[j]["n_PCount"].ToString());
            //    _3zzllx_2 += Int32.Parse(t_fm[j]["n_UCount"].ToString());
            //    _3zzllx_3 += Int32.Parse(t_fm[j]["n_DCount"].ToString());

            //}
            //json.series[0].data.Add(_3zzllx_1);
            //json.series[1].data.Add(_3zzllx_2);
            //json.series[2].data.Add(_3zzllx_3);
            return json;

        }
        /// <summary>
        /// 数据来源：T_SIPOData
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private ChartJson getChartData_CN1(HttpContextQuery context)
        {
            ChartJson json = new ChartJson();
            json.charttype = context.charttype;
            json.xAxis.Add(new xAxisItemJson() { categories = new List<string>() { }, crosshair = true });
            json.series.Add(new SeriesItemJson("发明"));
            json.series.Add(new SeriesItemJson("实用新型"));
            json.series.Add(new SeriesItemJson("外观设计"));
            json.series.Add(new SeriesItemJson("发明增长率"));
            json.series.Add(new SeriesItemJson("实用新型增长率"));
            json.series.Add(new SeriesItemJson("外观设计增长率"));
            //GDPAPatentChartApplicanterTypeDataQuery query = new GDPAPatentChartApplicanterTypeDataQuery()
            //{
            //    n_PatentStatus = context.type,
            //    d_StartYear = context.startDate.Year,
            //    d_EndYear = context.endDate.Year,
            //    d_StartMonth = context.startDate.Month,
            //    d_EndMonth = context.endDate.Month
            //};
            //DataTable table = GDPAPatentChartApplicanterTypeDataAccessor.Instance().loadDataZLSQSLQST_Y_CN(query);

            //DataRow[] t_fm = null;
            
            ////var _3zzllx_0 = 0;
            //var _3zzllx_1 = 0;
            //var _3zzllx_2 = 0;
            //var _3zzllx_3 = 0;

            ////var _3zzllx_zzl_0 = 0.0;
            //var _3zzllx_zzl_1 = 0.0;
            //var _3zzllx_zzl_2 = 0.0;
            //var _3zzllx_zzl_3 = 0.0;
           
            //for (int i = context.startDate.Month; i <= context.endDate.Month; i++)
            //{
            //    string month = (i < 10) ? string.Format("0{0}月", i) : string.Format("{0}月", i);
            //    json.xAxis[0].categories.Add(month);
            //    t_fm = table.Select(String.Format("(d_Month={0})", i));
            //    //_3zzllx_0 = 0;
            //    _3zzllx_1 = 0;
            //    _3zzllx_2 = 0;
            //    _3zzllx_3 = 0;

            //    //_3zzllx_zzl_0 = 0.0;
            //    _3zzllx_zzl_1 = 0.0;
            //    _3zzllx_zzl_2 = 0.0;
            //    _3zzllx_zzl_3 = 0.0;
            //    for (int j = 0; j < t_fm.Length; j++)
            //    {
            //        //_3zzllx_0 += Int32.Parse(t_fm[j]["n_CurMonthCount"].ToString());
            //        _3zzllx_1 += Int32.Parse(t_fm[j]["n_PCount"].ToString());
            //        _3zzllx_2 += Int32.Parse(t_fm[j]["n_UCount"].ToString());
            //        _3zzllx_3 += Int32.Parse(t_fm[j]["n_DCount"].ToString());

            //        //_3zzllx_zzl_0 += Int32.Parse(t_fm[j]["n_CurMonthCount"].ToString());
            //        _3zzllx_zzl_1 += Double.Parse(t_fm[j]["n_PCountZZL"].ToString());
            //        _3zzllx_zzl_2 += Double.Parse(t_fm[j]["n_UCountZZL"].ToString());
            //        _3zzllx_zzl_3 += Double.Parse(t_fm[j]["n_DCountZZL"].ToString());
            //    }
            //    json.series[0].data.Add(_3zzllx_1);
            //    json.series[0].data_f.Add(_3zzllx_zzl_1);
            //    json.series[1].data.Add(_3zzllx_2);
            //    json.series[1].data_f.Add(_3zzllx_zzl_2);
            //    json.series[2].data.Add(_3zzllx_3);
            //    json.series[2].data_f.Add(_3zzllx_zzl_3);

            //}

            return json;
        }
        /// <summary>
        /// 数据来源：T_SIPOData
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private ChartJson getChartData_CN(HttpContextQuery context)
        {
            ChartJson json = new ChartJson();
            json.charttype = context.charttype;
            json.xAxis.Add(new xAxisItemJson() { categories = new List<string>() { }, crosshair = true });
            json.series.Add(new SeriesItemJson("发明"));
            json.series.Add(new SeriesItemJson("实用新型"));
            json.series.Add(new SeriesItemJson("外观设计"));
            json.series.Add(new SeriesItemJson("发明增长率"));
            json.series.Add(new SeriesItemJson("实用新型增长率"));
            json.series.Add(new SeriesItemJson("外观设计增长率"));
            //GDPAPatentChartApplicanterTypeDataQuery query = new GDPAPatentChartApplicanterTypeDataQuery()
            //{
            //    n_PatentStatus = context.type,
            //    d_StartYear = context.startDate.Year,
            //    d_EndYear = context.endDate.Year,
            //    d_StartMonth = context.startDate.Month,
            //    d_EndMonth = context.endDate.Month
            //};
            //DataTable table = GDPAPatentChartApplicanterTypeDataAccessor.Instance().loadDataZLSQSLQST_Y_CN(query);

            //DataRow[] t_fm = null;

            ////var _3zzllx_0 = 0;
            //var _3zzllx_1 = 0;
            //var _3zzllx_2 = 0;
            //var _3zzllx_3 = 0;

            ////var _3zzllx_zzl_0 = 0.0;
            //var _3zzllx_zzl_1 = 0.0;
            //var _3zzllx_zzl_2 = 0.0;
            //var _3zzllx_zzl_3 = 0.0;

            //for (int i = context.startDate.Month; i <= context.endDate.Month; i++)
            //{
            //    string month = (i < 10) ? string.Format("0{0}月", i) : string.Format("{0}月", i);
            //    json.xAxis[0].categories.Add(month);
            //    t_fm = table.Select(String.Format("(d_Month={0})", i));
            //    //_3zzllx_0 = 0;
            //    _3zzllx_1 = 0;
            //    _3zzllx_2 = 0;
            //    _3zzllx_3 = 0;

            //    //_3zzllx_zzl_0 = 0.0;
            //    _3zzllx_zzl_1 = 0.0;
            //    _3zzllx_zzl_2 = 0.0;
            //    _3zzllx_zzl_3 = 0.0;
            //    for (int j = 0; j < t_fm.Length; j++)
            //    {
            //        //_3zzllx_0 += Int32.Parse(t_fm[j]["n_CurMonthCount"].ToString());
            //        _3zzllx_1 += Int32.Parse(t_fm[j]["n_PCount"].ToString());
            //        _3zzllx_2 += Int32.Parse(t_fm[j]["n_UCount"].ToString());
            //        _3zzllx_3 += Int32.Parse(t_fm[j]["n_DCount"].ToString());

            //        //_3zzllx_zzl_0 += Int32.Parse(t_fm[j]["n_CurMonthCount"].ToString());
            //        _3zzllx_zzl_1 += Double.Parse(t_fm[j]["n_PCountZZL"].ToString());
            //        _3zzllx_zzl_2 += Double.Parse(t_fm[j]["n_UCountZZL"].ToString());
            //        _3zzllx_zzl_3 += Double.Parse(t_fm[j]["n_DCountZZL"].ToString());
            //    }
            //    json.series[0].data.Add(_3zzllx_1);
            //    json.series[0].data_f.Add(_3zzllx_zzl_1);
            //    json.series[1].data.Add(_3zzllx_2);
            //    json.series[1].data_f.Add(_3zzllx_zzl_2);
            //    json.series[2].data.Add(_3zzllx_3);
            //    json.series[2].data_f.Add(_3zzllx_zzl_3);

            //}

            return json;
        }

        /// <summary>
        /// 全国部分省市专利申请受理(授权)中三种类型专利比例图
        /// 数据来源：T_SIPOData
        /// </summary>
        /// <param name="context"></param>
        public ChartJson LoadDataCity_SZZLLXSQ_BLT_CN(HttpContextQuery context)
        {
            ChartJson json = new ChartJson();
            json.charttype = context.charttype;
            json.xAxis.Add(new xAxisItemJson() { categories = new List<string>() { }, crosshair = true });
            json.series.Add(new SeriesItemJson("发明"));
            json.series.Add(new SeriesItemJson("实用新型"));
            json.series.Add(new SeriesItemJson("外观设计"));
            //json.series.Add(new SeriesItemJson("全国"));

            //ProviceCatch.instance().LoadData();
            //GDPAPatentChartApplicanterTypeDataQuery query = new GDPAPatentChartApplicanterTypeDataQuery()
            //{
            //    //s_CityCodes = context.citycodes
            //    n_PatentStatus = context.type,
            //    d_StartYear = context.startDate.Year,
            //    d_EndYear = context.endDate.Year,
            //    d_StartMonth = context.startDate.Month,
            //    d_EndMonth = context.endDate.Month
            //};

            //List<string> cityList = null;
            //string[] cityArr = context.citycodes.Split(',');
            //if (cityArr.Length > 0 && cityArr[0].Length > 1)
            //{
            //    cityList = new List<string>() { };
            //    cityList.AddRange(cityArr);
            //}
            //else
            //{
            //    cityList = new List<string>() { "北京","上海","广东","浙江","江苏" };
            //}
            //cityList.Add("合计");
            //string citycodes=context.citycodes.Length>0? context.citycodes:"'北京','上海','广东','浙江','江苏'";
            //string cityWhere = string.Format("{0},'合计' ", citycodes);
            //DataTable table = GDPAPatentChartApplicanterTypeDataAccessor.Instance().loadDataCity_SZZLLXSQ_BLT_CN(query, cityList,cityWhere);
            //DataRow[] t_fm = null;
            //var _3zzllx_0 = 0;
            //var _3zzllx_1 = 0;
            //var _3zzllx_2 = 0;
            //var _3zzllx_3 = 0;

            //for (int i = 0; i < cityList.Count();i++ )
            //{
            //    json.xAxis[0].categories.Add(cityList[i].Equals("合计") ? "全国" : (cityList[i] != null ? cityList[i] : "--"));
            //    _3zzllx_0 = 0;
            //    _3zzllx_1 = 0;
            //    _3zzllx_2 = 0;
            //    _3zzllx_3 = 0;                      
            //    t_fm = table.Select(String.Format("(s_AreaCN ='{0}') ",cityList[i]));
            //    for (int j = 0; j < t_fm.Length; j++)
            //    {
            //        _3zzllx_0 += Int32.Parse(t_fm[j]["n_CurMonthCount"].ToString());
            //        _3zzllx_1 += Int32.Parse(t_fm[j]["n_PCount"].ToString());
            //        _3zzllx_2 += Int32.Parse(t_fm[j]["n_UCount"].ToString());
            //        _3zzllx_3 += Int32.Parse(t_fm[j]["n_DCount"].ToString());
            //    }
            //    json.series[0].data.Add(_3zzllx_1);
            //    json.series[1].data.Add(_3zzllx_2);
            //    json.series[2].data.Add(_3zzllx_3);
            //    //json.series[3].data.Add(_3zzllx_0);
            //}
                return json;
        }

        
        #endregion

        #region  广东有效发明
        /// <summary>
        /// 历年有效发明状况---??????
        /// 数据来源：GDPAPatentChartApplicanterTypeData
        /// </summary>
        /// <param name="context"></param>
        public ChartJson LoadDataYXFM_LN_ZKT(HttpContextQuery context)
        {
            ChartJson json = new ChartJson();
            json.charttype = context.charttype;
            json.xAxis.Add(new xAxisItemJson() { categories = new List<string>() { }, crosshair = true });
            json.series.Add(new SeriesItemJson("有效发明"));
            //GDPAPatentChartApplicanterTypeDataQuery query = new GDPAPatentChartApplicanterTypeDataQuery()
            //{
            //    n_PatentStatus = context.type,
            //    n_ProvinceCode = context.provinceCode,
            //    n_DataType = context.patentdatatype,
            //    d_StartYear = context.startDate.Year,
            //    d_EndYear = context.endDate.Year,
            //    d_StartMonth = context.startDate.Month,
            //    d_EndMonth = context.endDate.Month
            //};
            
            return json;
        }
        /// <summary>
        /// 有效发明申请人类型比例图
        /// 广东省五种类型申请人有效发明专利申请状况图示
        /// 数据来源：GDPAPatentChartApplicanterTypeData
        /// 自定义类型:1:申请，3：授权，2:有效发明，4：PCT，5：电子申请
        /// </summary>
        /// <param name="context"></param>
        public ChartJson LoadDataYXFM_ZLRLXZKT(HttpContextQuery context)
        {
            //自定义类型:1:申请，3：授权，2:有效发明，4：PCT，5：电子申请
            //var patentdatatype = 2;
            ChartJson json = new ChartJson();
            json.charttype = context.charttype;
            json.xAxis.Add(new xAxisItemJson() { categories = new List<string>() { }, crosshair = true });
            json.series.Add(new SeriesItemJson("大专院校"));
            json.series.Add(new SeriesItemJson("科研机构"));
            json.series.Add(new SeriesItemJson("企业"));
            json.series.Add(new SeriesItemJson("机关团体"));
            json.series.Add(new SeriesItemJson("个人"));
            //GDPAPatentChartApplicanterTypeDataQuery query = new GDPAPatentChartApplicanterTypeDataQuery()
            //{
            //    n_ProvinceCode = context.provinceCode,
            //    n_DataType = context.patentdatatype,
            //    d_StartYear = context.startDate.Year,
            //    d_EndYear = context.endDate.Year,
            //    d_StartMonth = context.startDate.Month,
            //    d_EndMonth = context.endDate.Month
            //   , n_PatentStatus=4
            //};
            ////DataTable table = GDPAPatentChartApplicanterTypeDataAccessor.Instance().loadDataYXFM_ZLRLXZKT(query);
            //DataTable table = GDPAPatentChartApplicanterTypeDataAccessor.Instance().loadEffectivePatentNumOverApplitantType(context.endDate);
            ////申请人类型：1：大专院校，2：科研机构，3：企业，4：机关团体，5：个人
            //StringBuilder categories = new StringBuilder("[");
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
        /// 有效发明维持年限
        /// 数据来源：GDPAPatentChartApplicanterTypeData
        /// </summary>
        /// <param name="context"></param>
        public ChartJson LoadDataYXFM_WCNXZKT(HttpContextQuery context)
        {
            ChartJson json = new ChartJson();
            json.charttype = context.charttype;
            json.xAxis.Add(new xAxisItemJson() { categories = new List<string>() { }, crosshair = true });
            json.series.Add(new SeriesItemJson("有效发明"));
            //GDPAPatentChartApplicanterTypeDataQuery query = new GDPAPatentChartApplicanterTypeDataQuery()
            //{
            //    n_PatentStatus = context.type,
            //    n_ProvinceCode = context.provinceCode,
            //    n_DataType = context.patentdatatype,
            //    d_StartYear = context.startDate.Year,
            //    d_EndYear = context.endDate.Year,
            //    d_StartMonth = context.startDate.Month,
            //    d_EndMonth = context.endDate.Month
            //};
            //DataTable table = GDPAPatentChartApplicanterTypeDataAccessor.Instance().loadEffectivePatentLife(context.endDate);
            //var count = 0;

            //foreach (DataRow row in table.Rows)
            //{
            //    json.xAxis[0].categories.Add(string.Format("{0}年", row["Col1"].ToString()));
            //    Int32.TryParse(row["Num"].ToString(),out count);
            //    json.series[0].data.Add(count);
            //}
            return json;
        }
        #endregion

        #region 广东省PCT
        /// <summary>
        /// 广东省PCT国际专利申请区域状况图
        /// 数据来源： GDPAPatentChartApplyTypeData
        /// 自定义类型:1:申请，3：授权，2:有效发明，4：PCT，5：电子申请
        /// </summary>
        /// <param name="context"></param>
        public ChartJson LoadDataPCT_GJZL_SQQY_ZKT(HttpContextQuery context)
        {
            ChartJson json = new ChartJson();
            json.charttype = context.charttype;
            json.xAxis.Add(new xAxisItemJson() { categories = new List<string>() { }, crosshair = true });
            json.series.Add(new SeriesItemJson("珠三角"));
            json.series.Add(new SeriesItemJson("东翼"));
            json.series.Add(new SeriesItemJson("西翼"));
            json.series.Add(new SeriesItemJson("山区"));
            //GDPAPatentChartApplyDataQuery query = new GDPAPatentChartApplyDataQuery()
            //{
            //    s_CityCodes = context.citycodes,
            //    n_PatentStatus = context.type,
            //    d_StartYear = context.startDate.Year,
            //    d_EndYear = context.endDate.Year,
            //    d_StartMonth = context.startDate.Month,
            //    d_EndMonth = context.endDate.Month,
            //    n_ProvinceCode = context.provinceCode,
            //    n_ApplySource = 1

            //};
            //DataTable table = GDPAPatentChartApplyDataAccessor.Instance().loadDataPCT_GJZL_SQQY_ZKT(query);

            //var count = table.Rows.Count;
            ////todo:
            //for (var i = 1; i <= 4; i++)
            //{
            //    var t_fm = table.Select(String.Format("(n_AreaType ={0})", i));
            //    json.series[i - 1].data.Add(t_fm.Length > 0 ? Int32.Parse(t_fm[0]["n_Count"].ToString()) : 0);
            //}
            return json;
        }
        #endregion

        #region 广东省IPC分类
        /// <summary>
        /// 广东省专利申请受理IPC分类情况图--缺失？？？
        /// 数据来源： GDPAPatentChartApplyTypeData
        /// </summary>
        /// <param name="context"></param>
        public ChartJson LoadDataZLSQ_IPCFLZKT(HttpContextQuery context)
        {
            ChartJson json = new ChartJson();
            json.charttype = context.charttype;
            json.xAxis.Add(new xAxisItemJson() { categories = new List<string>() { }, crosshair = true });
            json.series.Add(new SeriesItemJson("珠三角"));
            json.series.Add(new SeriesItemJson("东翼"));
            json.series.Add(new SeriesItemJson("西翼"));
            json.series.Add(new SeriesItemJson("山区"));
            //GDPAPatentChartApplyDataQuery query = new GDPAPatentChartApplyDataQuery()
            //{
            //    s_CityCodes = context.citycodes,
            //    n_PatentStatus = context.type,
            //    d_StartYear = context.startDate.Year,
            //    d_EndYear = context.endDate.Year,
            //    d_StartMonth = context.startDate.Month,
            //    d_EndMonth = context.endDate.Month
            //};
            //DataTable table = GDPAPatentChartApplyDataAccessor.Instance().loadDataZLSQ_IPCFLZKT(query);
            ////缺少逻辑
            ////todo:
            json.series[0].data = new List<int>() { 0 };
            json.series[1].data = new List<int>() { 0 };
            json.series[2].data = new List<int>() { 0 };
            json.series[3].data = new List<int>() { 0 };
            return json;
        }
        /// <summary>
        /// 广东省各地市专利申请受理IPC分类情况图--缺失？？？
        /// 数据来源： GDPAPatentChartApplyTypeData
        /// </summary>
        /// <param name="context"></param>
        public ChartJson LoadDataGDS_ZLSQ_IPCFLZKT(HttpContextQuery context)
        {
            ChartJson json = new ChartJson();
            json.charttype = context.charttype;
            json.xAxis.Add(new xAxisItemJson() { categories = new List<string>() { }, crosshair = true });
            json.series.Add(new SeriesItemJson("珠三角"));
            json.series.Add(new SeriesItemJson("东翼"));
            json.series.Add(new SeriesItemJson("西翼"));
            json.series.Add(new SeriesItemJson("山区"));
            //GDPAPatentChartApplyDataQuery query = new GDPAPatentChartApplyDataQuery() { n_ProvinceCode = context.provinceCode, n_PatentStatus = context.type, d_StartYear = context.startDate.Year, d_EndYear = context.endDate.Year, d_StartMonth = context.startDate.Month, d_EndMonth = context.endDate.Month };
            //DataTable table = GDPAPatentChartApplyDataAccessor.Instance().loadDataGDS_ZLSQ_IPCFLZKT(query);
            ////缺少逻辑
            ////todo:
            json.series[0].data = new List<int>() { 0 };
            json.series[1].data = new List<int>() { 0 };
            json.series[2].data = new List<int>() { 0 };
            json.series[3].data = new List<int>() { 0 };
            return json;
        }

        #endregion

       
    }

   
    public class HttpContextQuery
    {
        /// <summary>
        /// 专利类型--1：发明，2：实用新型，3：外观设计
        /// </summary>
        public int patenttype = 0;
        /// <summary>
        /// 专利状态--1：申请，3：授权
        /// </summary>
        public int type = 1;
        /// <summary>
        /// 图表类型
        /// </summary>
        public string charttype="";
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
        /// 申请途径--0：全部，1：直接申请 2：PCT
        /// </summary>
        public int applysource = 0;
        /// <summary>
        /// 是否历年数据
        /// </summary>
        public bool isallyear = false;
        /// <summary>
        /// 数据维度--m:当月，y:当年
        /// </summary>
        public string datatype = "y";
        /// <summary>
        /// 五种专利人类型
        /// </summary>
        public int applicantertype = 0;
        /// <summary>
        /// 
        /// </summary>
        public int patentdatatype;
        public HttpContextQuery(int _patenttype, int _type, string _citycodes, /*DateTime _startDate, DateTime _endDate,*/ string _datatype = "y", int _provinceCode = 19, string _charttype = "")
        {
            //startDate = _startDate;
            //endDate=_endDate;
            var date = DateTime.Now;
            //startDate = (datatype == "y") ? new DateTime(date.Year, 1, 1, 0, 0, 0) : new DateTime(date.Year, date.Month, 1, 0, 0, 0);
            //endDate = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);
            patenttype = _patenttype;
            type = _type;
            citycodes = _citycodes;
            provinceCode = _provinceCode;
            charttype = _charttype;
            applysource = 0;
        }
        //*
        public HttpContextQuery(int _patenttype, int _type, string _citycodes, DateTime _startDate, DateTime _endDate, string _datatype = "y", int _provinceCode = 19, string _charttype = "", int _applysource = 2)
        {
            var date = DateTime.Now;
            datatype = _datatype;
            startDate = _startDate;
            endDate = _endDate;
            //startDate = (datatype == "y") ? new DateTime(date.Year, 1, 1, 0, 0, 0) : new DateTime(date.Year, date.Month, 1, 0, 0, 0);
            //endDate = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);
            patenttype = _patenttype;
            type = _type;
            citycodes = _citycodes;
            provinceCode = _provinceCode;
            charttype = _charttype;
            applysource = _applysource;
        }
        /// <summary>
        /// 涉及到当年，当月数据查询用此函数 *
        /// </summary>
        /// <param name="_patenttype"></param>
        /// <param name="_type"></param>
        /// <param name="_isallyear"></param>
        /// <param name="_datatype"></param>
        /// <param name="_charttype"></param>
        public HttpContextQuery(int _patenttype, int _type, bool _isallyear, DateTime _startDate, DateTime _endDate,string _datatype = "y", string _charttype = "")
        {
            var date = DateTime.Now;
            patenttype = _patenttype;
            type = _type;
            charttype = _charttype;
            isallyear = _isallyear;
            datatype = _datatype;
            startDate = _startDate;
            endDate = _endDate;
            //startDate = (datatype == "y") ? new DateTime(date.Year, 1, 1, 0, 0, 0) : new DateTime(date.Year, date.Month, 1, 0, 0, 0);
            //endDate = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);
        }
        /// <summary>
        /// 五种专利人相关*
        /// </summary>
        /// <param name="_patenttype"></param>
        /// <param name="_type"></param>
        /// <param name="_isallyear"></param>
        /// <param name="_datatype"></param>
        /// <param name="_applicantertype"></param>
        /// <param name="_charttype"></param>
        public HttpContextQuery(int _patenttype, int _type, bool _isallyear, DateTime _startDate, DateTime _endDate, string _datatype = "y", int _applicantertype = 0, string _charttype = "")
        {
            var date = DateTime.Now;
            patenttype = _patenttype;
            type = _type;
            charttype = _charttype;
            isallyear = _isallyear;
            datatype = _datatype;
            startDate = _startDate;
            endDate = _endDate;
            //startDate = (datatype == "y") ? new DateTime(date.Year, 1, 1, 0, 0, 0) : new DateTime(date.Year, date.Month, 1, 0, 0, 0);
            //endDate = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);
            applicantertype = _applicantertype;
        }
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
        public HttpContextQuery(int _patenttype, int _type, string _citycodes, DateTime _startDate, DateTime _endDate,string _datatype = "y", string _charttype = "")
        {
            var date = DateTime.Now;
            datatype = _datatype;
            startDate = _startDate;
            endDate = _endDate;
            //startDate = (datatype == "y") ? new DateTime(date.Year, 1, 1, 0, 0, 0) : new DateTime(date.Year, date.Month, 1, 0, 0, 0);
            //endDate = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);
            patenttype = _patenttype;
            type = _type;
            citycodes = _citycodes;
            charttype = _charttype;
        }
        /// <summary>
        /// 有效发明专用 *
        /// </summary>
        /// <param name="_patentdatatype"></param>
        /// <param name="_provinceCode"></param>
        /// <param name="_charttype"></param>
        public HttpContextQuery(int _type, int _patentdatatype, int _provinceCode, DateTime _startDate, DateTime _endDate, string _datatype = "y", string _charttype = "")
        {
            type = _type;
            var date = DateTime.Now;
            charttype = _charttype;
            patentdatatype = _patentdatatype;
            datatype = _datatype;
            startDate = _startDate;
            endDate = _endDate;
            //startDate = (datatype == "y") ? new DateTime(date.Year, 1, 1, 0, 0, 0) : new DateTime(date.Year, date.Month, 1, 0, 0, 0);
            //endDate = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);
            
        }
        public void setDateTime(DateTime _startdate,DateTime _enddate)
        {
            startDate = _startdate;
            endDate = _enddate;
        }
        public HttpContextQuery()
        {
        }
        
    }
    public class ProviceCatch
    {
        private Hashtable proviceTable = new Hashtable();

        private Hashtable cityTable = new Hashtable();

        static ProviceCatch _instance = new ProviceCatch();
        private ProviceCatch()
        { }
        public static ProviceCatch instance()
        {
            return _instance;
        }
        public string GetProviceName(int code)
        {
            if (proviceTable.ContainsKey(code))
            {
                return proviceTable[code].ToString();
            }
            return null;
        }
        public string GetCityName(int code)
        {
            if (cityTable.ContainsKey(code))
            {
                return cityTable[code].ToString();
            }
            return null;
        }

        public void LoadData()
        {
            if (proviceTable.Count > 0)
                return;
            proviceTable.Add(1, "安徽");
            proviceTable.Add(2, "北京");
            proviceTable.Add(3, "福建");
            proviceTable.Add(4, "甘肃");
            proviceTable.Add(5, "广东");
            proviceTable.Add(6, "广西");

            cityTable.Add(116, "东莞市");
            cityTable.Add(68, "佛山市");
            cityTable.Add(35, "广州市");
            cityTable.Add(85, "河源市");
            cityTable.Add(101, "惠州市");
            cityTable.Add(179, "江门市");

            cityTable.Add(173, "揭阳市");
            cityTable.Add(211, "茂名市");
            cityTable.Add(34, "兰州市");
            cityTable.Add(73, "南宁市");
            cityTable.Add(17, "北京市");
            cityTable.Add(23, "泉州市");
            cityTable.Add(6, "合肥市");
        }
    }
}

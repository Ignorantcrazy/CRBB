using CRBIReportLib.DataAccessors;
using CRBIReportLib.ReportData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRBIReportLib.ReportBase
{
    class GDPA_3ZZL_ChartJsonData { };
    /// <summary>
    /// 基本数据对象
    /// </summary>
    public class CRBIBasicData
    {
        /// <summary>
        /// 
        /// </summary>
        //public CRBIReportRule reportRule = null;
        public CRBIBasicData()
        {
            //r//eportRule = new CRBIReportRule();
        }
        #region 表头
        /// <summary>
        /// 报表当前期刊号
        /// 2015年第11期（总第116期）
        /// </summary>
        public string ReportThoseYearNoTitle { get; set; }
        /// <summary>
        /// 报表生成年月
        /// 2015年12月
        /// </summary>
        public string ReportCreateDateTitle { get; set; }
        /// <summary>
        /// 报表内容时间区间
        /// 2015.1-11
        /// </summary>
        public string ReportContentDateTitle { get; set; }
        #endregion

        //#region 一、查询设备信息
        ///// <summary>
        ///// 一、查询设备信息
        ///// </summary>
        //public CRBICharge_BatEquipmentInfoContent LoadContent_1_0()
        //{
        //    HttpContextQuery query = new HttpContextQuery()
        //    {
        //        type = 1
        //    };
        //    //CRBITBL_ChargeAccessor.Instance().GetBatEquipmentInfo()
        //    CRBICharge_BatEquipmentInfoContent data = new CRBICharge_BatEquipmentInfoContent();//GetBatEquipmentInfo
        //    return data;
        //}
        
        //#endregion

        //#region 二、查询电池组信息
        ///// <summary>
        ///// 二、查询电池组信息
        ///// </summary>
        //public CRBICharge_BatteryPackInfoContent LoadContent_2_0()
        //{
        //    CRBICharge_BatteryPackInfoContent data = new CRBICharge_BatteryPackInfoContent();//GetBetteryInfo
        //    return data;
        //}
        //#endregion

        //#region 三、查询充电电池参数信息
        ///// <summary>
        ///// 三、查询充电电池参数信息
        ///// </summary>
        //public CRBICharge_BatteryParameterContent LoadContent_3_0()
        //{
        //    CRBICharge_BatteryParameterContent data = new CRBICharge_BatteryParameterContent();//GetBetteryInfo
        //    return data;
        //}
        //#endregion

        //#region 四、查询电池组测试信息

        ///// <summary>
        ///// 充电曲线
        ///// </summary>
        ///// <returns></returns>
        //public CRBI_C31_CSJLChart LoadContent_4_1_C31_CDQXChart()
        //{
        //    CRBI_C31_CSJLChart data = new CRBI_C31_CSJLChart();//
        //    return data;
        //}
        ///// <summary>
        ///// 电压曲线
        ///// </summary>
        ///// <returns></returns>
        //public CRBI_C32_DYQXChart LoadContent_4_2_C32_DYQXChart()
        //{
        //    CRBI_C32_DYQXChart data = new CRBI_C32_DYQXChart();//
        //    return data;
        //}
        ///// <summary>
        ///// 电流曲线
        ///// </summary>
        ///// <returns></returns>
        //public CRBI_C33_DLQXChart LoadContent_4_3_C33_DLQXChart()
        //{
        //    CRBI_C33_DLQXChart data = new CRBI_C33_DLQXChart();//
        //    return data;
        //}

        //#endregion

        //#region 五、查询电池组测试结论
        ///// <summary>
        ///// 结论与方案 结论
        ///// </summary>
        //public CRBICharge_TestResultContnt LoadContent_5_2_C23_JLFATable_Result()
        //{
        //    CRBICharge_TestResultContnt data = new CRBICharge_TestResultContnt();//
        //    return data;
        //}
        ///// <summary>
        ///// 结论与方案 表格
        ///// </summary>
        //public CRBI_C23_JLFATable LoadContent_5_1_C23_JLFATable()
        //{
        //    CRBI_C23_JLFATable data = new CRBI_C23_JLFATable();//
        //    return data;
        //}

        //#endregion
        


        #region 一、专利申请受理、授权概括及排名

        #endregion

        ////#region 二、专利申请受理、授权基本情况
        ///// <summary>
        ///// 广东（全国）专利数据对象(申请，授权)
        ///// 广东（全国）专利申请受理量
        ///// 广东（全国）发明专利申请受理量
        ///// 广东（全国）发明专利申请同比增长率
        ///// 广东（全国）实用新型专利申请受理量
        ///// 广东（全国）实用新型专利申请同比增长率
        ///// 广东（全国）外观设计专利申请受理量
        ///// 广东（全国）外观设计专利申请同比增长率
        ///// </summary>
        //public GDPA_3ZZL_ChartJsonData loadData_3ZZL_Data_1D()
        //{
        //    HttpContextQuery query = new HttpContextQuery()
        //    {
        //        type = 1
        //    };
        //    ChartJson json = CRBIReportProjectRule.Intance().LoadDataZLSQSLQST(query);
        //    GDPA_3ZZL_ChartJsonData data = new GDPA_3ZZL_ChartJsonData();
        //    //统计广东申请
        //    load_1ZZLSQR_3ZZLLX_1D(query, data.gdpa_3ZZL_SQ_1);
        //    //统计广东授权
        //    query.type = 3;
        //    json = CRBIReportProjectRule.Intance().LoadDataZLSQSLQST(query);
        //    load_1ZZLSQR_3ZZLLX_1D(query, data.gdpa_3ZZL_SQ_3);
        //    //统计全国申请

        //    //统计全国授权


        //    return data;
        //}

        ///// <summary>
        ///// 广东广东省五种类型申请人三种专利类型数据对象
        ///// </summary>
        //public GDPA_5ZZLSQR_3ZZLLX_ChartJsonData loadData_5ZZLSQR_3ZZLLX_1D()
        //{
        //    HttpContextQuery query = new HttpContextQuery()
        //    {
        //        patenttype = 1,
        //        type = 0,
        //        isallyear = false,
        //        patentdatatype = 0,
        //        applicantertype = 1
        //    };
        //    ChartJson json = CRBIReportProjectRule.Intance().LoadDataXXXLX_ZLSQRLXZKT(query);
        //    GDPA_5ZZLSQR_3ZZLLX_ChartJsonData data = new GDPA_5ZZLSQR_3ZZLLX_ChartJsonData();
        //    load_1ZZLSQR_3ZZLLX_1D(query, data.gdpa_5ZSQR_GD_SQ_1_1);

        //    query.applicantertype = 2;
        //    load_1ZZLSQR_3ZZLLX_1D(query, data.gdpa_5ZSQR_GD_SQ_1_2);

        //    query.applicantertype = 3;
        //    load_1ZZLSQR_3ZZLLX_1D(query, data.gdpa_5ZSQR_GD_SQ_1_3);

        //    query.applicantertype = 4;
        //    load_1ZZLSQR_3ZZLLX_1D(query, data.gdpa_5ZSQR_GD_SQ_1_4);

        //    query.applicantertype = 5;
        //    load_1ZZLSQR_3ZZLLX_1D(query, data.gdpa_5ZSQR_GD_SQ_1_5);

        //    query.type = 3;
        //    query.applicantertype = 1;
        //    load_1ZZLSQR_3ZZLLX_1D(query, data.gdpa_5ZSQR_GD_SQ_3_1);

        //    query.applicantertype = 2;
        //    load_1ZZLSQR_3ZZLLX_1D(query, data.gdpa_5ZSQR_GD_SQ_3_2);

        //    query.applicantertype = 3;
        //    load_1ZZLSQR_3ZZLLX_1D(query, data.gdpa_5ZSQR_GD_SQ_3_3);

        //    query.applicantertype = 4;
        //    load_1ZZLSQR_3ZZLLX_1D(query, data.gdpa_5ZSQR_GD_SQ_3_4);

        //    query.applicantertype = 5;
        //    load_1ZZLSQR_3ZZLLX_1D(query, data.gdpa_5ZSQR_GD_SQ_3_5);
        //    return data;
        //}

        ///// <summary>
        ///// 广东广东省五种类型申请人一种专利类型数据对象
        ///// </summary>
        //public GDPA_5ZZLSQR_1ZZLLX_ChartJsonData loadData_5ZZLSQR_1ZZLLX_1D()
        //{
        //    HttpContextQuery query = new HttpContextQuery()
        //    {
        //        patenttype = 0,
        //        type = 1,
        //        isallyear = false,
        //        patentdatatype = 0,
        //        applicantertype = 0
        //    };
        //    GDPA_5ZZLSQR_1ZZLLX_ChartJsonData data = new GDPA_5ZZLSQR_1ZZLLX_ChartJsonData();
        //    load_5ZZLSQR_1ZZLLX_1D(query, data.gdpa_5ZSQR_GD_SQ_1);
        //    query.type = 3;
        //    load_5ZZLSQR_1ZZLLX_1D(query, data.gdpa_5ZSQR_GD_SQ_3);
        //    return data;
        //}
        //private void load_5ZZLSQR_3ZZLLX_1D(HttpContextQuery query, GDPA_3ZZL_SQ data)
        //{
        //    ChartJson json = CRBIReportProjectRule.Intance().LoadDataXXXLX_ZLSQRLXZKT(query);
        //    data.n_ZL_1_SQ_Count = json.series[0].data[0];
        //    data.n_ZL_2_SQ_Count = json.series[0].data[1];
        //    data.n_ZL_3_SQ_Count = json.series[0].data[2];
        //    data.n_ZL_0_SQ_Count = data.n_ZL_1_SQ_Count
        //                                        + data.n_ZL_2_SQ_Count
        //                                        + data.n_ZL_3_SQ_Count;

        //    data.d_ZL_1_SQ_TBZZL = json.series[0].data_f[0];
        //    data.d_ZL_2_SQ_TBZZL = json.series[0].data_f[1];
        //    data.d_ZL_3_SQ_TBZZL = json.series[0].data_f[2];
        //    data.d_ZL_0_SQ_TBZZL = data.d_ZL_1_SQ_TBZZL
        //                                        + data.d_ZL_2_SQ_TBZZL
        //                                        + data.d_ZL_3_SQ_TBZZL;
        //}

        //private void load_1ZZLSQR_3ZZLLX_1D(HttpContextQuery query, GDPA_3ZZL_SQ data)
        //{
        //    ChartJson json = CRBIReportProjectRule.Intance().LoadDataXXXLX_ZLSQRLXZKT(query);
        //    data.n_ZL_1_SQ_Count = json.series[0].data[0];
        //    data.n_ZL_2_SQ_Count = json.series[0].data[1];
        //    data.n_ZL_3_SQ_Count = json.series[0].data[2];
        //    data.n_ZL_0_SQ_Count = data.n_ZL_1_SQ_Count
        //                                        + data.n_ZL_2_SQ_Count
        //                                        + data.n_ZL_3_SQ_Count;

        //    //data.d_ZL_1_SQ_TBZZL = json.series[0].data_f[0];
        //    //data.d_ZL_2_SQ_TBZZL = json.series[0].data_f[1];
        //    //data.d_ZL_3_SQ_TBZZL = json.series[0].data_f[2];
        //    //data.d_ZL_0_SQ_TBZZL = data.d_ZL_1_SQ_TBZZL
        //    //                                    + data.d_ZL_2_SQ_TBZZL
        //    //                                    + data.d_ZL_3_SQ_TBZZL;
        //}
        //private void load_5ZZLSQR_1ZZLLX_1D(HttpContextQuery query, GDPA_1ZZL_5ZZLSQR_SQ data)
        //{
        //    ChartJson json = CRBIReportProjectRule.Intance().LoadDataXXXLX_ZLSQRLXZKT(query);
        //    data.n_1ZZL_1_ZLSQR_1_SQ_Count = json.series[0].data[0];
        //    data.n_1ZZL_1_ZLSQR_2_SQ_Count = json.series[0].data[1];
        //    data.n_1ZZL_1_ZLSQR_3_SQ_Count = json.series[0].data[2];
        //    data.n_1ZZL_1_ZLSQR_4_SQ_Count = json.series[0].data[3];
        //    data.n_1ZZL_1_ZLSQR_5_SQ_Count = json.series[0].data[4];

        //    data.n_1ZZL_2_ZLSQR_1_SQ_Count = json.series[0].data[0];
        //    data.n_1ZZL_2_ZLSQR_2_SQ_Count = json.series[0].data[1];
        //    data.n_1ZZL_2_ZLSQR_3_SQ_Count = json.series[0].data[2];
        //    data.n_1ZZL_2_ZLSQR_4_SQ_Count = json.series[0].data[3];
        //    data.n_1ZZL_2_ZLSQR_5_SQ_Count = json.series[0].data[4];

        //    data.n_1ZZL_3_ZLSQR_1_SQ_Count = json.series[0].data[0];
        //    data.n_1ZZL_3_ZLSQR_2_SQ_Count = json.series[0].data[1];
        //    data.n_1ZZL_3_ZLSQR_3_SQ_Count = json.series[0].data[2];
        //    data.n_1ZZL_3_ZLSQR_4_SQ_Count = json.series[0].data[3];
        //    data.n_1ZZL_3_ZLSQR_5_SQ_Count = json.series[0].data[4];
        //}
        //#endregion

        //#region 三、PCT国际专利申请受理情况

        //#endregion

        //#region 四、每万人口发明专利拥有量情况

        //#endregion

        //#region 五、专利电子申请情况

        //#endregion

        //#region 附图：广东省专利申请受理、授权情况图示
        //#region 数据转换
        //private void convertJsonToPieData(ChartJson json, GDPADocChartData chart)
        //{
        //    //添加首列
        //    //chart.AddHeader(json.xAxis[0].categories);
        //    List<string> header = new List<string>();

        //    List<int> rows = new List<int>();
        //    //添加数据列
        //    for (int i = 0; i < json.series.Count; i++)
        //    {
        //        rows.Add(json.series[i].data.Count() > 0 ? json.series[i].data[0] : 0);
        //        header.Add(json.series[i].name);
        //    }
        //    chart.AddHeader(header);
        //    chart.Add(rows, "", 1);
        //}
        //private void convertJsonToLineData(ChartJson json, GDPADocChartData chart)
        //{
        //    //添加首列
        //    chart.AddHeader(json.xAxis[0].categories);
        //    var title = "";
        //    var index = 0;
        //    List<int> rows = new List<int>();
        //    //添加数据列
        //    for (int i = 0; i < json.series.Count; i++)
        //    {
        //        index = i;
        //        title = json.series[i].name;
        //        rows = json.series[i].data;
        //        chart.Add(rows, title, index);
        //    }
        //}
        //private void convertJsonToColumnData(ChartJson json, GDPADocChartData chart)
        //{
        //    //添加首列
        //    chart.AddHeader(json.xAxis[0].categories);
        //    var title = "";
        //    var index = 0;
        //    List<int> rows = new List<int>();
        //    //添加数据列
        //    for (int i = 0; i < json.series.Count; i++)
        //    {
        //        index = i;
        //        title = json.series[i].name;
        //        rows = json.series[i].data;
        //        chart.Add(rows, title, index);
        //    }
        //}
        //private void convertJsonToCloumnAndLineData(ChartJson json, GDPADocChartData chart)
        //{
        //    //添加首列
        //    chart.AddHeader(json.xAxis[0].categories);
        //    var title = "";
        //    var index = 0;
        //    List<double> rows_f = new List<double>();
        //    List<int> rows = new List<int>();
        //    //添加数据列
        //    for (int i = 0; i < json.series.Count / 2; i++)//
        //    {
        //        index = i;
        //        title = json.series[i].name;
        //        rows = json.series[i].data;
        //        chart.Add(rows, title, index);
        //    }
        //    for (int i = 0; i < json.series.Count / 2; i++)//
        //    {
        //        index = i + json.series.Count / 2;
        //        title = json.series[index].name;
        //        rows_f = json.series[i].data_f;
        //        chart.Add(rows_f, title, index);
        //    }
        //}
        //#endregion

        //#region 申请，授权

        ///// <summary>
        ///// 广东省三种专利类型申请受理（/授权）趋势图
        ///// </summary>
        ///// <returns></returns>
        //protected GDPADocChartData loadData_3Z_ZLLX_SQ_QST(int patentStatus, string chartType = "")
        //{
        //    HttpContextQuery query = new HttpContextQuery()
        //    {
        //        type = patentStatus,
        //        startDate = GDPAConst.const_StartDate,
        //        endDate = GDPAConst.const_EndDate
        //    };
        //    GDPADocChartData chart = new GDPADocChartData(chartType);
        //    ChartJson json = CRBIReportProjectRule.Intance().LoadDataZLSQSLQST(query);

        //    convertJsonToCloumnAndLineData(json, chart);

        //    return chart;
        //}
        ///// <summary>
        ///// 广东省三种专利类型申请受理（/授权）状况图(年月)
        ///// </summary>
        ///// <returns></returns>
        //protected GDPADocChartData loadData_3Z_ZLLX_SQ_ZKT(int patentStatus, int patentType = 1, string dataType = "y", string chartType = "", bool isAllYear = false)
        //{
        //    HttpContextQuery query = new HttpContextQuery(patentType, patentStatus, isAllYear, GDPAConst.const_StartDate, GDPAConst.const_EndDate, dataType, chartType);
        //    //query.setDateTime(GDPAConst.const_StartDate, GDPAConst.const_EndDate);
        //    GDPADocChartData chart = new GDPADocChartData(chartType);//"line|column");
        //    ChartJson json = CRBIReportProjectRule.Intance().LoadDataSZZLLXSQSLZKT(query);

        //    convertJsonToPieData(json, chart);

        //    return chart;
        //}
        ///// <summary>
        ///// 广东省发明专利申请受理（/授权）趋势图
        ///// 顺序：发明，实用新型，外观设计，发明增长率，实用新型增长率，外观设计增长率
        ///// </summary>
        ///// <param name="patentStatus">1:申请,3:授权</param>
        ///// <param name="patentType">1:发明,2:实用新型,3:外观设计</param>
        ///// <param name="dataType">y:年,m:月</param>
        ///// <param name="chartType"></param>
        ///// <param name="isAllYear"></param>
        ///// <returns></returns>
        //protected GDPADocChartData loadData_1Z_ZLLX_SQ_QST(int patentStatus, int patentType = 1, string dataType = "y", string chartType = "", bool isAllYear = false)
        //{
        //    HttpContextQuery query = new HttpContextQuery(patentType, patentStatus, isAllYear, GDPAConst.const_StartDate, GDPAConst.const_EndDate, dataType, chartType);
        //    GDPADocChartData chart = new GDPADocChartData("line|column");
        //    ChartJson json = CRBIReportProjectRule.Intance().LoadDataFMZLSQSLQST(query);
        //    ChartJson jsonOnePatentType = GetOnePatentTypeAndDiv100(json, patentType);
        //    convertJsonToCloumnAndLineData(jsonOnePatentType, chart);

        //    return chart;
        //}
        //private ChartJson GetOnePatentTypeAndDiv100(ChartJson jsonIni, int iPatentType)
        //{
        //    ChartJson jsonNew = new ChartJson();
        //    jsonNew.xAxis = jsonIni.xAxis;//  .Add(new xAxisItemJson() { categories = new List<string>() { }, crosshair = true }); jsonIni.xAxis
        //    jsonNew.series.Add(jsonIni.series[iPatentType - 1]);
        //    jsonNew.series.Add(jsonIni.series[iPatentType - 1 + 3]);
        //    for (int i = 0; i < jsonNew.series[0].data_f.Count; i++)
        //    {
        //        jsonNew.series[0].data_f[i] = jsonNew.series[0].data_f[i] * 0.01;
        //    }

        //    //jsonNew.
        //    //jsonNew.series[iPatentType-1]
        //    return jsonNew;
        //}
        //#endregion

        //#region 五种专利人类型相关数据
        ///// <summary>
        ///// 针对五种类型的申请人，算发明（实用新型，外观某一类）专利的申请数据
        ///// 广东省发明专利申请人（/授权专利权）类型状况图(年月)
        ///// </summary>
        ///// <param name="patentStatus">1:申请,3:授权</param>
        ///// <param name="patentType">1:发明,2:实用新型,3:外观设计</param>
        ///// <param name="dataType">y:年,m:月</param>
        ///// <param name="chartType"></param>
        ///// <param name="isAllYear"></param>
        ///// <param name="applicanterType">申请人类型：1：大专院校，2：科研机构，3：企业，4：机关团体，5：个人</param>
        ///// <returns></returns>
        //protected GDPADocChartData loadData_5Z_ZLSQR_1Z_ZLLX_SQ_ZKT(int patentStatus, int patentType = 1, string dataType = "y", string chartType = "", bool isAllYear = false, int applicanterType = 0)
        //{
        //    HttpContextQuery query = new HttpContextQuery(patentType, patentStatus, isAllYear, GDPAConst.const_StartDate, GDPAConst.const_EndDate, dataType, applicanterType, chartType);
        //    //query.setDateTime(GDPAConst.const_StartDate, GDPAConst.const_EndDate);
        //    GDPADocChartData chart = new GDPADocChartData("pie");
        //    ChartJson json = CRBIReportProjectRule.Intance().LoadDataXXXLX_ZLSQRLXZKT(query);

        //    convertJsonToPieData(json, chart);

        //    return chart;
        //}
        ///// <summary>
        ///// 针对五种类型的申请人，算发明，实用新型，外观设计的申请数据总和
        ///// </summary>
        ///// <param name="patentStatus"></param>
        ///// <param name="patentType"></param>
        ///// <param name="dataType"></param>
        ///// <param name="chartType"></param>
        ///// <param name="isAllYear"></param>
        ///// <param name="applicanterType"></param>
        ///// <returns></returns>
        //protected GDPADocChartData loadData_5Z_LXSQR_3Z_ZLLX_SQ_ZKT(int patentStatus, int patentType = 1, string dataType = "y", string chartType = "", bool isAllYear = false, int applicanterType = 0)
        //{
        //    HttpContextQuery query = new HttpContextQuery(patentType, patentStatus, isAllYear, GDPAConst.const_StartDate, GDPAConst.const_EndDate, dataType, applicanterType, chartType);
        //    //query.setDateTime(GDPAConst.const_StartDate, GDPAConst.const_EndDate);
        //    GDPADocChartData chart = new GDPADocChartData(chartType);
        //    ChartJson json = CRBIReportProjectRule.Intance().LoadDataWZLXSQRZLSQSLT(query);

        //    convertJsonToPieData(json, chart);

        //    return chart;
        //}

        ///// <summary>
        ///// 针对三种专利数据，算1种人的占比
        ///// 广东省工矿企业(等五种专利人)专利申请受理（/授权）状况图(年月)
        ///// </summary>
        ///// <returns></returns>
        //protected GDPADocChartData loadData_1Z_LXSQR_3Z_ZLLX_SQ_ZKT(int patentStatus, int patentType = 1, string dataType = "y", string chartType = "", bool isAllYear = false, int applicanterType = 0)
        //{
        //    HttpContextQuery query = new HttpContextQuery(patentType, patentStatus, isAllYear, GDPAConst.const_StartDate, GDPAConst.const_EndDate, dataType, applicanterType, chartType);
        //    //query.setDateTime(GDPAConst.const_StartDate, GDPAConst.const_EndDate);
        //    GDPADocChartData chart = new GDPADocChartData(chartType);
        //    ChartJson json = CRBIReportProjectRule.Intance().LoadDataWZLXSQRZLSQSLT(query);

        //    convertJsonToPieData(json, chart);

        //    return chart;
        //}

        ///// <summary>
        ///// 针对三种专利数据，算1种人的占比
        ///// 广东省工矿企业(等五种专利人)专利申请受理（/授权）状况图(年月)
        ///// </summary>
        ///// <returns></returns>
        //protected GDPADocChartData loadDataXXXLXSQR_SZZLSQZKT(int patentStatus, int patentType = 1, string dataType = "y", string chartType = "", bool isAllYear = false, int applicanterType = 0)
        //{
        //    HttpContextQuery query = new HttpContextQuery(patentType, patentStatus, isAllYear, GDPAConst.const_StartDate, GDPAConst.const_EndDate, dataType, applicanterType, chartType);
        //    //query.setDateTime(GDPAConst.const_StartDate, GDPAConst.const_EndDate);
        //    GDPADocChartData chart = new GDPADocChartData(chartType);
        //    ChartJson json = CRBIReportProjectRule.Intance().LoadDataXXXLXSQR_SZZLSQZKT(query);

        //    convertJsonToPieData(json, chart);

        //    return chart;
        //}
        ///// <summary>
        ///// 广东省各区域专利申请受理（/授权）状况图(年月)
        ///// </summary>
        ///// <returns></returns>
        //protected GDPADocChartData loadDataGQY_3Z_ZLLX_SQ_ZKT(int patentStatus, int patentType = 1, string dataType = "y", string chartType = "", bool isAllYear = false, int applicanterType = 0)
        //{
        //    HttpContextQuery query = new HttpContextQuery(patentType, patentStatus, isAllYear, GDPAConst.const_StartDate, GDPAConst.const_EndDate, dataType, applicanterType, chartType);
        //    //query.setDateTime(GDPAConst.const_StartDate, GDPAConst.const_EndDate);
        //    GDPADocChartData chart = new GDPADocChartData(chartType);
        //    ChartJson json = CRBIReportProjectRule.Intance().LoadDataGQY_ZLSQ_SQZKT(query);

        //    convertJsonToColumnData(json, chart);

        //    return chart;
        //}
        //#endregion

        //#region 广东省PCT
        ///// <summary>
        ///// 广东省PCT国际专利申请区域状况图
        ///// 自定义类型:1:申请，3：授权，2:有效发明，4：PCT，5：电子申请
        ///// </summary>
        ///// <param name="context"></param>
        //protected GDPADocChartData loadDataPCT_GJZL_SQQY_ZKT(int patentStatus, int provinceCode, string citycodes, int applysource, int patentType = 1, string dataType = "y", string chartType = "", bool isAllYear = false, int applicanterType = 0)
        //{

        //    HttpContextQuery query = new HttpContextQuery(patentType, patentStatus, isAllYear, GDPAConst.const_StartDate, GDPAConst.const_EndDate, dataType, applicanterType, chartType)
        //    {
        //        provinceCode = provinceCode,
        //        applysource = applysource,
        //        citycodes = citycodes
        //    };
        //    //query.setDateTime(GDPAConst.const_StartDate, GDPAConst.const_EndDate);
        //    GDPADocChartData chart = new GDPADocChartData(chartType);
        //    ChartJson json = CRBIReportProjectRule.Intance().LoadDataPCT_GJZL_SQQY_ZKT(query);

        //    convertJsonToPieData(json, chart);

        //    return chart;
        //}
        //#endregion

        //#region  广东有效发明
        ///// <summary>
        ///// 历年有效发明状况---??????
        ///// </summary>
        ///// <param name="context"></param>
        //protected GDPADocChartData loadDataYXFM_LN_ZKT(int patentStatus, int provinceCode, string citycodes, int patentdatatype, int patentType = 1, string dataType = "y", string chartType = "", bool isAllYear = false, int applicanterType = 0)
        //{
        //    HttpContextQuery query = new HttpContextQuery(patentType, patentStatus, isAllYear, GDPAConst.const_StartDate, GDPAConst.const_EndDate, dataType, applicanterType, chartType)
        //    {
        //        patentdatatype = patentdatatype,
        //        provinceCode = provinceCode,
        //        //applysource = patentdatatype,
        //        citycodes = citycodes
        //    };
        //    //query.setDateTime(GDPAConst.const_StartDate, GDPAConst.const_EndDate);
        //    GDPADocChartData chart = new GDPADocChartData(chartType);
        //    ChartJson json = CRBIReportProjectRule.Intance().LoadDataYXFM_LN_ZKT(query);

        //    convertJsonToPieData(json, chart);

        //    return chart;
        //}
        ///// <summary>
        ///// 有效发明申请人类型比例图
        ///// 广东省五种类型申请人有效发明专利申请状况图示
        ///// 自定义类型:1:申请，3：授权，2:有效发明，4：PCT，5：电子申请
        ///// </summary>
        ///// <param name="context"></param>
        //protected GDPADocChartData loadDataYXFM_ZLRLXZKT(int patentStatus, int provinceCode, string citycodes, int patentdatatype, int patentType = 1, string dataType = "y", string chartType = "", bool isAllYear = false, int applicanterType = 0)
        //{

        //    HttpContextQuery query = new HttpContextQuery(patentType, patentStatus, isAllYear, GDPAConst.const_StartDate, GDPAConst.const_EndDate, dataType, applicanterType, chartType)
        //    {
        //        patentdatatype = patentdatatype,
        //        provinceCode = provinceCode,
        //        //applysource = patentdatatype,
        //        citycodes = citycodes
        //    };
        //    //query.setDateTime(GDPAConst.const_StartDate, GDPAConst.const_EndDate);
        //    GDPADocChartData chart = new GDPADocChartData(chartType);
        //    ChartJson json = CRBIReportProjectRule.Intance().LoadDataYXFM_ZLRLXZKT(query);

        //    convertJsonToPieData(json, chart);

        //    return chart;
        //}
        ///// <summary>
        ///// 有效发明维持年限
        ///// </summary>
        ///// <param name="context"></param>
        //protected GDPADocChartData loadDataYXFM_WCNXZKT(int patentStatus, int provinceCode, string citycodes, int applysource, int patentType = 1, string dataType = "y", string chartType = "", bool isAllYear = false, int applicanterType = 0)
        //{
        //    HttpContextQuery query = new HttpContextQuery(patentType, patentStatus, isAllYear, GDPAConst.const_StartDate, GDPAConst.const_EndDate, dataType, applicanterType, chartType)
        //    {
        //        provinceCode = provinceCode,
        //        applysource = applysource,
        //        citycodes = citycodes
        //    };
        //    //query.setDateTime(GDPAConst.const_StartDate, GDPAConst.const_EndDate);
        //    GDPADocChartData chart = new GDPADocChartData(chartType);
        //    ChartJson json = CRBIReportProjectRule.Intance().LoadDataYXFM_WCNXZKT(query);

        //    convertJsonToColumnData(json, chart);
        //    return chart;
        //}

        //#endregion

        //#region 全国数据
        ///// <summary>
        ///// 全国发明(/实用新型/外观设计)专利某一种类型的申请受理图示
        ///// </summary>
        ///// <param name="context"></param>
        ///// <returns></returns>
        //protected GDPADocChartData loadData_1Z_ZLLX_SQ_TS_CN(int patentStatus, int patentType = 1, string dataType = "y", string chartType = "", bool isAllYear = false, int applicanterType = 0)
        //{

        //    HttpContextQuery query = new HttpContextQuery(patentType, patentStatus, isAllYear, GDPAConst.const_StartDate, GDPAConst.const_EndDate, dataType, applicanterType, chartType)
        //    {
        //    };
        //    //query.setDateTime(GDPAConst.const_StartDate, GDPAConst.const_EndDate);
        //    GDPADocChartData chart = new GDPADocChartData(chartType);
        //    ChartJson json = new ChartJson();
        //    //= GDPAReportProjectRule.Intance().Load_Province_Patent_1_Month(patentStatus);

        //    convertJsonToPieData(json, chart);

        //    return chart;
        //}

        ///// <summary>
        ///// 全国专利申请受理（/授权）趋势图
        ///// </summary>
        ///// <param name="context"></param>
        //protected GDPADocChartData loadData_3Z_ZLLX_SQ_QST_CN(int patentStatus, int patentType = 1, string dataType = "y", string chartType = "", bool isAllYear = false, int applicanterType = 0)
        //{
        //    HttpContextQuery query = new HttpContextQuery(patentType, patentStatus, isAllYear, GDPAConst.const_StartDate, GDPAConst.const_EndDate, dataType, applicanterType, chartType)
        //    {
        //    };
        //    //query.setDateTime(GDPAConst.const_StartDate, GDPAConst.const_EndDate);
        //    GDPADocChartData chart = new GDPADocChartData(chartType);
        //    ChartJson json = CRBIReportProjectRule.Intance().LoadDataZLSQSLQST_CN(query);

        //    convertJsonToCloumnAndLineData(json, chart);

        //    return chart;
        //}
        ///// <summary>
        ///// 全国发明(/实用新型/外观设计)专利某一种类型的申请受理趋势图
        ///// </summary>
        ///// <param name="context"></param>
        //protected GDPADocChartData loadData_1Z_ZLLX_SQ_QST_CN(int patentStatus, int patentType = 1, string dataType = "y", string chartType = "", bool isAllYear = false, int applicanterType = 0)
        //{
        //    HttpContextQuery query = new HttpContextQuery(patentType, patentStatus, isAllYear, GDPAConst.const_StartDate, GDPAConst.const_EndDate, dataType, applicanterType, chartType)
        //    {
        //    };
        //    //query.setDateTime(GDPAConst.const_StartDate, GDPAConst.const_EndDate);
        //    GDPADocChartData chart = new GDPADocChartData(chartType);
        //    ChartJson json = CRBIReportProjectRule.Intance().LoadDataFMZLSQSLQST_CN(query);

        //    convertJsonToCloumnAndLineData(json, chart);

        //    return chart;
        //}
        ///// <summary>
        ///// 全国三种专利类型申请受理（/授权）状况图(年月)--饼状图暂未用 
        ///// 数据来源：GDPAPatentChartApplicanterTypeData
        ///// </summary>
        ///// <param name="context"></param>
        //protected GDPADocChartData loadData_3Z_ZLLX_SQ_ZKT_CN(int patentStatus, int patentType = 1, string dataType = "y", string chartType = "", bool isAllYear = false, int applicanterType = 0)
        //{

        //    HttpContextQuery query = new HttpContextQuery(patentType, patentStatus, isAllYear, GDPAConst.const_StartDate, GDPAConst.const_EndDate, dataType, applicanterType, chartType)
        //    {
        //    };
        //    //query.setDateTime(GDPAConst.const_StartDate, GDPAConst.const_EndDate);
        //    GDPADocChartData chart = new GDPADocChartData(chartType);
        //    ChartJson json = CRBIReportProjectRule.Intance().LoadDataSZZLLXSQSLZKT_CN(query);

        //    convertJsonToPieData(json, chart);

        //    return chart;

        //}
        ///// <summary>
        ///// XXXX年X-X月全国专利申请受理量图示 
        ///// </summary>
        ///// <param name="context"></param>
        //protected GDPADocChartData LoadDataZLSQSL_TS_CN(DateTime dtStart, DateTime dtEnd, int iType = 1)
        //{
        //    HttpContextQuery query = new HttpContextQuery()
        //    {
        //        startDate = dtStart,
        //        endDate = dtEnd,
        //        type=iType
        //    };
        //    GDPADocChartData chart = new GDPADocChartData("y");
        //    ChartJson json = CRBIReportProjectRule.Intance().LoadDataZLSQSL_TS_CN_NoRate(query);
        //    convertJsonToColumnData(json, chart);
        //    return chart;
        //}
        ///// <summary>
        ///// 全国部分省市专利申请受理(授权)中三种类型专利比例图
        ///// 数据来源：GDPAPatentChartApplicanterTypeData
        ///// </summary>
        ///// <param name="context"></param>
        //protected GDPADocChartData loadDataCity_SZZLLXSQ_BLT_CN(int patentStatus, int patentType = 1, string dataType = "y", string chartType = "", bool isAllYear = false, int applicanterType = 0)
        //{
        //    HttpContextQuery query = new HttpContextQuery(patentType, patentStatus, isAllYear, GDPAConst.const_StartDate, GDPAConst.const_EndDate, dataType, applicanterType, chartType)
        //    {
        //    };
        //    //query.setDateTime(GDPAConst.const_StartDate, GDPAConst.const_EndDate);
        //    GDPADocChartData chart = new GDPADocChartData(chartType);
        //    ChartJson json = CRBIReportProjectRule.Intance().LoadDataCity_SZZLLXSQ_BLT_CN(query);

        //    convertJsonToColumnData(json, chart);

        //    return chart;
        //}
        //#endregion

        //#endregion

        //#region 附表：广东省专利申请及授权情况表

        ////表1  2015年1-11月广东省各类专利申请人三种专利申请情况

        ////表2  2015年1-11月广东省各类专利权人三种专利授权情况

        ////表3   2015年1-11月广东省企业专利申请情况

        ////表4  2015年1-11月广东省各地级以上市PCT国际专利申请情况

        ////表5   截止至2015年11月广东省各地级以上市有效发明专利情况

        ////表6  2015年1-11月广东省企业专利授权前十名

        ////表7  2015年1-11月广东省大专院校专利授权前五名

        ////表8  2015年1-11月广东省科研机构专利授权前五名

        ////表9  2015年1-11月广东省地级以上市电子申请率排名统计表


        //#endregion

        public void SetListsFromDT(DataTable dt, List<string> listRowheader, List<string> listColumnheader, List<List<double>> listData, string sRow1 = "Num", string sRow2 = "rate")
        {
            listColumnheader.AddRange(new string[] { "数量", "增长率" });
            double dCount = 0;
            double dRate = 0;
            DataRow row = null;
            for (int i = 1; i <= CRBIConst.const_EndMonth; i++)
            {
                listRowheader.Add(ConvertIntToMonthStr(i));
                row = dt.Select(string.Format("d_Month={0}", i)).FirstOrDefault();
                if (row == null)
                {
                    dCount = 0;
                    dRate = 0;
                }
                else
                {
                    double.TryParse(row[sRow1].ToString(), out dCount);
                    double.TryParse(row[sRow2].ToString(), out dRate);
                    dRate = Math.Round(dRate, 4);
                }
                listData.Add(new List<double> { dCount, dRate });
            }
        }
        public string ConvertIntToMonthStr(int i)
        {
            string sMonth = "";
            if (i <= 0 || i > 12) return sMonth;
            if (i < 10)
            {
                sMonth = string.Format("0{0}月", i);
            }
            else
            {
                sMonth = string.Format("{0}月", i);
            }
            return sMonth;
        }

        #region 数据转换
        public void convertJsonToPieData(ChartJson json, CRBIDocChartData chart)
        {
            //添加首列
            //chart.AddHeader(json.xAxis[0].categories);
            List<string> header = new List<string>();

            List<int> rows = new List<int>();
            //添加数据列
            for (int i = 0; i < json.series.Count; i++)
            {
                rows.Add(json.series[i].data.Count() > 0 ? json.series[i].data[0] : 0);
                header.Add(json.series[i].name);
            }
            chart.AddHeader(header);
            chart.Add(rows, "", 1);
        }
        public void convertJsonToLineData(ChartJson json, CRBIDocChartData chart)
        {
            //添加首列
            chart.AddHeader(json.xAxis[0].categories);
            var title = "";
            var index = 0;
            List<int> rows = new List<int>();
            //添加数据列
            for (int i = 0; i < json.series.Count; i++)
            {
                index = i;
                title = json.series[i].name;
                rows = json.series[i].data;
                chart.Add(rows, title, index);
            }
        }
        public void convertJsonToColumnData(ChartJson json, CRBIDocChartData chart)
        {
            //添加首列
            chart.AddHeader(json.xAxis[0].categories);
            var title = "";
            var index = 0;
            List<int> rows = new List<int>();
            //添加数据列
            for (int i = 0; i < json.series.Count; i++)
            {
                index = i;
                title = json.series[i].name;
                rows = json.series[i].data;
                chart.Add(rows, title, index);
            }
        }
        public void convertJsonToCloumnAndLineData(ChartJson json, CRBIDocChartData chart)
        {
            //添加首列
            chart.AddHeader(json.xAxis[0].categories);
            var title = "";
            var index = 0;
            List<double> rows_f = new List<double>();
            List<int> rows = new List<int>();
            //添加数据列
            for (int i = 0; i < json.series.Count / 2; i++)//
            {
                index = i;
                title = json.series[i].name;
                rows = json.series[i].data;
                chart.Add(rows, title, index);
            }
            for (int i = 0; i < json.series.Count / 2; i++)//
            {
                index = i + json.series.Count / 2;
                title = json.series[index].name;
                rows_f = json.series[i].data_f;
                chart.Add(rows_f, title, index);
            }
        }
        #endregion
    }

    //public class CRBIReportRule
    //{
    //    //GDPADocContentBase gdpaDocContentBase = new GDPADocContentBase();
    //    //#region 提供给简报的报表数据
    //    ///// <summary>
    //    ///// 广东省各类专利申请人三种专利申请情况
    //    ///// </summary>
    //    ///// <returns></returns>
    //    //public GDPADocTableData Doc_WZSQRZLSQ_ListFrm_2_4_1()
    //    //{
    //    //    DataTable dv = GDPAPatentChartBaseDataAccessor.Instance()
    //    //        .loadDataWZSQRZLSQ_ListFrm_2_4(GDPAConst.const_StartDate, GDPAConst.const_EndDate, GDPAConst.const_PatentStatus_3ZZLLX_SQ_1, GDPAConst.const_ProvinceCode);
    //    //    GDPADocTableData obj = new GDPADocTableData();
    //    //    //添加标题
    //    //    //...
    //    //    obj.ColumnHeader1 = new List<string>() { "身份类型", "发明", "实用新型", "外观设计", "合计" };

    //    //    double T_FM = 0;
    //    //    double T_SYXX = 0;
    //    //    double T_WG = 0;
    //    //    double T_rowTotal = 0;
    //    //    for (int i = 0; i < dv.Rows.Count; i++)
    //    //    {
    //    //        DataRow dr = dv.Rows[i];
    //    //        string s_ApplicanterTyperName = (string)dr["s_ApplicanterTyperName"];
    //    //        double FM = dr["FM"].ToString() != "" ? (double)dr["FM"] : 0;
    //    //        double SYXX = dr["SYXX"].ToString() != "" ? (double)dr["SYXX"] : 0;
    //    //        double WG = dr["WG"].ToString() != "" ? (double)dr["WG"] : 0;
    //    //        double rowTotal = FM + SYXX + WG;
    //    //        List<string> r = new List<string>() { s_ApplicanterTyperName, FM.ToString(), SYXX.ToString(), WG.ToString(), rowTotal.ToString() };
    //    //        obj.AddRow(r);

    //    //        //累加合计
    //    //        T_FM += FM;
    //    //        T_SYXX += SYXX;
    //    //        T_WG += WG;
    //    //        T_rowTotal += rowTotal;
    //    //    }

    //    //    List<string> Total = new List<string>() { "合计", T_FM.ToString(), T_SYXX.ToString(), T_WG.ToString(), T_rowTotal.ToString() };

    //    //    obj.AddRow(Total);

    //    //    return obj;
    //    //}
    //    ///// <summary>
    //    ///// 广东省各类专利申请人三种专利授权情况
    //    ///// </summary>
    //    ///// <returns></returns>
    //    //public GDPADocTableData Doc_WZSQRZLSQ_ListFrm_2_4_2()
    //    //{
    //    //    DataTable dv = GDPAPatentChartBaseDataAccessor.Instance()
    //    //        .loadDataWZSQRZLSQ_ListFrm_2_4(GDPAConst.const_StartDate, GDPAConst.const_EndDate, GDPAConst.const_PatentStatus_3ZZLLX_SQ_3, GDPAConst.const_ProvinceCode);
    //    //    GDPADocTableData obj = new GDPADocTableData();
    //    //    //添加标题
    //    //    //...
    //    //    obj.ColumnHeader1 = new List<string>() { "身份类型", "发明", "实用新型", "外观设计", "合计" };

    //    //    double T_FM = 0;
    //    //    double T_SYXX = 0;
    //    //    double T_WG = 0;
    //    //    double T_rowTotal = 0;
    //    //    for (int i = 0; i < dv.Rows.Count; i++)
    //    //    {
    //    //        DataRow dr = dv.Rows[i];
    //    //        string s_ApplicanterTyperName = (string)dr["s_ApplicanterTyperName"];
    //    //        double FM = dr["FM"].ToString() != "" ? (double)dr["FM"] : 0;
    //    //        double SYXX = dr["SYXX"].ToString() != "" ? (double)dr["SYXX"] : 0;
    //    //        double WG = dr["WG"].ToString() != "" ? (double)dr["WG"] : 0;
    //    //        double rowTotal = FM + SYXX + WG;
    //    //        List<string> r = new List<string>() { s_ApplicanterTyperName, FM.ToString(), SYXX.ToString(), WG.ToString(), rowTotal.ToString() };
    //    //        obj.AddRow(r);

    //    //        //累加合计
    //    //        T_FM += FM;
    //    //        T_SYXX += SYXX;
    //    //        T_WG += WG;
    //    //        T_rowTotal += rowTotal;
    //    //    }

    //    //    List<string> Total = new List<string>() { "合计", T_FM.ToString(), T_SYXX.ToString(), T_WG.ToString(), T_rowTotal.ToString() };

    //    //    obj.AddRow(Total);

    //    //    return obj;
    //    //}
    //    ///// <summary>
    //    ///// 广东省企业专利申请情况
    //    ///// </summary>
    //    ///// <returns></returns>
    //    //public GDPADocTableData Doc_WZSQRZLSQ_ListFrm_2_5()
    //    //{
    //    //    DataTable dv = GDPAPatentChartBaseDataAccessor.Instance()
    //    //        .loadDataWZSQRZLSQ_ListFrm_2_5(GDPAConst.const_StartDate, GDPAConst.const_EndDate, GDPAConst.const_PatentStatus_3ZZLLX_SQ_1, GDPAConst.const_ProvinceCode);

    //    //    GDPADocTableData obj = new GDPADocTableData();
    //    //    //添加标题
    //    //    //...
    //    //    obj.ColumnHeader1 = new List<string>() { "专利类型", "今年企业申请量", "去年企业申请量", "增长率" };
    //    //    List<string> RowHeader = new List<string>();

    //    //    double T_Year = 0;
    //    //    double T_LastYear = 0;

    //    //    for (int i = 0; i < dv.Rows.Count; i++)
    //    //    {
    //    //        DataRow dr = dv.Rows[i];
    //    //        string s_PatentTypeName = dr["s_PatentTypeName"].ToString();
    //    //        double curCount = dr["curCount"].ToString() != "" ? (double)dr["curCount"] : 0;
    //    //        double lastCount = dr["lastCount"].ToString() != "" ? (double)dr["lastCount"] : 0;
    //    //        double Rate = dr["Rate"].ToString() != "" ? (double)dr["Rate"] : 0;
    //    //        List<string> r = new List<string>() { s_PatentTypeName, curCount.ToString(), lastCount.ToString(), gdpaDocContentBase.FractionToPercent(Rate) };
    //    //        obj.AddRow(r);
    //    //        //累加合计
    //    //        T_Year += curCount;
    //    //        T_LastYear += lastCount;
    //    //    }

    //    //    List<string> Total = new List<string>() { "合计", T_Year.ToString(), T_LastYear.ToString(), gdpaDocContentBase.FractionToPercent(DoubleDivDouble(T_Year - T_LastYear, T_LastYear)) };

    //    //    obj.AddRow(Total);
    //    //    return obj;
    //    //}
    //    ///// <summary>
    //    ///// 广东省各地级以上市PCT国际专利申请情况
    //    ///// title: string.Format("{0}年{1}月广东省各地级以上市PCT国际专利申请情况表", beginYear, endYear);
    //    ///// </summary>
    //    //public GDPADocTableData Print_PCT_ListFrm_8_1()
    //    //{
    //    //    DataTable dv = GDPAPatentChartApplyDataAccessor.Instance()
    //    //        .loadDataPCT_ListFrm_8_1(GDPAConst.const_StartDate, GDPAConst.const_EndDate, GDPAConst.const_PatentStatus_3ZZLLX_SQ_1, (int)GDPAConst.ApplySource.PCT, GDPAConst.const_ProvinceCode);

    //    //    GDPADocTableData obj = new GDPADocTableData();
    //    //    //添加标题
    //    //    //...
    //    //    obj.ColumnHeader1 = new List<string>() { "地级市", "数量", "占全省比例" };

    //    //    for (int i = 0; i < dv.Rows.Count; i++)
    //    //    {
    //    //        DataRow dr = dv.Rows[i];

    //    //        string CITY_NAME = dr["CITY_NAME"].ToString();
    //    //        double f_Count = 0;
    //    //        double rate = 0;
    //    //        double.TryParse(dr["f_Count"].ToString(), out f_Count);
    //    //        double.TryParse(dr["Rate"].ToString(), out rate);

    //    //        List<string> r = new List<string>() { CITY_NAME, f_Count.ToString(), gdpaDocContentBase.FractionToPercent(rate * 0.01) };
    //    //        obj.AddRow(r);
    //    //    }
    //    //    return obj;
    //    //}
    //    ///// <summary>
    //    ///// 广东省各地级以上市有效发明专利情况
    //    ///// Title: string.Format("{0}年{1}月广东省各地级以上市有效发明专利情况表", strYear, strMonth);
    //    ///// </summary>
    //    //public GDPADocTableData Doc_YXFM_ListFrm_7_2()
    //    //{
    //    //    GDPAPatentCityBaseDataAccessor CityBaseDataAccessor = new GDPAPatentCityBaseDataAccessor();
    //    //    List<GDPAElectronicDataTable> result = CityBaseDataAccessor
    //    //        .loadDataYXFM_ListFrm_7_2(GDPAConst.const_EndDate, GDPAConst.const_ProvinceCode);

    //    //    GDPADocTableData obj = new GDPADocTableData();
    //    //    //添加标题
    //    //    //...
    //    //    obj.ColumnHeader1 = new List<string>() { "地级市", "数量", "占全省比例" };

    //    //    foreach (GDPAElectronicDataTable item in result)
    //    //    {
    //    //        string s_Area = item.s_Area;
    //    //        double n_No = item.n_No != "" ? double.Parse(item.n_No) : 0;
    //    //        double s_Rate = item.s_Rate != "" ? double.Parse(item.s_Rate) : 0;

    //    //        List<string> r = new List<string>() { s_Area, n_No.ToString(), gdpaDocContentBase.FractionToPercent(s_Rate * 0.01) };
    //    //        obj.AddRow(r);

    //    //    }
    //    //    return obj;
    //    //}

    //    ///// <summary>
    //    ///// 广东省企业专利授权前十名
    //    ///// titleStr = "{0}-{1}广东省企业专利申请前十名"; break;
    //    ///// </summary>
    //    ///// <returns></returns>
    //    //public GDPADocTableData Doc_WZSQRZLSQ_TOPX_ListFrm_4_1()
    //    //{
    //    //    DataTable dv = GDPAPatentChartApplicanterTypeDataAccessor.Instance()
    //    //        .loadDataWZSQRZLSQ_TOPX_ListFrm_4_123(GDPAConst.const_StartDate, GDPAConst.const_EndDate, GDPAConst.const_PatentStatus_3ZZLLX_SQ_3, (int)GDPAConst.ApplicantType.Enterprise, GDPAConst.const_ProvinceCode);

    //    //    GDPADocTableData obj = new GDPADocTableData();
    //    //    //添加标题
    //    //    //...
    //    //    obj.ColumnHeader1 = new List<string>() { "排序", "单位名称", "授权量", "#", "#", "#", "城市" };
    //    //    obj.ColumnHeader2 = new List<string>() { "#", "#", "发明", "实用新型", "外观设计", "总数量", "#" };
    //    //    int iRank = 1;
    //    //    int iLastRowTotal = -1;
    //    //    for (int i = 0; i < dv.Rows.Count; i++)
    //    //    {
    //    //        DataRow dr = dv.Rows[i];
    //    //        string s_Name = dr["s_Name"].ToString();
    //    //        int FM = 0;
    //    //        int SYXX = 0;
    //    //        int WG = 0;
    //    //        Int32.TryParse(dr["FM"].ToString(), out FM);
    //    //        Int32.TryParse(dr["SYXX"].ToString(), out SYXX);
    //    //        Int32.TryParse(dr["WG"].ToString(), out WG);
    //    //        string CityName = dr["CityName"].ToString();
    //    //        int RTotal = FM + SYXX + WG;
    //    //        string CNum = "";
    //    //        if (iLastRowTotal == -1)
    //    //        {
    //    //            CNum = "1";
    //    //        }
    //    //        else
    //    //        {
    //    //            if (iLastRowTotal != RTotal)
    //    //                iRank = i + 1;
    //    //        }
    //    //        CNum = iRank.ToString();
    //    //        List<string> r = new List<string>() { CNum, s_Name, FM.ToString(), SYXX.ToString(), WG.ToString(), RTotal.ToString(), CityName };
    //    //        obj.AddRow(r);
    //    //        iLastRowTotal = RTotal;
    //    //    }
    //    //    return obj;
    //    //}
    //    ///// <summary>
    //    ///// 广东省大专院校专利授权前五名
    //    ///// </summary>
    //    ///// <returns></returns>
    //    //public GDPADocTableData Doct_WZSQRZLSQ_TOPX_ListFrm_4_2()
    //    //{
    //    //    DataTable dv = GDPAPatentChartApplicanterTypeDataAccessor.Instance()
    //    //        .loadDataWZSQRZLSQ_TOPX_ListFrm_4_123(GDPAConst.const_StartDate, GDPAConst.const_EndDate, GDPAConst.const_PatentStatus_3ZZLLX_SQ_3, (int)GDPAConst.ApplicantType.University, GDPAConst.const_ProvinceCode);

    //    //    GDPADocTableData obj = new GDPADocTableData();
    //    //    //添加标题
    //    //    //...
    //    //    obj.ColumnHeader1 = new List<string>() { "排序", "院校名称", "授权量", "#", "#", "#", "城市" };
    //    //    obj.ColumnHeader2 = new List<string>() { "#", "#", "发明", "实用新型", "外观设计", "总数量", "#" };
    //    //    int iRank = 1;
    //    //    int iLastRowTotal = -1;
    //    //    for (int i = 0; i < dv.Rows.Count; i++)
    //    //    {
    //    //        DataRow dr = dv.Rows[i];
    //    //        string s_Name = dr["s_Name"].ToString();
    //    //        int FM = 0;
    //    //        int SYXX = 0;
    //    //        int WG = 0;
    //    //        Int32.TryParse(dr["FM"].ToString(), out FM);
    //    //        Int32.TryParse(dr["SYXX"].ToString(), out SYXX);
    //    //        Int32.TryParse(dr["WG"].ToString(), out WG);
    //    //        string CityName = dr["CityName"].ToString();
    //    //        int RTotal = FM + SYXX + WG;
    //    //        string CNum = "";
    //    //        if (iLastRowTotal == -1)
    //    //        {
    //    //            CNum = "1";
    //    //        }
    //    //        else
    //    //        {
    //    //            if (iLastRowTotal != RTotal)
    //    //                iRank = i + 1;
    //    //        }
    //    //        CNum = iRank.ToString();
    //    //        List<string> r = new List<string>() { CNum, s_Name, FM.ToString(), SYXX.ToString(), WG.ToString(), RTotal.ToString(), CityName };
    //    //        obj.AddRow(r);
    //    //        iLastRowTotal = RTotal;
    //    //    }

    //    //    GDPADocTableData objTop5 = new GDPADocTableData();
    //    //    objTop5.ColumnHeader1 = new List<string>() { "排序", "院校名称", "授权量", "#", "#", "#", "城市" };
    //    //    objTop5.ColumnHeader2 = new List<string>() { "#", "#", "发明", "实用新型", "外观设计", "总数量", "#" };
    //    //    string sCurrentRank = "";
    //    //    string sLastRank = "";
    //    //    for (int i = 0; i < obj.Rows.Count; i++)
    //    //    {
    //    //        sCurrentRank = obj.Rows[i][0];
    //    //        int iCount = obj.Rows.Count;
    //    //        if (iCount < 5)
    //    //        {
    //    //            sLastRank = obj.Rows[iCount - 1][0];
    //    //        }
    //    //        else
    //    //        {
    //    //            sLastRank = obj.Rows[4][0];
    //    //        }
    //    //        if (i < 5)
    //    //        {
    //    //            List<string> r = new List<string>() { obj.Rows[i][0], obj.Rows[i][1], obj.Rows[i][2], obj.Rows[i][3], obj.Rows[i][4], obj.Rows[i][5], obj.Rows[i][6] };
    //    //            objTop5.AddRow(r);
    //    //        }
    //    //        else if (sCurrentRank == sLastRank)
    //    //        {
    //    //            List<string> r = new List<string>() { obj.Rows[i][0], obj.Rows[i][1], obj.Rows[i][2], obj.Rows[i][3], obj.Rows[i][4], obj.Rows[i][5], obj.Rows[i][6] };
    //    //            objTop5.AddRow(r);
    //    //        }
    //    //    }
    //    //    return objTop5;
    //    //}
    //    ///// <summary>
    //    ///// 广东省科研机构专利授权前五名
    //    ///// </summary>
    //    ///// <returns></returns>
    //    //public GDPADocTableData Doc_WZSQRZLSQ_TOPX_ListFrm_4_3()
    //    //{
    //    //    DataTable dv = GDPAPatentChartApplicanterTypeDataAccessor.Instance()
    //    //        .loadDataWZSQRZLSQ_TOPX_ListFrm_4_123(GDPAConst.const_StartDate, GDPAConst.const_EndDate, GDPAConst.const_PatentStatus_3ZZLLX_SQ_3, (int)GDPAConst.ApplicantType.Research, GDPAConst.const_ProvinceCode);

    //    //    GDPADocTableData obj = new GDPADocTableData();
    //    //    //添加标题
    //    //    //...
    //    //    obj.ColumnHeader1 = new List<string>() { "排序", "科研机构", "授权量", "#", "#", "#", "城市" };
    //    //    obj.ColumnHeader2 = new List<string>() { "#", "#", "发明", "实用新型", "外观设计", "总数量", "#" };
    //    //    int iRank = 1;
    //    //    int iLastRowTotal = -1;
    //    //    for (int i = 0; i < dv.Rows.Count; i++)
    //    //    {
    //    //        DataRow dr = dv.Rows[i];
    //    //        string s_Name = dr["s_Name"].ToString();
    //    //        int FM = 0;
    //    //        int SYXX = 0;
    //    //        int WG = 0;
    //    //        Int32.TryParse(dr["FM"].ToString(), out FM);
    //    //        Int32.TryParse(dr["SYXX"].ToString(), out SYXX);
    //    //        Int32.TryParse(dr["WG"].ToString(), out WG);
    //    //        string CityName = dr["CityName"].ToString();
    //    //        int RTotal = FM + SYXX + WG;
    //    //        string CNum = "";
    //    //        if (iLastRowTotal == -1)
    //    //        {
    //    //            CNum = "1";
    //    //        }
    //    //        else
    //    //        {
    //    //            if (iLastRowTotal != RTotal)
    //    //                iRank = i + 1;
    //    //        }
    //    //        CNum = iRank.ToString();
    //    //        List<string> r = new List<string>() { CNum, s_Name, FM.ToString(), SYXX.ToString(), WG.ToString(), RTotal.ToString(), CityName };
    //    //        obj.AddRow(r);
    //    //        iLastRowTotal = RTotal;
    //    //    }
    //    //    GDPADocTableData objTop5 = new GDPADocTableData();
    //    //    objTop5.ColumnHeader1 = new List<string>() { "排序", "科研机构", "授权量", "#", "#", "#", "城市" };
    //    //    objTop5.ColumnHeader2 = new List<string>() { "#", "#", "发明", "实用新型", "外观设计", "总数量", "#" };
    //    //    string sCurrentRank = "";
    //    //    string sLastRank = "";
    //    //    for (int i = 0; i < obj.Rows.Count; i++)
    //    //    {
    //    //        sCurrentRank = obj.Rows[i][0];
    //    //        int iCount = obj.Rows.Count;
    //    //        if (iCount < 5)
    //    //        {
    //    //            sLastRank = obj.Rows[iCount - 1][0];
    //    //        }
    //    //        else
    //    //        {
    //    //            sLastRank = obj.Rows[4][0];
    //    //        }
    //    //        if (i < 5)
    //    //        {
    //    //            List<string> r = new List<string>() { obj.Rows[i][0], obj.Rows[i][1], obj.Rows[i][2], obj.Rows[i][3], obj.Rows[i][4], obj.Rows[i][5], obj.Rows[i][6] };
    //    //            objTop5.AddRow(r);
    //    //        }
    //    //        else if (sCurrentRank == sLastRank)
    //    //        {
    //    //            List<string> r = new List<string>() { obj.Rows[i][0], obj.Rows[i][1], obj.Rows[i][2], obj.Rows[i][3], obj.Rows[i][4], obj.Rows[i][5], obj.Rows[i][6] };
    //    //            objTop5.AddRow(r);
    //    //        }
    //    //    }
    //    //    return objTop5;
    //    //}
    //    ///// <summary>
    //    /////E 广东省三种类型专利申请受理同比增长情况
    //    ///// </summary>
    //    //public GDPADocTableData Doc_SZZLSQ_ListFrm_1_7_1()
    //    //{
    //    //    DataTable dv = GDPAPatentChartBaseDataAccessor.Instance()
    //    //        .loadDataSZZLSQ_ListFrm_1_7(GDPAConst.const_StartDate, GDPAConst.const_EndDate, GDPAConst.const_PatentStatus_3ZZLLX_SQ_1, GDPAConst.const_ProvinceCode);
    //    //    GDPADocTableData obj = new GDPADocTableData();
    //    //    //添加标题
    //    //    //...
    //    //    obj.ColumnHeader1 = new List<string>() { "专利类型", "今年", "去年", "增长率" };

    //    //    double T_curCount = 0;
    //    //    double T_lastCount = 0;
    //    //    for (int i = 0; i < dv.Rows.Count; i++)
    //    //    {
    //    //        DataRow dr = dv.Rows[i];
    //    //        string s_PatentTypeName = (string)dr["s_PatentTypeName"];
    //    //        double curCount = dr["curCount"].ToString() != "" ? (double)dr["curCount"] : 0;
    //    //        double lastCount = dr["lastCount"].ToString() != "" ? (double)dr["lastCount"] : 0;
    //    //        double Rate = dr["Rate"].ToString() != "" ? (double)dr["Rate"] : 0;

    //    //        List<string> r = new List<string>() { s_PatentTypeName, curCount.ToString(), lastCount.ToString(), gdpaDocContentBase.FractionToPercent(Rate) };
    //    //        obj.AddRow(r);
    //    //        //累加合计
    //    //        T_curCount += curCount;
    //    //        T_lastCount += lastCount;

    //    //    }
    //    //    List<string> Total = new List<string>() { "合计", T_curCount.ToString(), T_lastCount.ToString(), gdpaDocContentBase.FractionToPercent(DoubleDivDouble((T_curCount - T_lastCount), T_lastCount)) };
    //    //    obj.AddRow(Total);
    //    //    return obj;
    //    //}

    //    //private double DoubleDivDouble(double dUp, double dDown)
    //    //{
    //    //    double dTemp = 0;
    //    //    if (dDown != 0)
    //    //    {
    //    //        dTemp = dUp / dDown;
    //    //    }
    //    //    return dTemp;
    //    //}
    //    ///// <summary>
    //    /////E 广东省三种类型专利授权同比增长情况
    //    ///// </summary>
    //    //public GDPADocTableData Doc_SZZLSQ_ListFrm_1_7_2()
    //    //{
    //    //    DataTable dv = GDPAPatentChartBaseDataAccessor.Instance()
    //    //        .loadDataSZZLSQ_ListFrm_1_7(GDPAConst.const_StartDate, GDPAConst.const_EndDate, GDPAConst.const_PatentStatus_3ZZLLX_SQ_3, GDPAConst.const_ProvinceCode);
    //    //    GDPADocTableData obj = new GDPADocTableData();
    //    //    //添加标题
    //    //    //...
    //    //    obj.ColumnHeader1 = new List<string>() { "专利类型", "今年", "去年", "增长率" };

    //    //    double T_curCount = 0;
    //    //    double T_lastCount = 0;
    //    //    for (int i = 0; i < dv.Rows.Count; i++)
    //    //    {
    //    //        DataRow dr = dv.Rows[i];
    //    //        string s_PatentTypeName = (string)dr["s_PatentTypeName"];
    //    //        double curCount = dr["curCount"].ToString() != "" ? (double)dr["curCount"] : 0;
    //    //        double lastCount = dr["lastCount"].ToString() != "" ? (double)dr["lastCount"] : 0;
    //    //        double Rate = dr["Rate"].ToString() != "" ? (double)dr["Rate"] : 0;

    //    //        List<string> r = new List<string>() { s_PatentTypeName, curCount.ToString(), lastCount.ToString(), gdpaDocContentBase.FractionToPercent(Rate) };
    //    //        obj.AddRow(r);
    //    //        //累加合计
    //    //        T_curCount += curCount;
    //    //        T_lastCount += lastCount;

    //    //    }
    //    //    List<string> Total = new List<string>() { "合计", T_curCount.ToString(), T_lastCount.ToString(), gdpaDocContentBase.FractionToPercent(DoubleDivDouble((T_curCount - T_lastCount), T_lastCount)) };
    //    //    obj.AddRow(Total);
    //    //    return obj;
    //    //}

    //    ///// <summary>
    //    ///// 广东省五种专利申请人申请专利同比增长情况
    //    ///// </summary>
    //    ///// <returns></returns>
    //    //public GDPADocTableData Doc_SZZLSQ_ListFrm_1_8()
    //    //{
    //    //    DataTable dv = GDPAPatentChartBaseDataAccessor.Instance()
    //    //        .loadDataSZZLSQ_ListFrm_1_8(GDPAConst.const_StartDate, GDPAConst.const_EndDate, GDPAConst.const_PatentStatus_3ZZLLX_SQ_1, GDPAConst.const_ProvinceCode);
    //    //    GDPADocTableData obj = new GDPADocTableData();
    //    //    //添加标题
    //    //    //...
    //    //    obj.ColumnHeader1 = new List<string>() { "身份类型", "今年", "去年", "增长率" };

    //    //    double T_curCount = 0;
    //    //    double T_lastCount = 0;
    //    //    for (int i = 0; i < dv.Rows.Count; i++)
    //    //    {
    //    //        DataRow dr = dv.Rows[i];
    //    //        string s_ApplicanterTypeName = (string)dr["s_ApplicanterTypeName"];
    //    //        double curCount = dr["curCount"].ToString() != "" ? (double)dr["curCount"] : 0;
    //    //        double lastCount = dr["lastCount"].ToString() != "" ? (double)dr["lastCount"] : 0;
    //    //        double Rate = dr["Rate"].ToString() != "" ? (double)dr["Rate"] : 0;

    //    //        List<string> r = new List<string>() { s_ApplicanterTypeName, curCount.ToString(), lastCount.ToString(), gdpaDocContentBase.FractionToPercent(Rate * 0.01) };
    //    //        obj.AddRow(r);
    //    //        //累加合计
    //    //        T_curCount += curCount;
    //    //        T_lastCount += lastCount;

    //    //    }
    //    //    List<string> Total = new List<string>() { "合计", T_curCount.ToString(), T_lastCount.ToString(), gdpaDocContentBase.FractionToPercent(DoubleDivDouble((T_curCount - T_lastCount), T_lastCount)) };
    //    //    obj.AddRow(Total);
    //    //    return obj;
    //    //}
    //    ///// <summary>
    //    ///// 年广东省地级以上市电子申请率排名统计表
    //    ///// string.Format("{0}年广东省地级以上市电子申请率排名统计表", strYear);
    //    ///// </summary>
    //    //public GDPADocTableData Doc_GDSZLSQ_PM_ListFrm_5_1()
    //    //{
    //    //    GDPAPatentCityBaseDataAccessor CityBaseDataAccessor = new GDPAPatentCityBaseDataAccessor();
    //    //    //List<GDPAElectronicDataTable> result = CityBaseDataAccessor
    //    //    //    .loadDataGDSZLSQ_PM_ListFrm_5_2(GDPAConst.const_StartDate, GDPAConst.const_EndDate, GDPAConst.const_ProvinceCode, 68);
    //    //    List<GDPAElectronicDataTable> result = CityBaseDataAccessor
    //    //        .loadDataGDSZLSQ_PM_ListFrm_5_1(GDPAConst.const_StartDate, GDPAConst.const_EndDate, GDPAConst.const_ProvinceCode);

    //    //    GDPADocTableData obj = new GDPADocTableData();

    //    //    //添加标题
    //    //    //...
    //    //    obj.ColumnHeader1 = new List<string>() { "排名", "地级市", "电子申请率" };

    //    //    foreach (GDPAElectronicDataTable item in result)
    //    //    {
    //    //        string n_No = item.n_No;
    //    //        string s_Area = item.s_Area;
    //    //        string s_Rate = item.s_Rate;
    //    //        double dTemp;
    //    //        double.TryParse(s_Rate, out dTemp);

    //    //        List<string> r = new List<string>() { n_No, s_Area, gdpaDocContentBase.FractionToPercent(dTemp * 0.01) };
    //    //        obj.AddRow(r);
    //    //    }
    //    //    return obj;
    //    //}
    //    ///// <summary>
    //    ///// 年广东省地级以上市电子申请率排名统计表(修正数据放在末尾)
    //    ///// string.Format("{0}年广东省地级以上市电子申请率排名统计表", strYear);
    //    ///// </summary>
    //    //public GDPADocTableData Doc_GDSZLSQ_PM_ListFrm_5_3()
    //    //{
    //    //    GDPAPatentCityBaseDataAccessor CityBaseDataAccessor = new GDPAPatentCityBaseDataAccessor();
    //    //    List<GDPAElectronicDataTable> result = CityBaseDataAccessor
    //    //        .loadDataGDSZLSQ_PM_ListFrm_5_3(GDPAConst.const_StartDate, GDPAConst.const_EndDate, GDPAConst.const_ProvinceCode);

    //    //    GDPADocTableData obj = new GDPADocTableData();

    //    //    //添加标题
    //    //    //...
    //    //    obj.ColumnHeader1 = new List<string>() { "排名", "地级市", "电子申请率" };

    //    //    int iRank = 1;
    //    //    string sLastRowRate = "-1";
    //    //    for (int i = 0; i < result.Count; i++)
    //    //    {
    //    //        string n_No = result[i].n_No;
    //    //        string s_Area = result[i].s_Area;
    //    //        string s_Rate = result[i].s_Rate;
    //    //        double dTemp;
    //    //        double.TryParse(s_Rate, out dTemp);
    //    //        string sCNum = "";
    //    //        if (sLastRowRate == "-1")
    //    //        {
    //    //            sCNum = "1";
    //    //        }
    //    //        else
    //    //        {
    //    //            if (sLastRowRate != s_Rate)
    //    //                iRank = i + 1;
    //    //        }
    //    //        sCNum = iRank.ToString();

    //    //        List<string> r = new List<string>() { sCNum, s_Area, gdpaDocContentBase.FractionToPercent(dTemp * 0.01) };
    //    //        obj.AddRow(r);
    //    //        sLastRowRate = s_Rate;
    //    //    }
    //    //    return obj;
    //    //}
    //    //#endregion
    //}





}

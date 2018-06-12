using CRBIReportLib.DataAccessors;
using CRBIReportLib.ReportBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRBIReportLib.ReportData
{
    public class CRBIChargeReportData_1:CRBIBasicData
    {
        #region 单例
        private static CRBIChargeReportData_1 _project;
        private CRBIChargeReportData_1()
        { }
        public static CRBIChargeReportData_1 Intance()
        {
            if (_project == null)
                _project = new CRBIChargeReportData_1();
            return _project;
        }
        #endregion

        #region 报表接口
        public CRBIDocTableData LoadContent_1_0()
        {
            DataTable dv = new DataTable(); //CRBITBL_TestDataAccessor.Instance().GetChargeTestData().loadDataWZSQRZLSQ_ListFrm_2_4(GDPAConst.const_StartDate, GDPAConst.const_EndDate, GDPAConst.const_PatentStatus_3ZZLLX_SQ_1, GDPAConst.const_ProvinceCode);
            CRBIDocTableData obj = new CRBIDocTableData();
            //添加标题
            //...
            obj.ColumnHeader1 = new List<string>() { "节号", "开始电压(V)", "结束电压（V）", "结论", "维护方案" };
            var startV = 1.000;
            var endV = 2.001;
            var result = "--";
            var plan = "优化";
            for (int i = 1; i < 25; i++)
            {
                startV = startV + i / 10;
                endV = startV - i;

                List<string> r = new List<string>() { i.ToString(), startV.ToString(), endV.ToString(), result, plan };
                obj.AddRow(r);
            }
            return obj;
            CRBIDocTableData data = new CRBIDocTableData();

            return data;
        }
        public CRBIDocTableData LoadContent_2_0()
        {
            DataTable dv = new DataTable(); //CRBITBL_TestDataAccessor.Instance().GetChargeTestData()
            //.loadDataWZSQRZLSQ_ListFrm_2_4(GDPAConst.const_StartDate, GDPAConst.const_EndDate, GDPAConst.const_PatentStatus_3ZZLLX_SQ_1, GDPAConst.const_ProvinceCode);
            CRBIDocTableData obj = new CRBIDocTableData();
            //添加标题
            //...
            obj.ColumnHeader1 = new List<string>() { "节号", "开始电压(V)", "结束电压（V）", "结论", "维护方案" };
            var startV = 1.000;
            var endV = 2.001;
            var result = "--";
            var plan = "优化";
            for (int i = 1; i < 25; i++)
            {
                startV = startV + i / 10;
                endV = startV - i;

                List<string> r = new List<string>() { i.ToString(), startV.ToString(), endV.ToString(), result, plan };
                obj.AddRow(r);
            }
            return obj;
            CRBIDocTableData data = new CRBIDocTableData();

            return data;
        }
        public CRBIDocTableData LoadContent_3_0()
        {
            DataTable dv = new DataTable(); //CRBITBL_TestDataAccessor.Instance().GetChargeTestData()
            //.loadDataWZSQRZLSQ_ListFrm_2_4(GDPAConst.const_StartDate, GDPAConst.const_EndDate, GDPAConst.const_PatentStatus_3ZZLLX_SQ_1, GDPAConst.const_ProvinceCode);
            CRBIDocTableData obj = new CRBIDocTableData();
            //添加标题
            //...
            obj.ColumnHeader1 = new List<string>() { "节号", "开始电压(V)", "结束电压（V）", "结论", "维护方案" };
            var startV = 1.000;
            var endV = 2.001;
            var result = "--";
            var plan = "优化";
            for (int i = 1; i < 25; i++)
            {
                startV = startV + i / 10;
                endV = startV - i;

                List<string> r = new List<string>() { i.ToString(), startV.ToString(), endV.ToString(), result, plan };
                obj.AddRow(r);
            }
            return obj;
            CRBIDocTableData data = new CRBIDocTableData();

            return data;
        }
        public CRBIDocTableData LoadContent_5_1()
        {
            

            DataTable dv = new DataTable(); //CRBITBL_TestDataAccessor.Instance().GetChargeTestData()
    //.loadDataWZSQRZLSQ_ListFrm_2_4(GDPAConst.const_StartDate, GDPAConst.const_EndDate, GDPAConst.const_PatentStatus_3ZZLLX_SQ_1, GDPAConst.const_ProvinceCode);
            CRBIDocTableData obj = new CRBIDocTableData();
            //添加标题
            //...
            obj.ColumnHeader1 = new List<string>() { "节号", "开始电压(V)", "结束电压（V）", "结论", "维护方案" };
            var startV = 1.000;
            var endV = 2.001;
            var result = "--";
            var plan = "优化";
            for (int i = 1; i < 25; i++)
            {
                startV = startV + i/10;
                endV = startV - i;

                List<string> r = new List<string>() { i.ToString(), startV.ToString(), endV.ToString(), result, plan };
                obj.AddRow(r);
            }
            return obj;
            CRBIDocTableData data = new CRBIDocTableData();

            return data;
        }
        public CRBIDocChartData LoadContent_4_1()
        {
            CRBIDocChartData data = new CRBIDocChartData();
        
            ChartJson json = new ChartJson();
            //json.chart = true;
            //json.charttype = "line";
            //json.xAxis.Add(new xAxisItemJson() { categories = new List<string>() { "直接访问", "邮件营销", "联盟广告", "视频广告", "搜索引擎" }, crosshair = true });
            
            //json.series.Add(new SeriesItemJson("访问来源"));// { data = new List<int>() { 15,17,19 }, data_f = new List<double>() { 15.0,17.0,19.0 } });
            ////json.series.Add(new SeriesItemJson("降水量"));// { data = new List<int>() { 15, 21, 36 }, data_f = new List<double>() { 15.0, 21.0, 36.0 } });
            //json.series[0].data.Add(330);
            //json.series[0].data.Add(334);
            //json.series[0].data.Add(530);
            //json.series[0].data.Add(300);
            //json.series[0].data.Add(377);

            //convertJsonToPieData(json, data);

            data = new CRBIDocChartData("pie");
            data.Columns.Add(new CRBIDocChartData.CRBIDocChartDataItem(new List<int>() { 30 }, "直接访问", 1));
            data.Columns.Add(new CRBIDocChartData.CRBIDocChartDataItem(new List<int>() { 40 }, "邮件营销", 2));
            data.Columns.Add(new CRBIDocChartData.CRBIDocChartDataItem(new List<int>() { 30 }, "联盟广告", 3));
          
            data.AddHeader(new List<string>() { "直接访问"});
            return data;
        }
        public CRBIDocChartData LoadContent_4_2()
        {
            CRBIDocChartData data = new CRBIDocChartData();
            //data.AddHeader(new List<string>() { "s", "a", "s" });
            //data.ChartCode = "";
            //data.ChartType = "pie";
            //data.Columns.Add(new CRBIDocChartData.CRBIDocChartDataItem(new List<double>() { 24.0, 26.0, 50.0 }, "rt", 0));
            //data.HeaderColumns.Add("sa");

           ChartJson json = new ChartJson();
            json.chart = true;
            json.charttype = "";
            json.xAxis.Add(new xAxisItemJson() { categories = new List<string>() { "甘肃", "陕西", "山西" }, crosshair = true });
            json.series.Add(new SeriesItemJson("蒸发量"));// { data = new List<int>() { 15,17,19 }, data_f = new List<double>() { 15.0,17.0,19.0 } });
            json.series.Add(new SeriesItemJson("降水量"));// { data = new List<int>() { 15, 21, 36 }, data_f = new List<double>() { 15.0, 21.0, 36.0 } });
            for(int i=0;i<3;i++)
            {
                json.series[0].data.Add(i + 1);
                json.series[1].data.Add(i + 2);
                json.series[0].data_f.Add(i + 1.1);
                json.series[1].data_f.Add(i + 2.2);
            }
            
            
            convertJsonToPieData(json, data);

            return data;
        }
        public CRBIDocChartData LoadContent_4_3()
        {
            CRBIDocChartData data = new CRBIDocChartData();
            //data.AddHeader(new List<string>() { "s", "a", "s" });
            //data.ChartCode = "";
            //data.ChartType = "pie";
            //data.Columns.Add(new CRBIDocChartData.CRBIDocChartDataItem(new List<double>() { 24.0, 26.0, 50.0 }, "rt", 0));
            //data.HeaderColumns.Add("sa");

            ChartJson json = new ChartJson();
            json.chart = true;
            json.charttype = "bar";
            json.series = new List<SeriesItemJson>();
            json.series.Add(new SeriesItemJson("蒸发量") { data = new List<int>() { 15,17,19 }, data_f = new List<double>() { 15.0,17.0,19.0 } });
            json.series.Add(new SeriesItemJson("降水量") { data = new List<int>() { 15, 21, 36 }, data_f = new List<double>() { 15.0, 21.0, 36.0 } });

            json.xAxis = new List<xAxisItemJson>();
            json.xAxis.Add(new xAxisItemJson() { categories = new List<string>() { "aa", "bb", "cc" }, crosshair = true });
            convertJsonToPieData(json, data);
            return data;
        }
        #endregion

        #region 一、查询设备信息
        
        /// <summary>
        /// 一、查询设备信息
        /// </summary>
        public CRBICharge_BatEquipmentInfoContent LoadContent_1_0_BatEquipmentInfo()
        {
            CRBICharge_BatEquipmentInfoContent data = new CRBICharge_BatEquipmentInfoContent();
            data.s_C0_DCXH = "CR-JF0001";
            data.s_C1_SCCJ = "柯蓝";
            data.s_C10_BCRL = "1000";
            data.s_C11_DJPX = "正序";
            data.s_C2_ANRQ = DateTime.Now.ToString("yyyy-mm-dd");
            data.s_C3_SCGY = "----";
            data.s_C4_JFMC = "草堂机房";
            data.s_C5_DCZH = "4#";
            data.s_C6_ZZLX = "24V";
            data.s_C7_DTLX = "2V";
            data.s_C8_DCZS = "4组";
            data.s_C9_MZJS = "12节";
            
            return data;
        }
        #endregion

        #region 二、查询电池组信息
        /// <summary>
        /// 二、查询电池组信息
        /// </summary>
        public CRBICharge_BatteryPackInfoContent LoadContent_2_0_BatteryPackInfo()
        {
            CRBICharge_BatteryPackInfoContent data = new CRBICharge_BatteryPackInfoContent();
            data.s_C12_JCDY = "2";
            data.s_C13_FCDY = "0.8";
            data.s_C14_CDSJ = "60(分钟)";
            data.s_C15_CDDL = "10A";
            data.s_C16_DDDYX = "2.8";
            data.s_C17_CRRLX = "1000";
            
            return data;
        }
        #endregion

        #region 三、查询充电电池参数信息
        /// <summary>
        /// 三、查询充电电池参数信息
        /// </summary>
        public CRBICharge_BatteryParameterContent LoadContent_3_0_BatteryParameter()
        {
            CRBICharge_BatteryParameterContent data = new CRBICharge_BatteryParameterContent();
            data.s_C18_HJWD = "23.6";
            data.s_C19_CSKSSJ = "2017-4-1 15:00:00";
            data.s_C20_ZZYY = "结束";
            data.s_C21_HJSD = "15.9";
            data.s_C22_CCCXSJ = "48（分钟）";
            
            return data;
        }
        #endregion

        #region 四、查询电池组测试信息
       
        /// <summary>
        /// 测试结论
        /// </summary>
        /// <returns></returns>
        public CRBI_C31_CSJLChart LoadContent_4_1_C31_CSJLChart()
        {
            CRBI_C31_CSJLChart data = new CRBI_C31_CSJLChart();
            
            return data;
        }
        /// <summary>
        /// 电压曲线
        /// </summary>
        /// <returns></returns>
        public CRBI_C32_DYQXChart LoadContent_4_2_C32_DYQXChart()
        {
            CRBI_C32_DYQXChart data = new CRBI_C32_DYQXChart();
            return data;
        }
        /// <summary>
        /// 电流曲线
        /// </summary>
        /// <returns></returns>
        public CRBI_C33_DLQXChart LoadContent_4_3_C33_DLQXChart()
        {
            CRBI_C33_DLQXChart data = new CRBI_C33_DLQXChart();
            return data;
        }
      
        #endregion

        #region 五、查询电池组测试结论
  
        /// <summary>
        /// 结论与方案 表格
        /// </summary>
        public CRBI_C23_JLFATable LoadContent_5_1_C23_JLFATable()
        {
            CRBI_C23_JLFATable data = new CRBI_C23_JLFATable();
            
            return data;
        }
        
        #endregion
        

       
    }
}

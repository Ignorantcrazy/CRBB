using CRBIReportLib.ReportBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRBIReportLib.ReportData
{
    public class CRBIDisChargeReportData_1 : CRBIBasicData
    {
        #region 单例
        private static CRBIDisChargeReportData_1 _project;
        private CRBIDisChargeReportData_1()
        { }
        public static CRBIDisChargeReportData_1 Intance()
        {
            if (_project == null)
                _project = new CRBIDisChargeReportData_1();
            return _project;
        }
        #endregion

        #region 报表接口
        public CRBIDocTableData LoadContent_1_0()
        {
            CRBIDocTableData data = new CRBIDocTableData();

            return data;
        }
        public CRBIDocTableData LoadContent_2_0()
        {
            CRBIDocTableData data = new CRBIDocTableData();

            return data;
        }
        public CRBIDocTableData LoadContent_3_0()
        {
            CRBIDocTableData data = new CRBIDocTableData();

            return data;
        }
        public CRBIDocTableData LoadContent_5_1()
        {
            CRBIDocTableData data = new CRBIDocTableData();

            return data;

            //        DataTable dv = GDPAPatentChartBaseDataAccessor.Instance()
            //.loadDataWZSQRZLSQ_ListFrm_2_4(GDPAConst.const_StartDate, GDPAConst.const_EndDate, GDPAConst.const_PatentStatus_3ZZLLX_SQ_1, GDPAConst.const_ProvinceCode);
            //        CRBIDocTableData obj = new CRBIDocTableData();
            //        //添加标题
            //        //...
            //        obj.ColumnHeader1 = new List<string>() { "身份类型", "发明", "实用新型", "外观设计", "合计" };

            //        double T_FM = 0;
            //        double T_SYXX = 0;
            //        double T_WG = 0;
            //        double T_rowTotal = 0;
            //        for (int i = 0; i < dv.Rows.Count; i++)
            //        {
            //            DataRow dr = dv.Rows[i];
            //            string s_ApplicanterTyperName = (string)dr["s_ApplicanterTyperName"];
            //            double FM = dr["FM"].ToString() != "" ? (double)dr["FM"] : 0;
            //            double SYXX = dr["SYXX"].ToString() != "" ? (double)dr["SYXX"] : 0;
            //            double WG = dr["WG"].ToString() != "" ? (double)dr["WG"] : 0;
            //            double rowTotal = FM + SYXX + WG;
            //            List<string> r = new List<string>() { s_ApplicanterTyperName, FM.ToString(), SYXX.ToString(), WG.ToString(), rowTotal.ToString() };
            //            obj.AddRow(r);

            //            //累加合计
            //            T_FM += FM;
            //            T_SYXX += SYXX;
            //            T_WG += WG;
            //            T_rowTotal += rowTotal;
            //        }

            //        List<string> Total = new List<string>() { "合计", T_FM.ToString(), T_SYXX.ToString(), T_WG.ToString(), T_rowTotal.ToString() };

            //        obj.AddRow(Total);

            //        return obj;
        }
        public CRBIDocChartData LoadContent_4_1()
        {
            CRBIDocChartData data = new CRBIDocChartData();

            return data;
        }
        public CRBIDocChartData LoadContent_4_2()
        {
            CRBIDocChartData data = new CRBIDocChartData();

            return data;
        }
        public CRBIDocChartData LoadContent_4_3()
        {
            CRBIDocChartData data = new CRBIDocChartData();

            return data;
        }
        #endregion


        #region 一、查询设备信息
        /// <summary>
        /// 一、查询设备信息
        /// </summary>
        public CRBIDisCharge_BatEquipmentInfoContent LoadContent_1_0_BatEquipmentInfo()
        {
            CRBIDisCharge_BatEquipmentInfoContent data = new CRBIDisCharge_BatEquipmentInfoContent();
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
        public CRBIDisCharge_BatteryPackInfoContent LoadContent_2_0_BatteryPackInfo()
        {
            CRBIDisCharge_BatteryPackInfoContent data = new CRBIDisCharge_BatteryPackInfoContent();//GetBetteryInfo
            return data;
        }
        #endregion

        #region 三、查询充电电池参数信息
        /// <summary>
        /// 三、查询充电电池参数信息
        /// </summary>
        public CRBIDisCharge_BatteryParameterContent LoadContent_3_0_BatteryParameter()
        {
            CRBIDisCharge_BatteryParameterContent data = new CRBIDisCharge_BatteryParameterContent();

            return data;
        }
        #endregion

        #region 四、查询电池组测试信息

        /// <summary>
        /// 测试结论饼图
        /// </summary>
        /// <returns></returns>
        public CRBI_C31_CSJLChart LoadContent_4_1_C31_CSJLChart()
        {
            CRBI_C31_CSJLChart data = new CRBI_C31_CSJLChart();//
            return data;
        }
        /// <summary>
        /// 电压曲线
        /// </summary>
        /// <returns></returns>
        public CRBI_C32_DYQXChart LoadContent_4_2_C32_DYQXChart()
        {
            CRBI_C32_DYQXChart data = new CRBI_C32_DYQXChart();//
            return data;
        }
        /// <summary>
        /// 电流曲线
        /// </summary>
        /// <returns></returns>
        public CRBI_C33_DLQXChart LoadContent_4_3_C33_DLQXChart()
        {
            CRBI_C33_DLQXChart data = new CRBI_C33_DLQXChart();//
            return data;
        }

        #endregion

        #region 五、查询电池组测试结论
       
        /// <summary>
        /// 结论与方案 表格
        /// </summary>
        public CRBI_C23_JLFATable LoadContent_5_1_C23_JLFATable()
        {
            CRBI_C23_JLFATable data = new CRBI_C23_JLFATable();//
            return data;
        }

        #endregion



    }
}

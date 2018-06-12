using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRBIReportLib.ReportData
{
    public class CRBIChargeData
    {
        public CRBIChargeData()
        {
            chargeContent = new CRBIChargeContent();
            c23_JLFATable = new CRBI_C23_JLFATable();
            c33_DLQXChart = new CRBI_C33_DLQXChart();
            c32_DYQXChart = new CRBI_C32_DYQXChart();
            c31_CDQXChart = new CRBI_C31_CSJLChart();
            //c34_NZZZChart = new CRBI_C34_NZZZChart();
        }
        /// <summary>
        /// 基本信息
        /// </summary>
        public CRBIChargeContent chargeContent;
        /// <summary>
        /// 结论与方案
        /// </summary>
        public CRBI_C23_JLFATable c23_JLFATable;
        /// <summary>
        /// 电流曲线
        /// </summary>
        public CRBI_C33_DLQXChart c33_DLQXChart;
        /// <summary>
        /// 电压曲线
        /// </summary>
        public CRBI_C32_DYQXChart c32_DYQXChart;
        /// <summary>
        /// 测试结论饼图
        /// </summary>
        public CRBI_C31_CSJLChart c31_CDQXChart;
        //public CRBI_C34_NZZZChart c34_NZZZChart;
       
      
    }

    
}

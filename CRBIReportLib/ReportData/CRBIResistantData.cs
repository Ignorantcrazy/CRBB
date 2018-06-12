using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRBIReportLib.ReportData
{
    public class CRBIResistantData
    {
        public CRBIResistantData()
        {
            chargeContent = new CRBIResistantContent();
            c23_JLFATable = new CRBI_C23_JLFATable();
            //c33_DLQXChart = new CRBI_C33_DLQXChart();
            //c32_DYQXChart = new CRBI_C32_DYQXChart();
            c31_csjlChart = new CRBI_C31_CSJLChart();
            c34_NZZZChart = new CRBI_C34_NZZZChart();
        }
        /// <summary>
        /// 基本信息
        /// </summary>
        public CRBIResistantContent chargeContent;
        /// <summary>
        /// 结论与方案
        /// </summary>
        public CRBI_C23_JLFATable c23_JLFATable;
        /// <summary>
        /// 内阻柱状图
        /// </summary>
        public CRBI_C34_NZZZChart c34_NZZZChart;
        ///// <summary>
        ///// 电流曲线
        ///// </summary>
        //CRBI_C33_DLQXChart c33_DLQXChart;
        ///// <summary>
        ///// 电压曲线
        ///// </summary>
        //CRBI_C32_DYQXChart c32_DYQXChart;
        /// <summary>
        /// 测试结论曲线
        /// </summary>
        CRBI_C31_CSJLChart c31_csjlChart;

    }
}

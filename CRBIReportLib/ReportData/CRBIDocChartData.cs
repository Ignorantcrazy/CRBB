using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRBIReportLib.ReportData
{
    public class CRBIDocChartData
    {
        public string ChartCode { get; set; }
        public string ChartType { get; set; }
        public List<CRBIDocChartDataItem> Columns = new List<CRBIDocChartDataItem>();
        public List<string> HeaderColumns = new List<string>();
        public class CRBIDocChartDataItem
        {
            public List<double> Rows { get; set; }
            public string ColTitle { get; set; }
            public int ColIndex { get; set; }
            public CRBIDocChartDataItem(List<double> rows, string title, int colIndex)
            {
                Rows = new List<double>();
                ColTitle = title;
                ColIndex = colIndex;
                Rows.AddRange(rows.ToArray());
            }
            public CRBIDocChartDataItem(List<int> rows, string title, int colIndex)
            {
                Rows = new List<double>();
                ColTitle = title;
                ColIndex = colIndex;
                for (int i = 0; i < rows.Count; i++)
                {
                    Rows.Add(Convert.ToDouble(rows[i]));
                }
            }
        }
        public CRBIDocChartData(string charttype)
        {
            ChartType = charttype;
        }
        public CRBIDocChartData()
        { }
        public void Add(List<int> rows, string title, int colIndex)
        {
            this.Columns.Add(new CRBIDocChartDataItem(rows, title, colIndex) { });
        }
        public void Add(List<double> rows, string title, int colIndex)
        {
            this.Columns.Add(new CRBIDocChartDataItem(rows, title, colIndex) { });
        }
        public void AddHeader(List<string> headers)
        {
            this.HeaderColumns.AddRange(headers.ToArray());
        }
    }

    /// <summary>
    /// 电流曲线
    /// </summary>
    public class CRBI_C33_DLQXChart:CRBIDocChartData
    {
    
    }
    /// <summary>
    /// 电压曲线
    /// </summary>
    public class CRBI_C32_DYQXChart:CRBIDocChartData
    {
    
    }
    /// <summary>
    /// 测试结论
    /// </summary>
    public class CRBI_C31_CSJLChart : CRBIDocChartData
    {

    }
    /// <summary>
    /// 内阻柱状图
    /// </summary>
    public class CRBI_C34_NZZZChart : CRBIDocChartData
    {

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRBIReportLib.ReportData
{
    
    public class CRBIDocTableData
    {
        public string MARK = "#";

        private List<string> _ColumnHeader1 = new List<string>();
        private List<string> _ColumnHeader2 = new List<string>();
        private List<List<string>> _ColumnHeaders = new List<List<string>>();
        private List<List<string>> _rows = new List<List<string>>();
        /// <summary>
        /// 列标题，在添加数据前首先设置行、列标题
        /// </summary>
        public List<string> ColumnHeader1
        {
            set
            {
                _ColumnHeader1 = value;
                ColumnHeaders.Add(value);
            }
        }
        /// <summary>
        /// 列标题2，设置前应先为ColumnHeader1赋值，如果表头只有一行，则不必设置
        /// </summary>
        public List<string> ColumnHeader2
        {
            set
            {
                if (_ColumnHeader1.Count <= 0) throw new Exception("请先为ColumnHeader1赋值");
                if (value.Count != _ColumnHeader1.Count) throw new Exception("请保证ColumnHeader2与ColumnHeader1的列数一致");
                _ColumnHeader2 = value;
                ColumnHeaders.Add(value);
            }
        }
        /// <summary>
        /// 列标题（最多支持两个标题行合并单元格的情况）
        /// </summary>
        public List<List<string>> ColumnHeaders { get { return _ColumnHeaders; } }
        /// <summary>
        /// 数据
        /// </summary>
        public List<List<string>> Rows { get { return _rows; } }
        /// <summary>
        /// 添加一行数据
        /// </summary>
        /// <param name="listRow"></param>           
        public void AddRow(List<string> listRow)
        {
            _rows.Add(listRow);
        }
    }
    
    /// <summary>
    /// 结论和方案
    /// </summary>
    public class CRBI_C23_JLFATable : CRBIDocTableData
    {
       
    }
}

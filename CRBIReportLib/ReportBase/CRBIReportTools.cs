using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CRBIReportLib.ReportBase
{
    public class CRBIReportTools
    {
        /// <summary>
        /// 将类似“20120202”格式的日期字符串转换为DateTime类型
        /// </summary>
        /// <param name="sdate">日期字符串，格式:“20120202”</param>
        /// <returns></returns>
        public static DateTime StrToDateTime(string sdate)
        {
            Regex reg = new Regex("^([1-2][0-9]{3})([0-1][0-9])([0-3][0-9])$");
            if (reg.IsMatch(sdate))
            {
                Match match = reg.Match(sdate);
                string sYear = match.Groups[1].ToString();
                string sMonth = match.Groups[2].ToString();
                string sDay = match.Groups[3].ToString();
                return Convert.ToDateTime(sYear + "-" + sMonth + "-" + sDay);
            }
            else
            {
                return DateTime.Now.AddYears(-1000);
            }
        }

        /// <summary>
        /// 获取单元格的值并转换为String类型
        /// </summary>
        /// <param name="cell">ICell</param>
        /// <returns>将单元格转换为string的值</returns>
        public static string GetStrCellValue(ICell cell)
        {
            if (cell == null) return "";
            switch (cell.CellType)
            {
                case CellType.String:
                    return cell.StringCellValue;
                case CellType.Numeric:
                    return cell.NumericCellValue.ToString();
                default:
                    throw new Exception();
            }
        }
    }

}
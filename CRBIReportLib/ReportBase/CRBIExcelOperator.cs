using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRBIReportLib.ReportBase
{
    public class CRBIExcelOperator
    {
        #region Read
        private static int _iTotalRead;
        /// <summary>
        /// Excel总行数
        /// </summary>
        public static int ITotalRead
        {
            get { return CRBIExcelOperator._iTotalRead; }
            set { CRBIExcelOperator._iTotalRead = value; }
        }

        private static int _iCurrentRead;
        /// <summary>
        /// 当前处理位置
        /// </summary>
        public static int ICurrentRead
        {
            get { return CRBIExcelOperator._iCurrentRead; }
            set { CRBIExcelOperator._iCurrentRead = value; }
        }
        /// <summary>
        /// excel原始地址所在的列，由程序识别或用户指定，暂时默认为4，与“广东申请.xls”对应
        /// </summary>
        private static int _iAddrColumn = 4;

        public static int IAddrColumn
        {
            get { return CRBIExcelOperator._iAddrColumn; }
            set { CRBIExcelOperator._iAddrColumn = value; }
        }

        private static FileStream fsReader = null;
        private static IWorkbook workBookForRead = null;
        private static ISheet sheetForRead = null;

        /// <summary>
        /// 加载指定路径的EXCEL
        /// </summary>
        /// <param name="sPath"></param>
        public static bool LoadExcelForRead(string sPath)
        {
            try
            {
                fsReader = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            }
            catch
            {
                DisposeFsReader();
                return false;
            }
            workBookForRead = WorkbookFactory.Create(fsReader);
            sheetForRead = workBookForRead.GetSheetAt(0);
            _iTotalRead = sheetForRead.LastRowNum;
            _iCurrentRead = 0;
            return true;
        }

        /// <summary>
        /// 销毁fsReader
        /// </summary>
        public static void DisposeFsReader()
        {
            if (fsReader != null)
            {
                fsReader.Dispose();
            }
        }

        /// <summary>
        /// 获取_ICurrent的下一行的地址内容
        /// </summary>
        /// <returns></returns>
        public static string GetAddr()
        {
            _iCurrentRead++;
            IRow row = sheetForRead.GetRow(_iCurrentRead);
            if (row == null) return null;
            return row.GetCell(_iAddrColumn).ToString();
        }

        public static IRow GetNextRow()
        {
            _iCurrentRead++;
            IRow row = sheetForRead.GetRow(_iCurrentRead);
            return row;
        }

        public static DataTable GetTableHead()
        {
            DataTable dtTableHead = new DataTable();
            dtTableHead.Columns.Add("TableHead", Type.GetType("System.String"));       //表头列
            IRow row = sheetForRead.GetRow(0);    //获取第一行表头
            int iColumnCount = row.LastCellNum;
            dtTableHead.Rows.Add(new object[] { string.Empty });
            for (int i = 0; i < iColumnCount; i++)
            {
                dtTableHead.Rows.Add(new object[] { row.GetCell(i).ToString() });
            }

            return dtTableHead;
        }
        #endregion

        #region Write
        private static FileStream fsWriter = null;
        private static IWorkbook workBookForWrite = null;
        private static ISheet succeedSheetForWrite = null;     //此页记录清洗成功的结果
        private static ISheet failedSheetForWrite = null;     //此页保存清洗失败的记录
        private static int iIndexForSucceedSheet = 0;
        private static int iIndexForFailedSheet = 0;

        /// <summary>
        /// 加载指定路径的EXCEL
        /// </summary>
        /// <param name="sPath"></param>
        public static void CreatExcelForWrite()
        {
            workBookForWrite = new HSSFWorkbook();
            succeedSheetForWrite = workBookForWrite.CreateSheet("清洗成功");
            failedSheetForWrite = workBookForWrite.CreateSheet("清洗失败");
            string sPath = DateTime.Now.Month.ToString() + "-" +
                                    DateTime.Now.Day.ToString() + " " +
                                    DateTime.Now.Hour.ToString() + "-" +
                                    DateTime.Now.Minute.ToString() + "-" +
                                    DateTime.Now.Second.ToString();
            fsWriter = File.OpenWrite(@"D:\数据\规划司\原始数据\" + sPath + ".xls");
        }
        /// <summary>
        /// 加载指定路径的EXCEL
        /// </summary>
        /// <param name="sPath"></param>
        public static void CreatExcelForWrite(string sSavePath)
        {
            workBookForWrite = new HSSFWorkbook();
            succeedSheetForWrite = workBookForWrite.CreateSheet("清洗成功");
            failedSheetForWrite = workBookForWrite.CreateSheet("清洗失败");
            //
            //创建表头
            IRow row = null;
            row = succeedSheetForWrite.CreateRow(0);
            SetTableHead(row);
            row = failedSheetForWrite.CreateRow(0);
            SetTableHead(row);
            //
            fsWriter = File.OpenWrite(sSavePath);
        }
        /// <summary>
        /// 销毁fsReader
        /// </summary>
        public static void DisposeFsWriter()
        {
            if (fsWriter != null)
            {
                fsWriter.Dispose();
            }
        }
        /// <summary>
        /// 将单条清洗结果保存到流中
        /// </summary>
        /// <param name="index"></param>
        /// <param name="list"></param>
        public static void SaveSingleResultToStream(int index, List<string> list)
        {
            IRow row = null;
            if (list[0] == "Succeed")     //保存清洗成功的记录
            {
                iIndexForSucceedSheet++;
                row = succeedSheetForWrite.CreateRow(iIndexForSucceedSheet);
            }
            else        //保存清洗失败的记录
            {
                iIndexForFailedSheet++;
                row = failedSheetForWrite.CreateRow(iIndexForFailedSheet);
            }
            /* list(0)   清洗结果：成功、失败
                * list(1)   清洗类型
                * list(2)   原始地址
                * list(3)   清洗后地址
                * list(4)   省 
                * list(5)   市
                * list(6)   区
                */

            row.CreateCell(0).SetCellValue(index.ToString());    //该数据在原数据表中所在的行号
            row.CreateCell(1).SetCellValue(list[1]);    //清洗类型
            row.CreateCell(2).SetCellValue(list[2]);    //原始地址
            row.CreateCell(3).SetCellValue(list[3]);    //清洗后地址
            row.CreateCell(4).SetCellValue(list[4]);    //省
            row.CreateCell(5).SetCellValue(list[5]);    //市
            row.CreateCell(6).SetCellValue(list[6]);    //区
            SetAutoSizeColumn(succeedSheetForWrite);
            SetAutoSizeColumn(failedSheetForWrite);
        }

        private static void SetTableHead(IRow iRow)
        {
            IRow row = iRow;
            /* list(0)   清洗结果：成功、失败
                * list(1)   清洗类型
                * list(2)   原始地址
                * list(3)   清洗后地址
                * list(4)   省 
                * list(5)   市
                * list(6)   区*/

            row.CreateCell(0).SetCellValue("行号");    //该数据在原数据表中所在的行号
            row.CreateCell(1).SetCellValue("清洗类型");    //清洗类型
            row.CreateCell(2).SetCellValue("原始地址");    //原始地址
            row.CreateCell(3).SetCellValue("清洗后地址");    //清洗后地址
            row.CreateCell(4).SetCellValue("省");    //省
            row.CreateCell(5).SetCellValue("市");    //市
            row.CreateCell(6).SetCellValue("区");    //区
        }
        /// <summary>
        /// 设置单元格宽度自适应
        /// </summary>
        /// <param name="sheet"></param>
        private static void SetAutoSizeColumn(ISheet sheet)
        {
            for (int i = 0; i <= 6; i++)
            {
                sheet.AutoSizeColumn(i);
            }
        }
        public static void SaveTotalResultToExcel()
        {
            workBookForWrite.Write(fsWriter);       //保存
            DisposeFsWriter();          //销毁写入流
            //
            //复位GDPAExcelOperator
            _iCurrentRead = 0;
            iIndexForFailedSheet = 0;
            iIndexForSucceedSheet = 0;
        }

        #endregion
    }
}
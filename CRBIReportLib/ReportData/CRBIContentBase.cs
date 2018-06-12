using CRBIReportLib.ReportBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRBIReportLib.ReportData
{
    public class CRBIDocContentBase
    {
        public int mark_0_StartYear;
        public int mark_0_EndYear;
        public int mark_0_StartMonth;
        public int mark_0_EndMonth;
        /// <summary>
        /// XXX年
        /// </summary>
        public string mark_0_XXXX_YearFormat;
        /// <summary>
        /// XXX年1-X月
        /// </summary>
        public string mark_0_XXXXY_XM_To_XM_DateFormat1;
        /// <summary>
        /// 1--X月
        /// </summary>
        public string mark_0_XM_To_XM_DateFormat2;
        /// <summary>
        /// 截止XXX年XX月
        /// </summary>
        public string mark_0_JZ_XXXXY_XM_DateFormat3;
        /// <summary>
        /// XXX年XX月
        /// </summary>
        public string mark_0_Current_XXXXY_XM_DateFormat4;
        /// <summary>
        /// XXX年XX月
        /// </summary>
        public string sNextMonthOfReportDate;
        /// <summary>
        /// XXXX年第XX期（总第XXX期）
        /// </summary>
        public string mark_0_Current_XXXXY_XM_DateFormat5;
        /// <summary>
        ///XXXX.X-XX
        /// </summary>
        public string mark_0_Current_XXXXY_XM_DateFormat6;
        /// <summary>
        /// XXX年1-6月
        /// </summary>
        public string mark_0_FirstHalfYear;
        /// <summary>
        /// XXX年7-12月
        /// </summary>
        public string mark_0_SecondHalfYear;

        public DateTime mark_0_DateTime_Now;

        public string mark_0_Previous_XXXXY_XM_DateFormat5;

        public string GetDateDescription()
        {
            return (CRBIConst.const_EndDate.Month == 1) ? mark_0_Current_XXXXY_XM_DateFormat4 : mark_0_XXXXY_XM_To_XM_DateFormat1;
        }
        /// <summary>
        /// 比全国平均水平x高n个百分点
        /// </summary>
        /// <returns></returns>
        public string CompareWithCN(double dGDValue, double dCNValue)
        {
            double dCompare = dGDValue - dCNValue;
            if (dCompare == 0)
            {
                return string.Format("与全国平均水平{0}相等", FractionToPercent(dCNValue));
            }
            return string.Format("比全国平均水平{0}{1}{2}个百分点"
                                                , FractionToPercent(dCNValue)
                                                , dCompare > 0 ? "高" : "低"
                                                , Math.Round(Math.Abs(dCompare * 100), 2));
        }
        /// <summary>
        /// 将小数转换成百分数
        /// </summary>
        /// <param name="dVal"></param>
        /// <returns></returns>
        public string FractionToPercent(double dVal)
        {
            double dTemp = Math.Round(dVal * 100, 2);
            return string.Format("{0:F2}", dTemp) + "%";
        }
        /// <summary>
        /// 同比增长/下降
        /// </summary>
        /// <param name="dval"></param>
        /// <returns></returns>
        public string GrowOrDrop(double dval)
        {
            string sTemp;
            if (dval >= 0)
            {
                sTemp = string.Format("增长{0}", FractionToPercent(Math.Abs(dval)));
            }
            else
            {
                sTemp = string.Format("下降{0}", FractionToPercent(Math.Abs(dval)));
            }
            return sTemp;
        }

        public string convertCityListToString(int num, List<string> list)
        {
            StringBuilder builder = new StringBuilder();
            int count = num - 1;
            if (num > 1)
            {
                builder.Append("（低于");
                if (num > 5)
                {
                    count = 5;
                }
                for (int i = 0; i < count; i++)
                {
                    builder.AppendFormat("{0}{1}", list[i], i < count - 1 ? "、" : "");
                }
                if (num > 5)
                {
                    builder.AppendFormat("等{0}个城市", convertToCNNum(num - 1));
                }
                builder.Append("）");
            }
            return builder.ToString();
        }

        static string[] arrNumCN = { "十", "一", "二", "三", "四", "五", "六", "七", "八", "九" };
        public string convertToCNNum(int iNum)
        {
            if (iNum <= 0 || iNum > 99) return "";
            int iShi;  //十位
            int iGe;   //个位
            iShi = iNum / 10;
            iGe = iNum % 10;
            string sNum;
            if (iShi == 0)
            {
                sNum = arrNumCN[iGe];
            }
            else if (iNum == 10)
            {
                sNum = "十";
            }
            else if (iShi == 1)
            {
                sNum = "十" + arrNumCN[iGe];
            }
            else
            {
                if (iGe == 0)
                {
                    sNum = arrNumCN[iShi] + arrNumCN[iGe];
                }
                else
                {
                    sNum = arrNumCN[iShi] + "十" + arrNumCN[iGe];
                }

            }
            return sNum;
        }
        /// <summary>
        /// 整数与整数的除法，包含非空判断
        /// </summary>
        /// <param name="iUp"></param>
        /// <param name="iDown"></param>
        /// <returns></returns>
        public double Int32DivInt32(int iUp, int iDown)
        {
            double dTemp = 0;
            if (iDown != 0)
            {
                dTemp = (double)iUp / (double)iDown;
            }
            return dTemp;
        }
        /// <summary>
        /// 排名-XXX-n件
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        public string NumDicToStr(Dictionary<string, string> dic)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var item in dic)
            {
                builder.AppendFormat("{0}{1}件"
                    , item.Key
                    , item.Value)
                    .Append("、");
            }
            return builder.ToString().TrimEnd(new char[] { '、' });
        }
        /// <summary>
        /// 排名-XXX-n件
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        public string NumDicToStr(Dictionary<string, int> dic)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var item in dic)
            {
                builder.AppendFormat("{0}{1}件"
                    , item.Key
                    , item.Value)
                    .Append("、");
            }
            return builder.ToString().TrimEnd(new char[] { '、' });
        }
        /// <summary>
        /// XXX-n家-n件
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        public string NumArrDicToStr(Dictionary<string, int[]> dic)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var item in dic)
            {
                builder.AppendFormat("{0}{1}家{2}件"
                    , item.Key
                    , item.Value[0]
                    , item.Value[1])
                    .Append("、");
            }
            return builder.ToString().TrimEnd(new char[] { '、' });
        }

        public string RatioToStr(params double[] arrRatio)
        {
            StringBuilder builder = new StringBuilder();
            double[] arrDouble = new double[arrRatio.Length];
            double dTotal = 0;
            for (int i = 0; i < arrDouble.Length - 1; i++)
            {
                arrDouble[i] = Math.Round(arrRatio[i] * 100.0, 2, MidpointRounding.AwayFromZero);
                dTotal += arrDouble[i];
            }
            if (dTotal == 0)
            {
                arrDouble[arrDouble.Length - 1] = 0;
            }
            else
            {
                arrDouble[arrDouble.Length - 1] = Math.Round(100 - dTotal, 2);
            }

            foreach (var item in arrDouble)
            {
                builder.Append(string.Format("{0:F2}", item)).Append(":");
            }
            return builder.ToString().TrimEnd(new char[] { ':' });
        }

        public string PercentDicToStr(Dictionary<string, string> dic)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var item in dic)
            {
                builder.AppendFormat("{0}{1}"
                    , item.Key
                    , item.Value)
                    .Append("、");
            }
            return builder.ToString().TrimEnd(new char[] { '、' });
        }
        /// <summary>
        /// 比2012年9月的7.11（件/万人）增加1.67件
        /// </summary>
        /// <param name="dCurrentYear"></param>
        /// <param name="dLastYear"></param>
        /// <returns></returns>
        public string CompareMillionWithLastYear(double dCurrentYear, double dLastYear)
        {
            StringBuilder builder = new StringBuilder();
            double dCompare = Math.Round(dCurrentYear - dLastYear, 2);
            string sCompare = "";
            if (dCompare == 0)
            {
                sCompare = "相等";
                builder.Append("与");
                builder.AppendFormat("{0}的{1}（件/万人）{2}"
                    , mark_0_Previous_XXXXY_XM_DateFormat5
                    , dLastYear
                    , sCompare);
            }
            else
            {
                if (dCompare > 0)
                {
                    sCompare = "增加";
                    builder.Append("比");
                }
                else
                {
                    sCompare = "减少";
                    builder.Append("比");
                }
                builder.AppendFormat("{0}的{1}（件/万人）{2}{3}件"
                , mark_0_Previous_XXXXY_XM_DateFormat5
                , dLastYear
                , sCompare
                , dCompare);
            }
            return builder.ToString();
        }
        /// <summary>
        /// 全省三种专利申请比例
        /// </summary>
        /// <returns></returns>
        public string Load_GD_SQ_1_Ratio()
        {
            //当年申请受理量
            int mark_1_GD_SQ_1_ZLLX_1_Curr_Count = 0;
            int mark_1_GD_SQ_1_ZLLX_2_Curr_Count = 0;
            int mark_1_GD_SQ_1_ZLLX_3_Curr_Count = 0;
            //专利占比
            double mark_1_GD_SQ_1_ZLLX_1_Curr_BL = 0;
            double mark_1_GD_SQ_1_ZLLX_2_Curr_BL = 0;
            double mark_1_GD_SQ_1_ZLLX_3_Curr_BL = 0;

            DataTable dv = new DataTable();// GDPAPatentChartBaseDataAccessor.Instance()
            //  .loadDataSZZLSQ_ListFrm_1_7(CRBIConst.const_StartDate, CRBIConst.const_EndDate, CRBIConst.const_PatentStatus_3ZZLLX_SQ_1, CRBIConst.const_ProvinceCode);
            DataRow[] rows = dv.Select(String.Format("n_PatentType={0}", CRBIConst.const_PatentType_FM_1));
            if (rows != null && rows.Length > 0)
            {
                Int32.TryParse(rows[0]["curCount"].ToString(), out mark_1_GD_SQ_1_ZLLX_1_Curr_Count);
            }

            rows = dv.Select(String.Format("n_PatentType={0}", CRBIConst.const_PatentType_SYXX_2));
            if (rows != null && rows.Length > 0)
            {
                Int32.TryParse(rows[0]["curCount"].ToString(), out mark_1_GD_SQ_1_ZLLX_2_Curr_Count);
            }

            rows = dv.Select(String.Format("n_PatentType={0}", CRBIConst.const_PatentType_WGSJ_3));
            if (rows != null && rows.Length > 0)
            {
                Int32.TryParse(rows[0]["curCount"].ToString(), out mark_1_GD_SQ_1_ZLLX_3_Curr_Count);
            }
            int n_Count = 0;
            n_Count = mark_1_GD_SQ_1_ZLLX_1_Curr_Count + mark_1_GD_SQ_1_ZLLX_2_Curr_Count + mark_1_GD_SQ_1_ZLLX_3_Curr_Count;
            if (n_Count > 0)
            {
                mark_1_GD_SQ_1_ZLLX_1_Curr_BL = Int32DivInt32(mark_1_GD_SQ_1_ZLLX_1_Curr_Count, n_Count);
                mark_1_GD_SQ_1_ZLLX_2_Curr_BL = Int32DivInt32(mark_1_GD_SQ_1_ZLLX_2_Curr_Count, n_Count);
                mark_1_GD_SQ_1_ZLLX_3_Curr_BL = Int32DivInt32(mark_1_GD_SQ_1_ZLLX_3_Curr_Count, n_Count);
            }
            return RatioToStr(mark_1_GD_SQ_1_ZLLX_1_Curr_BL, mark_1_GD_SQ_1_ZLLX_2_Curr_BL, mark_1_GD_SQ_1_ZLLX_3_Curr_BL);
        }
        /// <summary>
        /// 全国三种专利申请比例
        /// </summary>
        /// <returns></returns>
        public string Load_CN_SQ_1_Ratio()
        {
            //专利国内占比
            double mark_3_CN_SQ_1_ZLLX_1_BL = 0;
            double mark_3_CN_SQ_1_ZLLX_2_BL = 0;
            double mark_3_CN_SQ_1_ZLLX_3_BL = 0;
            //国内三种专利申请的比例
            // GDPASIPOEffectiveAccessor sipoAccessor = GDPASIPOEffectiveAccessor.Instance();
            DataTable tb = new DataTable();//
            DataRow[] rows = tb.Select("1=1"); // sipoAccessor.loadSIPO_Period(CRBIConst.const_StartDate, CRBIConst.const_EndDate, (int)CRBIConst.SIPOType.Apply)
            //              .Tables[0].Select("s_AreaCN='合计'");
            if (rows.Length <= 0) return "";
            int iPatent;  //发明专利
            int iUtilityModel;   //实用新型
            int iDesign;    //外观设计
            Int32.TryParse(rows[0]["n_PCount"].ToString(), out iPatent);
            Int32.TryParse(rows[0]["n_UCount"].ToString(), out iUtilityModel);
            Int32.TryParse(rows[0]["n_DCount"].ToString(), out iDesign);
            int n_Count = iPatent + iUtilityModel + iDesign;
            if (n_Count > 0)
            {
                mark_3_CN_SQ_1_ZLLX_1_BL = Int32DivInt32(iPatent, n_Count);
                mark_3_CN_SQ_1_ZLLX_2_BL = Int32DivInt32(iUtilityModel, n_Count);
                mark_3_CN_SQ_1_ZLLX_3_BL = Int32DivInt32(iDesign, n_Count);
            }
            return RatioToStr(mark_3_CN_SQ_1_ZLLX_1_BL, mark_3_CN_SQ_1_ZLLX_2_BL, mark_3_CN_SQ_1_ZLLX_3_BL);
        }
        /// <summary>
        /// 总第XXX期
        /// </summary>
        /// <returns></returns>
        private int GetTotalPeriod()
        {
            int iBaseYear = CRBIConst.dtBaseDate.Year;
            int iBaseMonth = CRBIConst.dtBaseDate.Month;
            int iResult = CRBIConst.iBasePeriod + (CRBIConst.const_EndYear - iBaseYear) * 12 + (CRBIConst.const_EndMonth - iBaseMonth);
            return iResult;
        }
        /// <summary>
        /// 记录日志
        /// </summary>
        /// <param name="e"></param>
        public void LogException(Exception e)
        {
            string sPath = CRBIConst.const_LogPath;
            string sParentDir = Directory.GetParent(sPath).ToString();
            if (!Directory.Exists(sParentDir)) Directory.CreateDirectory(sParentDir);

            if (!File.Exists(sPath)) CreateLog(sPath);
            WriteLog(sPath, e);
        }
        private void CreateLog(string sPath)
        {
            using (StreamWriter sw = File.CreateText(sPath)) { }
        }
        private void WriteLog(string sPath, Exception e)
        {
            using (StreamWriter sw = File.AppendText(sPath))
            {
                sw.WriteLine("##" + DateTime.Now.ToString() + "——" + e.Message + "。" + e.StackTrace);
            }
        }
        /// <summary>
        /// 获取dt中前iTopX名的数据，根据sValCol一列的值排序
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="iTopX"></param>
        /// <param name="sKeyCol"></param>
        /// <param name="sValCol"></param>
        /// <returns></returns>
        public Dictionary<string, int> GetTopXFromDtAsDic1(DataTable dt, int iTopX, string sKeyCol, string sValCol, string sRowFilter)
        {
            Dictionary<string, int> dicResult = new Dictionary<string, int>();
            //获取去重后的排序
            DataView dv = new DataView(dt, sRowFilter, string.Format("{0} DESC", sValCol), DataViewRowState.Unchanged);
            DataTable dtTopX = DtSelectTop(iTopX, dv.ToTable(true, sValCol));
            int[] arrTopX = new int[dtTopX.Rows.Count];
            int iTemp = 0;
            string sTemp = "";
            for (int i = 0; i < dtTopX.Rows.Count; i++)
            {
                Int32.TryParse(dtTopX.Rows[i][sValCol].ToString(), out iTemp);
                arrTopX[i] = iTemp;
            }
            //排序，将并列的情况考虑在内
            foreach (int item in arrTopX)
            {
                foreach (DataRow row in dt.Select(string.Format("{0}={1}", sValCol, item)))
                {
                    Int32.TryParse(row[sValCol].ToString(), out iTemp);
                    sTemp = row[sKeyCol].ToString();
                    dicResult.Add(sTemp, iTemp);
                    iTemp = 0;
                }
                if (dicResult.Count >= iTopX) break;
            }
            return dicResult;
        }
        public Dictionary<string, string> GetTopXFromDtAsDic2(DataTable dt, int iTopX, string sKeyCol, string sValCol, string sRowFilter)
        {
            Dictionary<string, string> dicResult = new Dictionary<string, string>();
            //获取去重后的排序
            DataView dv = new DataView(dt, sRowFilter, string.Format("{0} DESC", sValCol), DataViewRowState.Unchanged);
            DataTable dtTopX = DtSelectTop(iTopX, dv.ToTable(true, sValCol));
            double[] arrTopX = new double[dtTopX.Rows.Count];
            double dTemp = 0;
            string sTemp = "";
            for (int i = 0; i < dtTopX.Rows.Count; i++)
            {
                Double.TryParse(dtTopX.Rows[i][sValCol].ToString(), out dTemp);
                arrTopX[i] = dTemp;
            }
            //排序，将并列的情况考虑在内
            foreach (var item in arrTopX)
            {
                List<DataRow> rows = new List<DataRow>();
                foreach (DataRow row in dt.Rows)
                {
                    if (double.Parse(row[sValCol].ToString()) == item)
                        rows.Add(row);
                }
                foreach (DataRow row in rows)
                {
                    Double.TryParse(row[sValCol].ToString(), out dTemp);
                    sTemp = row[sKeyCol].ToString();
                    dicResult.Add(sTemp, FractionToPercent(dTemp));
                }
                if (dicResult.Count >= iTopX) break;
            }
            return dicResult;
        }
        public Dictionary<string, int[]> GetTopXFromDtAsDic3(DataTable dt, int iTopX, string sKeyCol, string sValColSub, string sValColMain, string sRowFilter)
        {
            Dictionary<string, int[]> dicResult = new Dictionary<string, int[]>();
            //获取去重后的排序
            DataView dv = new DataView(dt, sRowFilter, string.Format("{0} DESC", sValColMain), DataViewRowState.Unchanged);
            DataTable dtTopX = DtSelectTop(iTopX, dv.ToTable(true, sValColMain));
            int[] arrTopX = new int[dtTopX.Rows.Count];
            int iValMain = 0;
            int iValSub = 0;
            string sTemp = "";
            for (int i = 0; i < dtTopX.Rows.Count; i++)
            {
                Int32.TryParse(dtTopX.Rows[i][sValColMain].ToString(), out iValMain);
                arrTopX[i] = iValMain;
            }
            //排序，将并列的情况考虑在内
            foreach (int item in arrTopX)
            {
                foreach (DataRow row in dt.Select(string.Format("{0}={1}", sValColMain, item)))
                {
                    Int32.TryParse(row[sValColMain].ToString(), out iValMain);
                    Int32.TryParse(row[sValColSub].ToString(), out iValSub);
                    sTemp = row[sKeyCol].ToString();
                    dicResult.Add(sTemp, new int[2] { iValSub, iValMain });
                }
                if (dicResult.Count >= iTopX) break;
            }
            return dicResult;
        }
        /// <summary>
        /// 输出范例：“比排名第1的浙江、江苏少12件，比排名第三的北京多2件”
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="iTopX"></param>
        /// <param name="sREFName"></param>
        /// <param name="sREFCol"></param>
        /// <returns></returns>
        public string GetTopXFromDtAsString(DataTable dt, int iTopX, string sREFName, string sKeyCol, string sValCol, string sRowFilter)
        {
            //获取sKeyCol=sREFName的列的sValCol值
            DataRow[] rows = dt.Select(string.Format("{0}='{1}'", sKeyCol, sREFName));
            int iREFVal = 0;
            Int32.TryParse(rows[0][sValCol].ToString(), out iREFVal);
            //
            //获取去重后的排序
            //DataView dv = new DataView(dt, sRowFilter, string.Format("{0} DESC", sValCol), DataViewRowState.Unchanged);
            DataView dv = new DataView(dt);
            dv.Sort = string.Format("{0} DESC", sValCol);
            dv.RowFilter = sRowFilter;
            DataTable dtTemp = DtSelectTop(iTopX, dv.ToTable(true, sValCol));
            int[] arrTopX = new int[dtTemp.Rows.Count];
            int iTemp = 0;
            for (int i = 0; i < dtTemp.Rows.Count; i++)
            {
                Int32.TryParse(dtTemp.Rows[i][sValCol].ToString(), out iTemp);
                arrTopX[i] = iTemp;
            }
            //
            //构建datatable，包含排名、sKeyCol、sValCol
            DataTable dtTopX = new DataTable();
            dtTopX.Columns.Add("Rank");
            dtTopX.Columns.Add(sKeyCol);
            dtTopX.Columns.Add(sValCol, typeof(Int32));

            for (int i = 0; i < arrTopX.Length; i++)
            {
                foreach (DataRow row in dt.Select(string.Format("{0}={1}", sValCol, arrTopX[i])))
                {
                    string sName = "";
                    int iVal = 0;
                    sName = row[sKeyCol].ToString();
                    Int32.TryParse(row[sValCol].ToString(), out iVal);
                    //todo  dtTopX.AddNewRow(i + 1, sName, iVal);
                }
                //if (dtTopX.Rows.Count >= iTopX) break;
            }
            //
            //构建输出语句
            int iTopCount = 0;   //已描述的sKeyVal值的个数，原则为三个
            StringBuilder sbResult = new StringBuilder();
            List<string> listResult = new List<string>();
            for (int i = 0; i < arrTopX.Length; i++)
            {
                int iRank = 0;
                string sKeyNames = "";
                string sBeyondOrBelow = "";
                int iDiff = 0;
                //获取sKeyCol列的内容，考虑并列的情况
                rows = dtTopX.Select(string.Format("{0}={1}", sValCol, arrTopX[i]));
                iTopCount += rows.Length;
                List<string> listKeyNames = new List<string>();
                foreach (DataRow row in rows)
                {
                    listKeyNames.Add(row[sKeyCol].ToString());
                }
                Int32.TryParse(rows[0]["Rank"].ToString(), out iRank);
                //根据所参照的sREFName是否包含在listKeyNames中，分类处理
                if (listKeyNames.Contains(sREFName))        //包含，sREFName在topX中
                {
                    listKeyNames.Remove(sREFName);
                    if (listKeyNames.Count <= 0) continue;
                    sKeyNames = string.Join("、", listKeyNames.ToArray());
                    listResult.Add(string.Format("与{0}并列排名第{1}"
                                                , sKeyNames
                                                , iRank));
                }
                else    //不包含，sREFName不在topX中
                {
                    sKeyNames = string.Join("、", listKeyNames.ToArray());
                    int iValThis = 0;
                    Int32.TryParse(rows[0][sValCol].ToString(), out iValThis);
                    iDiff = iREFVal - iValThis;
                    sBeyondOrBelow = iDiff > 0 ? "多" : "少";
                    listResult.Add(string.Format("比排名第{0}的{1}{2}{3}件"
                                                , iRank
                                                , sKeyNames
                                                , sBeyondOrBelow
                                                , Math.Abs(iDiff)));
                }
                if (iTopCount >= iTopX) break;
            }
            return string.Join("，", listResult.ToArray()) + "。";
        }
        private DataTable DtSelectTop(int iTopX, DataTable dt)
        {
            if (dt.Rows.Count < iTopX) return dt;

            DataTable dtNew = new DataTable();
            dtNew.Columns.Add(dt.Columns[0].ColumnName, dt.Columns[0].DataType);
            for (int i = 0; i < iTopX; i++)
            {
                dtNew.Rows.Add(double.Parse(dt.Rows[i][0].ToString()));
            }

            return dtNew;
        }

        public CRBIDocContentBase()
        {
            mark_0_DateTime_Now = CRBIConst.const_CurrDate;
            mark_0_StartYear = CRBIConst.const_StartYear;
            mark_0_EndYear = CRBIConst.const_EndYear;
            mark_0_StartMonth = CRBIConst.const_StartMonth;
            mark_0_EndMonth = CRBIConst.const_EndMonth;
            mark_0_XXXX_YearFormat = String.Format("{0}年", mark_0_StartYear);
            mark_0_JZ_XXXXY_XM_DateFormat3 = String.Format("截止{0}年{1}月", mark_0_StartYear, mark_0_EndMonth);
            mark_0_Current_XXXXY_XM_DateFormat4 = String.Format("{0}年{1}月", mark_0_StartYear, mark_0_EndMonth);
            mark_0_Previous_XXXXY_XM_DateFormat5 = String.Format("{0}年{1}月", mark_0_StartYear - 1, mark_0_EndMonth);
            DateTime dateNextMonthOfReportDate = CRBIConst.const_EndDate.AddMonths(1);
            sNextMonthOfReportDate = String.Format("{0}年{1}月", dateNextMonthOfReportDate.Year, dateNextMonthOfReportDate.Month);
            if (mark_0_StartMonth == mark_0_EndMonth)
            {
                mark_0_XXXXY_XM_To_XM_DateFormat1 = String.Format("{0}年{1}月", mark_0_StartYear, mark_0_EndMonth);
                mark_0_XM_To_XM_DateFormat2 = String.Format("{1}月", mark_0_StartYear, mark_0_StartMonth);
            }
            else
            {
                mark_0_XXXXY_XM_To_XM_DateFormat1 = String.Format("{0}年{1}-{2}月", mark_0_StartYear, mark_0_StartMonth, mark_0_EndMonth);
                mark_0_XM_To_XM_DateFormat2 = String.Format("{1}-{2}月", mark_0_StartYear, mark_0_StartMonth, mark_0_EndMonth);
            }
            mark_0_FirstHalfYear = String.Format("{0}年1-6月", mark_0_StartYear);
            mark_0_SecondHalfYear = String.Format("{0}年7-12月", mark_0_StartYear);
            mark_0_Current_XXXXY_XM_DateFormat5 = string.Format("{0}年第{1}期（总第{2}期）"
                                                                                                    , mark_0_EndYear
                                                                                                    , mark_0_EndMonth
                                                                                                    , GetTotalPeriod());
            mark_0_Current_XXXXY_XM_DateFormat6 = string.Format("{0}.{1}-{2}"
                                                                                        , mark_0_EndYear
                                                                                        , mark_0_StartMonth
                                                                                        , mark_0_EndMonth);
        }
    }
    public class CRBIDocContentItemList : ICollection<List<string>>
    {
        public int Level;
        public List<List<string>> docContentItemList { get; set; }
        public CRBIDocContentItemList(string[] arr, int level = 1)
        {
            Level = level;
            docContentItemList = new List<List<string>>();
            List<string> list = new List<string>(arr);
            docContentItemList.Add(list);
        }
        public CRBIDocContentItemList(int level = 1)
        {
            Level = level;
            docContentItemList = new List<List<string>>();
        }
        public void Add(List<string> item)
        {
            List<string> list = new List<string>(item.ToArray());
            docContentItemList.Add(list);
        }

        public void Clear()
        {
            foreach (var item in docContentItemList)
            {
                item.Clear();
            }
            docContentItemList.Clear();
        }

        public bool Contains(List<string> item)
        {
            return true;
        }

        public void CopyTo(List<string>[] array, int arrayIndex)
        {

        }

        public int Count
        {
            get { return docContentItemList.Count(); }
        }

        public bool IsReadOnly
        {
            get { return true; }
        }

        public bool Remove(List<string> item)
        {
            return true;
        }

        public IEnumerator<List<string>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

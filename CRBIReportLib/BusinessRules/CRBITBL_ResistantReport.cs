using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRBIReportLib.BusinessRules
{

    public class CRBITBL_ResistantReport
    {
        #region 单例
        private static CRBITBL_ResistantReport _report;
        private CRBITBL_ResistantReport()
        { }
        public static CRBITBL_ResistantReport Intance()
        {
            if (_report == null)
                _report = new CRBITBL_ResistantReport();
            return _report;
        }
        #endregion

        #region  基本信息
        /// <summary>
        /// 机房所属
        /// </summary>
        public static string C0_JFSSDW;
        /// <summary>
        /// 机房名称
        /// </summary>
        public static string C1_JFMC;
        /// <summary>
        /// 操作员编号
        /// </summary>
        public static string C2_YHBH;
        /// <summary>
        /// 整组类型
        /// </summary>
        public static string C3_ZZLX;
        /// <summary>
        /// 整组编号
        /// </summary>
        public static string C4_ZZBH;
        /// <summary>
        ///  单体类型
        /// </summary>
        public static string C5_DTLX;
        /// <summary>
        /// 单体节数
        /// </summary>
        public static string C6_DTJS;
        /// <summary>
        /// 测试方式
        /// </summary>
        public static string C7_CSLX;
        /// <summary>
        /// 参考内阻
        /// </summary>
        public static string C8_CSNZ;
        /// <summary>
        /// 平均内阻
        /// </summary>
        public static string C9_PJNZ;
        /// <summary>
        /// 平均电压
        /// </summary>
        public static string C10_PJDY;
        /// <summary>
        /// 环境温度
        /// </summary>
        public static string C11_HJWD;
        /// <summary>
        /// 环境湿度
        /// </summary>
        public static string C12_HJSD;
        /// <summary>
        /// 测试时长
        /// </summary>
        public static string C13_CCCXSJ;
        /// <summary>
        /// 开始时间
        /// </summary>
        public static string C14_CSKSSJ;
        /// <summary>
        /// 内阻测试结果
        /// </summary>
        public static string C15_NZJG_Table;
        /// <summary>
        /// 单体电压限
        /// </summary>
        public static string C16_DDDYX;
        /// <summary>
        /// 放出容量限///充入容量限
        /// </summary>
        public static string C17_FCRLX;//C17_CRRLX;
        /// <summary>
        /// 环境温度
        /// </summary>
        public static string C18_HJWD;
        /// <summary>
        /// 测试开始时间
        /// </summary>
        public static string C19_CSKSSJ;
        /// <summary>
        /// 终止原因
        /// </summary>
        public static string C20_ZZYY;
        /// <summary>
        /// 环境湿度
        /// </summary>
        public static string C21_HJSD;
        /// <summary>
        /// 测试持续时间
        /// </summary>
        public static string C22_CCCXSJ;
        /// <summary>
        /// 结论和方案
        /// </summary>
        public static DataTable C23_JLFATable;
        /// <summary>
        ///  正常节数
        /// </summary>
        public static string C25_ZCJS;
        /// <summary>
        /// 正常明细
        /// </summary>
        public static string C26_ZCMX;
        /// <summary>
        /// 落后节数
        /// </summary>
        public static string C27_LHJS;
        /// <summary>
        /// 落后明细
        /// </summary>
        public static string C28_LHMX;
        /// <summary>
        /// 严重落后节数
        /// </summary>
        public static string C29_YZLHJS;
        /// <summary>
        /// 严重落后明细
        /// </summary>
        public static string C30_YZLHMX;
        /// <summary>
        /// 电流曲线 
        /// </summary>
        public static string C33_DLQXChart;
        /// <summary>
        /// 电压曲线
        /// </summary>
        public static string C32_DYQXChart;
        /// <summary>
        /// 放电曲线
        /// </summary>
        public static string C31_FDQXChart;

        #endregion


        #region 字段

        #endregion

        #region 图

        #endregion


        #region 表

        #endregion

    }
}

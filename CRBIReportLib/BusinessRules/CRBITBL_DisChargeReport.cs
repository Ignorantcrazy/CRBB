using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRBIReportLib.BusinessRules
{
    public class CRBITBL_DisChargeReport
    {
        #region 单例
        private static CRBITBL_DisChargeReport _report;
        private CRBITBL_DisChargeReport()
        { }
        public static CRBITBL_DisChargeReport Intance()
        {
            if (_report == null)
                _report = new CRBITBL_DisChargeReport();
            return _report;
        }
        #endregion

        #region  基本信息
        /// <summary>
        ///   电池型号
        /// </summary>
        public static string C0_DCXH;
        /// <summary>
        ///  生产厂家
        /// </summary>
        public static string C1_SCCJ;
        /// <summary>
        ///  安装日期
        /// </summary>
        public static string C2_ANRQ;
        /// <summary>
        ///  生产工艺
        /// </summary>
        public static string C3_SCGY;
        /// <summary>
        /// 机房名称
        /// </summary>
        public static string C4_JFMC;
        /// <summary>
        ///  电池组号
        /// </summary>
        public static string C5_DCZH;
        /// <summary>
        ///  整组类型
        /// </summary>
        public static string C6_ZZLX;
        /// <summary>
        ///  单体类型
        /// </summary>
        public static string C7_DTLX;
        /// <summary>
        /// 电池组数
        /// </summary>
        public static string C8_DCZS;
        /// <summary>
        /// 每组节数
        /// </summary>
        public static string C9_MZJS;
        /// <summary>
        /// 标称容量
        /// </summary>
        public static string C10_BCRL;
        /// <summary>
        ///  单节排序
        /// </summary>
        public static string C11_DJPX;
        /// <summary>
        /// 放电方式/////均充电压
        /// </summary>
        public static string C12_FDFS;//C12_JCDY;
        /// <summary>
        /// 整组电压限//////浮充电压
        /// </summary>
        public static string C13_ZZDYX;//C13_FCDY;
        /// <summary>
        /// 放电时间////充电时间
        /// </summary>
        public static string C14_FDSJ;//C14_CDSJ;
        /// <summary>
        /// 放电电流////充电电流
        /// </summary>
        public static string C15_FDDL;//C15_CDDL;
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


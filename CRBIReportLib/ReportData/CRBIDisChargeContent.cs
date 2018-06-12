using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRBIReportLib.ReportData
{
    public class CRBIDisChargeContent
    {
        public CRBIDisChargeContent()
        {
            batEquipmentInfoContent = new CRBIDisCharge_BatEquipmentInfoContent();
            batteryPackInfoContent = new CRBIDisCharge_BatteryPackInfoContent();
            batteryParameterContent = new CRBIDisCharge_BatteryParameterContent();
            testResultContnt = new CRBIDisCharge_TestResultContnt();

        }
        /// <summary>
        ///  设备信息
        /// </summary>
        public CRBIDisCharge_BatEquipmentInfoContent batEquipmentInfoContent;
        /// <summary>
        /// 电池组信息
        /// </summary>
        public CRBIDisCharge_BatteryPackInfoContent batteryPackInfoContent;
        /// <summary>
        /// 电池参数
        /// </summary>
        public CRBIDisCharge_BatteryParameterContent batteryParameterContent;
        /// <summary>
        /// 测试结论
        /// </summary>
        public CRBIDisCharge_TestResultContnt testResultContnt;
    }
    /// <summary>
    /// 电池设备信息
    /// </summary>
    public class CRBIDisCharge_BatEquipmentInfoContent
    {
        #region  基本信息
        /// <summary>
        ///   电池型号
        /// </summary>
       public string s_C0_DCXH;
        /// <summary>
        ///  生产厂家
        /// </summary>
       public string s_C1_SCCJ;
        /// <summary>
        ///  安装日期
        /// </summary>
       public string s_C2_ANRQ;
        /// <summary>
        ///  生产工艺
        /// </summary>
       public string s_C3_SCGY;
        /// <summary>
        /// 机房名称
        /// </summary>
       public string s_C4_JFMC;
        /// <summary>
        ///  电池组号
        /// </summary>
       public string s_C5_DCZH;
        /// <summary>
        ///  整组类型
        /// </summary>
       public string s_C6_ZZLX;
        /// <summary>
        ///  单体类型
        /// </summary>
       public string s_C7_DTLX;
        /// <summary>
        /// 电池组数
        /// </summary>
       public string s_C8_DCZS;
        /// <summary>
        /// 每组节数
        /// </summary>
       public string s_C9_MZJS;
        /// <summary>
        /// 标称容量
        /// </summary>
       public string s_C10_BCRL;
        /// <summary>
        ///  单节排序
        /// </summary>
       public string s_C11_DJPX;
        
        #endregion
    }
    /// <summary>
    /// 电池组信息
    /// </summary>
    public class CRBIDisCharge_BatteryPackInfoContent
    {
        #region  基本信息

        /// <summary>
        /// 放电方式/////均充电压
        /// </summary>
       public string s_C12_FDFS;//C12_JCDY;
        /// <summary>
        /// 整组电压限//////浮充电压
        /// </summary>
       public string s_C13_ZZDYX;//C13_FCDY;
        /// <summary>
        /// 放电时间////充电时间
        /// </summary>
       public string s_C14_FDSJ;//C14_CDSJ;
        /// <summary>
        /// 放电电流////充电电流
        /// </summary>
       public string s_C15_FDDL;//C15_CDDL;
        /// <summary>
        /// 单体电压限
        /// </summary>
       public string s_C16_DDDYX;
        /// <summary>
        /// 放出容量限///充入容量限
        /// </summary>
       public string s_C17_FCRLX;//C17_CRRLX;
        
        #endregion
    }
    /// <summary>
    /// 充电电池电池参数信息
    /// </summary>
    public class CRBIDisCharge_BatteryParameterContent
    {
        #region  基本信息

        /// <summary>
        /// 环境温度
        /// </summary>
       public string s_C18_HJWD;
        /// <summary>
        /// 测试开始时间
        /// </summary>
       public string s_C19_CSKSSJ;
        /// <summary>
        /// 终止原因
        /// </summary>
       public string s_C20_ZZYY;
        /// <summary>
        /// 环境湿度
        /// </summary>
       public string s_C21_HJSD;
        /// <summary>
        /// 测试持续时间
        /// </summary>
       public string s_C22_CCCXSJ;
        
        #endregion
    }
    public class CRBIDisCharge_TestResultContnt
    {
        #region 基本属性
        
        /// <summary>
        /// 结论和方案
        /// </summary>
        //public static DataTable C23_JLFATable;
        /// <summary>
        ///  正常节数
        /// </summary>
       public string s_C25_ZCJS;
        /// <summary>
        /// 正常明细
        /// </summary>
       public string s_C26_ZCMX;
        /// <summary>
        /// 落后节数
        /// </summary>
       public string s_C27_LHJS;
        /// <summary>
        /// 落后明细
        /// </summary>
       public string s_C28_LHMX;
        /// <summary>
        /// 严重落后节数
        /// </summary>
       public string s_C29_YZLHJS;
        /// <summary>
        /// 严重落后明细
        /// </summary>
       public string s_C30_YZLHMX;
        /// <summary>
        /// 电流曲线 
        /// </summary>
        //public static string C33_DLQXChart;
        /// <summary>
        /// 电压曲线
        /// </summary>
        //public static string C32_DYQXChart;
        /// <summary>
        /// 放电曲线
        /// </summary>
        //public static string C31_FDQXChart;
        #endregion
    }
}

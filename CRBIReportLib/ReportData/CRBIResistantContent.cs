using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRBIReportLib.ReportData
{
    public class CRBIResistantContent
    {
        public CRBIResistantContent()
        {
            batEquipmentInfoContent = new CRBIResistant_BatEquipmentInfoContent();
            batteryPackInfoContent = new CRBIResistant_BatteryPackInfoContent();
            batteryParameterContent = new CRBIResistant_BatteryParameterContent();
            testResultContnt = new CRBIResistant_TestResultContnt();

        }
        /// <summary>
        ///  设备信息
        /// </summary>
        public CRBIResistant_BatEquipmentInfoContent batEquipmentInfoContent;
        /// <summary>
        /// 电池组信息
        /// </summary>
        public CRBIResistant_BatteryPackInfoContent batteryPackInfoContent;
        /// <summary>
        /// 电池参数
        /// </summary>
        public CRBIResistant_BatteryParameterContent batteryParameterContent;
        /// <summary>
        /// 测试结论
        /// </summary>
        public CRBIResistant_TestResultContnt testResultContnt;
    }
    /// <summary>
    /// 电池设备信息
    /// </summary>
    public class CRBIResistant_BatEquipmentInfoContent
    {
        #region  基本信息
        /// <summary>
        /// 机房所属
        /// </summary>
        public string s_C0_JFSSDW;
        /// <summary>
        /// 机房名称
        /// </summary>
        public string s_C1_JFMC;
        /// <summary>
        /// 操作员编号
        /// </summary>
        public string s_C2_YHBH;
        /// <summary>
        /// 整组类型
        /// </summary>
        public string s_C3_ZZLX;
        /// <summary>
        /// 整组编号
        /// </summary>
        public string s_C4_ZZBH;
        /// <summary>
        ///  单体类型
        /// </summary>
        public string s_C5_DTLX;
        /// <summary>
        /// 单体节数
        /// </summary>
        public string s_C6_DTJS;

        #endregion
    }
    /// <summary>
    /// 电池组信息
    /// </summary>
    public class CRBIResistant_BatteryPackInfoContent
    {
        #region  基本信息

       
        ///// <summary>
        ///// 整组类型
        ///// </summary>
        //public string s_C3_ZZLX;
        ///// <summary>
        ///// 整组编号
        ///// </summary>
        //public string s_C4_ZZBH;
        ///// <summary>
        /////  单体类型
        ///// </summary>
        //public string s_C5_DTLX;
        ///// <summary>
        ///// 单体节数
        ///// </summary>
        //public string s_C6_DTJS;
         ///<summary>
         ///测试方式
         ///</summary>
        public string s_C7_CSLX;
        /// <summary>
        /// 参考内阻
        /// </summary>
        public string s_C8_CSNZ;
        /// <summary>
        /// 平均内阻
        /// </summary>
        public string s_C9_PJNZ;
        /// <summary>
        /// 平均电压
        /// </summary>
        //public string s_C10_PJDY;
        ///// <summary>
        ///// 环境温度
        ///// </summary>
        //public string s_C11_HJWD;
        ///// <summary>
        ///// 环境湿度
        ///// </summary>
        //public string s_C12_HJSD;
        ///// <summary>
        ///// 测试时长
        ///// </summary>
        //public string s_C13_CCCXSJ;
        ///// <summary>
        ///// 开始时间
        ///// </summary>
        //public string s_C14_CSKSSJ;
        ///// <summary>
        ///// 内阻测试结果
        ///// </summary>
        //public string s_C15_NZJG_Table;
        ///// <summary>
        ///// 单体电压限
        ///// </summary>
        //public string s_C16_DDDYX;
        ///// <summary>
        ///// 放出容量限///充入容量限
        ///// </summary>
        //public string s_C17_FCRLX;//C17_CRRLX;
        #endregion
    }
    /// <summary>
    /// 充电电池电池参数信息
    /// </summary>
    public class CRBIResistant_BatteryParameterContent
    {
        #region  基本信息
        ///// <summary>
        ///// 测试方式
        ///// </summary>
        //public string s_C7_CSLX;
        ///// <summary>
        ///// 参考内阻
        ///// </summary>
        //public string s_C8_CSNZ;
        ///// <summary>
        ///// 平均内阻
        ///// </summary>
        //public string s_C9_PJNZ;
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
    public class CRBIResistant_TestResultContnt
    {
        #region 基本属性
        /// <summary>
        /// 结论和方案
        /// </summary>
        // public static DataTable C23_JLFATable;
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
        //public string s_C33_DLQXChart;
        /// <summary>
        /// 电压曲线
        /// </summary>
        //public string s_C32_DYQXChart;
        /// <summary>
        /// 放电曲线
        /// </summary>
        //public string s_C31_FDQXChart;
        #endregion
    }
}

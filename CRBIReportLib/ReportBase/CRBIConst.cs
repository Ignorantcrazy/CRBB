using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRBIReportLib.ReportBase
{
    public class CRBIConst
    {
        public enum SIPOType
        {
            Apply = 1,
            Authorize = 3,
            Valid = 2,
            PCT = 4
        }

        public enum ApplySource
        {
            Normal = 0,
            PCT = 1
        }

        /// <summary>
        /// 非广东 珠三角 东翼 西翼 山区
        /// </summary>
        public enum AreaType
        {
            NotGD,
            Delta,
            East,
            West,
            Mountain,
        }
        /// <summary>
        /// 大专院校 科研机构 企业 机关团体 个人
        /// </summary>
        public enum ApplicantType
        {
            /// <summary>
            /// 大专院校
            /// </summary>
            University = 1,
            /// <summary>
            /// 科研机构
            /// </summary>
            Research = 2,
            /// <summary>
            /// 企业
            /// </summary>
            Enterprise = 3,
            /// <summary>
            /// 机关团体
            /// </summary>
            Organization = 4,
            /// <summary>
            /// 个人
            /// </summary>
            Individual = 5
        }
        /// <summary>
        /// 申请人/专利权人
        /// </summary>
        public enum ApplicantSort
        {
            Applicant = 1,
            Authorizer = 3
        }
        /// <summary>
        /// 泛珠江三角洲区域 长江三角洲经济区 环渤海经济区
        /// </summary>
        public enum CNAreaType
        {
            /// <summary>
            /// 泛珠江三角洲区域
            /// </summary>
            PearlRiver = 1,
            /// <summary>
            /// 长江三角洲经济区
            /// </summary>
            YangtzeRiver = 2,
            /// <summary>
            /// 环渤海经济区
            /// </summary>
            BohaiSea = 3
        }
        /// <summary>
        /// 试点、示范类型
        /// </summary>
        public enum SampleAndPolitType
        {
            /// <summary>
            /// 示范城市
            /// </summary>
            SampleCity = 1,
            /// <summary>
            /// 试点城市
            /// </summary>
            PolitCity = 2,
            /// <summary>
            /// 示范区县
            /// </summary>
            SampleArea = 3,
            /// <summary>
            /// 试点区县
            /// </summary>
            PolitArea = 4,
            /// <summary>
            /// 示范企业
            /// </summary>
            SampleEnterprise = 5,
            /// <summary>
            /// 优势企业
            /// </summary>
            AdvanceEnterprise = 6
        }
        /// <summary>
        /// 专利状态：申请
        /// </summary>
        public static int const_PatentStatus_3ZZLLX_SQ_1 = 1;
        /// <summary>
        /// 专利状态：授权
        /// </summary>
        public static int const_PatentStatus_3ZZLLX_SQ_3 = 3;
        /// <summary>
        /// 专利状态：有效-4
        /// </summary>
        public static int const_PatentStatus_3ZZLLX_SQ_4 = 4;

        /// <summary>
        /// 专利类型：发明
        /// </summary>
        public static int const_PatentType_FM_1 = 1;
        /// <summary>
        /// 专利类型：实用新型
        /// </summary>
        public static int const_PatentType_SYXX_2 = 2;
        /// <summary>
        /// 专利类型：外观设计
        /// </summary>
        public static int const_PatentType_WGSJ_3 = 3;
        /// <summary>
        /// 专利类型：全部
        /// </summary>
        public static int const_PatentType_ALL = 0;

        public static string const_ProvinceName = "广东";
        public static string const_CorrectedDataName = "修正";
        public static int const_ProvinceCode = 19;
        public static DateTime const_CurrDate = DateTime.Now;
        public static int const_StartYear = 2016;
        public static int const_StartMonth = 1;
        public static int const_EndYear = 2016;
        public static int const_EndMonth = 4;
        public static DateTime const_StartDate = new DateTime(CRBIConst.const_StartYear, CRBIConst.const_StartMonth, 1);
        public static DateTime const_EndDate = new DateTime(CRBIConst.const_EndYear, CRBIConst.const_EndMonth, 1).AddMonths(1).AddDays(-1);


        //自定义界限 User Defined 
        public static double const_DIVIDING_LINE_UD = 0.9;
        //国家标准界限 GB
        public static double const_DIVIDING_LINE_GB = 0.85;
        //专利申请量=专利受理量-无申请费视撤量
        public static string const_DefinitionOfPatentApplyCount = "专利申请量=专利受理量-无申请费视撤量";
        //缴纳专利费用的期限-月
        public static int const_PayPatentFee_DeadLine = 2;
        //国家知识产权局一般是延后n个月公布专利申请量
        public static int const_PublishDelay = 3;
        //
        //总第XXX期
        /// <summary>
        /// 基准时间
        /// </summary>
        public static DateTime dtBaseDate = new DateTime(2015, 11, 1);
        /// <summary>
        /// 基准期数
        /// </summary>
        public static int iBasePeriod = 116;
        /// <summary>
        /// 专利维持年限在2-8年
        /// </summary>
        public static int[] arrPreservedYearRange = new int[] { 2, 8 };

        public static void SetDateTime(DateTime start, DateTime endYearAndMonth)
        {
            const_StartYear = start.Year;
            const_StartMonth = start.Month;

            const_EndYear = endYearAndMonth.Year;
            const_EndMonth = endYearAndMonth.Month;

            const_StartDate = start;
            const_EndDate = endYearAndMonth.AddMonths(1).AddDays(-1);
        }
        /// <summary>
        /// 日志文件夹
        /// </summary>
        public static string const_LogParentDir = "Log";
        /// <summary>
        /// 日志的完整路径
        /// </summary>
        public static string const_LogPath;
        /// <summary>
        /// 日志名称
        /// </summary>
        public static string const_LogName = "report_error.log";

    }

}

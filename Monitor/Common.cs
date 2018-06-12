using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Monitor
{
    public static class Common
    {
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="strSource">待加密字串</param>
        /// <returns>加密后的字串</returns>
        public static string MD5Encrypt(string strSource)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(strSource);
            byte[] hashValue = ((System.Security.Cryptography.HashAlgorithm)System.Security.Cryptography.CryptoConfig.CreateFromName("MD5")).ComputeHash(bytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 16; i++)    //默认32位加密
            {
                sb.Append(hashValue[i].ToString("X2"));
            }
            return sb.ToString();
        }
        public enum MonitorTypeEnum
        {
            /// <summary>
            /// 告警
            /// </summary>
            Event = 0,

            /// <summary>
            /// 市电停电
            /// </summary>
            PowerFailure = 1,

            /// <summary>
            /// 后备电源供电时间
            /// </summary>
            PowerSupplyTime = 2,

            /// <summary>
            /// 值勤任务
            /// </summary>
            MaintenanceTask = 3,

            /// <summary>
            /// 交接班
            /// </summary>
            HandoverClass = 4
        }

        public static bool ReadRegistry()
        {
            return true;
        }
    }

    /// <summary>
    /// 监控程序数据实体
    /// </summary>
    public class MonitorAppDataModel
    {
        public int Type { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }
    }
}

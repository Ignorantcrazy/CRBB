using IMFD.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRBIReportLib.RequestDTO
{
    public class CRBITBL_HistoryControlQuery : DTOBaseRequest
    {
        public int id;
        public string sProvinceName = "广东省";
        public int iProvinceCode = 19;
        public string sCityName;
        public int iCityCode;
        public string sAreaName;
        public int iAreaCode;
        public DateTime? dateStart = null;
        public DateTime? dateEnd = null;
        public string sEnterpriseName;
        public int iEnterpriseID;
        public bool bIsValid;
        public int iType;
        /// <summary>
        /// 命令ID
        /// </summary>
        public int ControlId;
        /// <summary>
        /// 站点ID
        /// </summary>
        public int StationId;
        /// <summary>
        /// 设备ID
        /// </summary>
        public int EquipmentId;
        /// <summary>
        /// 起始时间
        /// </summary>
        public DateTime StartTime;
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime;

    }
}

using Newegg.Oversea.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRBIReportLib.Table
{

    public class CRBITBL_HistoryControlTable
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        [DataMapping("StationId", DbType.Int32)]
        public int StationId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMapping("StationName", DbType.String)]
        public string StationName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMapping("EquipmentId", DbType.Int32)]
        public int EquipmentId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMapping("EquipmentName", DbType.String)]
        public string EquipmentName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMapping("ControlId", DbType.Int32)]
        public int ControlId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMapping("ControlName", DbType.String)]
        public string ControlName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMapping("SerialNo", DbType.Int32)]
        public int SerialNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMapping("ControlSeverity", DbType.Int32)]
        public int ControlSeverity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMapping("CmdToken", DbType.String)]
        public string CmdToken { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMapping("ControlPhase", DbType.Int32)]
        public int ControlPhase { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMapping("StartTime", DbType.DateTime)]
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMapping("EndTime", DbType.DateTime)]
        public DateTime EndTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMapping("ConfirmTime", DbType.DateTime)]
        public DateTime ConfirmTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMapping("ConfirmerId", DbType.Int32)]
        public int ConfirmerId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMapping("ConfirmerName", DbType.String)]
        public string ConfirmerName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMapping("ControlResultType", DbType.Int32)]
        public int ControlResultType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMapping("ControlResult", DbType.String)]
        public string ControlResult { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMapping("ControlExecuterId", DbType.Int32)]
        public int ControlExecuterId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMapping("ControlExecuterIdName", DbType.String)]
        public string ControlExecuterIdName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMapping("ControlType", DbType.Int32)]
        public int ControlType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMapping("ActionId", DbType.Int32)]
        public int ActionId { get; set; }
        /// <summary>
        ///
        /// </summary>
        [DataMapping("Description", DbType.String)]
        public string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMapping("Retry", DbType.Int32)]
        public int Retry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMapping("BaseTypeId", DbType.Int32)]
        public int BaseTypeId { get; set; } //   NUMERIC
        /// <summary>
        /// 
        /// </summary>
        [DataMapping("BaseTypeName", DbType.String)]
        public string BaseTypeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMapping("ParameterValues", DbType.String)]
        public string ParameterValues { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMapping("BaseCondId", DbType.Int32)]
        public int BaseCondId { get; set; }  //NUMERIC
    }

}

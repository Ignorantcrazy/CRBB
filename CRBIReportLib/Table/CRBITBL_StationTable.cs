using Newegg.Oversea.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRBIReportLib.Table
{
    public class CRBITBL_StationTable
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
        [DataMapping("SetupTime", DbType.DateTime)]
        public string SetupTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMapping("Description", DbType.String)]
        public string Description { get; set; }
        //StationId       INT NOT NULL,
        //StationName     NVARCHAR (255) NOT NULL,
        //Latitude        NUMERIC (20, 17),
        //Longitude       NUMERIC (20, 17),
        //SetupTime       DATETIME,
        //CompanyId       INT,
        //ConnectState    INT DEFAULT ((2)) NOT NULL,
        //UpdateTime      DATETIME NOT NULL,
        //StationCategory INT NOT NULL,
        //StationGrade    INT NOT NULL,
        //StationState    INT NOT NULL,
        //ContactId       INT,
        //SupportTime     INT,
        //OnWayTime       FLOAT,
        //SurplusTime     FLOAT,
        //FloorNo         NVARCHAR (50),
        //PropList        NVARCHAR (255),
        //Acreage         FLOAT,
        //BuildingType    INT,
        //ContainNode     BIT DEFAULT ((0)) NOT NULL,
        //Description     NVARCHAR (255),
        //BordNumber      INT,
        //CenterId        INT NOT NULL,
        //[Enable]        BIT DEFAULT ((1)) NOT NULL,
        //StartTime       DATETIME,
        //EndTime         DATETIME,
        //ProjectName     NVARCHAR (255),
        //ContractNo      NVARCHAR (255),
        //InstallTime     DATETIME,
        //CONSTRAINT PK_TBL_Station_ID PRIMARY KEY (StationId)
    }
}


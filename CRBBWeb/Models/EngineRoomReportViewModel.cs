using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRBBWeb.Models
{
    public class EngineRoomReportViewModel
    {
        public int ID{ get; set; }
        public int EngineRoomID{ get; set; }
        public int ReportType{ get; set; }
        public DateTime StartTime{ get; set; }
        public DateTime EndTime { get; set; }
        public DateTime ReportGenerateTime { get; set; }
        public string ReportContent{ get; set; }
    }
}
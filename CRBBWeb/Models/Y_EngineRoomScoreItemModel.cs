using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRBBWeb.Models
{
    public class Y_EngineRoomScoreItemModel
    {
        public int ID{ get; set; }
        public int ScoreID{ get; set; }
        public int ScoreItemID{ get; set; }
        public double Score{ get; set; }
        public double BaseScore{ get; set; }
    }

    public class Y_EngineRoomScoreItemViewModel
    {
        public double SupportTimeScore { get; set; }
        public double SupportTimeBaseScore { get; set; }
        public double HealthStatusScore { get; set; }
        public double HealthStatusBaseScore { get; set; }
        public double PowerQualityScore { get; set; }
        public double PowerQualityBaseScore { get; set; }
        //public double MaintenanceScore { get; set; }
        //public double MaintenanceBaseScore { get; set; }
        public double CapacitySurplusScore { get; set; }
        public double CapacitySurplusBaseScore { get; set; }
        public double EarthResistanceScore { get; set; }
        public double EarthResistanceBaseScore { get; set; }
    }
}
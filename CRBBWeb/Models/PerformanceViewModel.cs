using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRBBWeb.Models
{
    public class PerformanceViewModel
    {
        public int ID{ get; set; }
        public int EquipmentID { get; set; }
        public string EquipmentName{ get; set; }
        public double EquipmentScore{ get; set; }
        public int ScoreResult{ get; set; }
        public DateTime StartTime{ get; set; }
    }

    public class PerformanceResultViewModel
    {
        public List<string> Equipments { get; set; }
        public List<PerformanceDataViewModel> PerformanceData { get; set; }
    }

    public class PerformanceDataViewModel
    {
        public string Grade { get; set; }
        public List<double> Score { get; set; }
    }
}
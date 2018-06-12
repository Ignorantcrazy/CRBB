using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRBBWeb.Models
{
    public class SupportTimeModel
    {
        public int EquipmentType { get; set; }
        public string EquipmentName { get; set; }
        public double KeepTime { get; set; }
        public double LifeTime { get; set; }
    }

    public class SupportTimeViewModel
    {
        public double DCKeepTime { get; set; }
        public double DCLifeTime { get; set; }
        public string DCEqName { get; set; }
        public double UPSKeepTime { get; set; }
        public double UPSLifeTime { get; set; }
        public string UPSEqName { get; set; }
        public double GeneratorKeepTime { get; set; }
        public double GeneratorLifeTime { get; set; }
        public string GeneratorEqName { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRBBWeb.Models
{
    public class ResourceMonitoringViewModel
    {
        public int ID{ get; set; }
        public string ServiceIP{ get; set; }
        public double CPURate{ get; set; }
        public double MemeryRate { get; set; }
        public double HardDiskRemain { get; set; }
        public double HardDiskTotal { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRBBWeb.Models
{
    public class Y_WarnFaultViewModels
    {
        public int ID{ get; set; }
        public string EqIidentification { get; set; }
        public string EquipmentName{ get; set; }
        public string EventIidentification{ get; set; }
        public string EventName{ get; set; }
        public double EventValue{ get; set; }
        public string EventLevel{ get; set; }
        public DateTime StartTime{ get; set; }
        public DateTime EndTime{ get; set; }
    }
}
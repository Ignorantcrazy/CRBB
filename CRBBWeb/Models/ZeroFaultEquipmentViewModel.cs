using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRBBWeb.Models
{
    public class ZeroFaultEquipmentViewModel
    {
        public int ID { get; set; }
        public int EquipmentID { get; set; }
        public string EquipmentName { get; set; }
        public string Model { get; set; }
        public string FactoryName { get; set; }
        public DateTime UpdateTime{ get; set; }
        public int DevStaus{ get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monitor.ViewModels
{
    public class Y_EarlyWarningViewModels
    {
        public int ID { get; set; }
        public int EngineRoomID { get; set; }
        public int EquipmentID { get; set; }

        public string EquipmentName { get; set; }
        public int EWarnType { get; set; }
        public int EWarnLevel { get; set; }
        public string EWarnText { get; set; }
        public double EWarnValue { get; set; }
        public double EWarnThreshold { get; set; }
        public int EWarnStatus { get; set; }
        public string ExpertAdvice { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}

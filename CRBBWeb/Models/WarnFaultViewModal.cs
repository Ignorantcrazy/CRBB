using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRBBWeb.Models
{
    public class WarnFaultViewModal
    {
        public int Number { get; set; }
        public string WarnTime { get; set; }
    }

    public class WeeklyCurveViewModal
    {
        public int MondayNumber { get; set; }
        public int TuesdayNumber { get; set; }
        public int WednesdayNumber { get; set; }
        public int ThursdayNumber { get; set; }
        public int FridayNumber { get; set; }
        public int SaturdayNumber { get; set; }
        public int SundayNumber { get; set; }
    }

    public class WeeklyCurveResultViewModal
    {
        public WeeklyCurveViewModal WeeklyCurveWeek { get; set; }
        public WeeklyCurveViewModal WeeklyCurveLastWeek { get; set; }
    }
}
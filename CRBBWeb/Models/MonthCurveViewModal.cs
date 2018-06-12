using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRBBWeb.Models
{
    public class MonthCurveViewModal
    {
        public int Number { get; set; }
        public string WarnTime { get; set; }
        public int EqType { get; set; }
    }

    public class MonthCurveResultModal
    {
        //public List<string> EqType { get; set; }
        public List<string> WarnTime { get; set; }
        public List<MonthCurveDataModal> MonthCurveDataModal { get; set; }
    }

    public class MonthCurveDataModal
    {
        public string EqType { get; set; }
        public List<int> Number { get; set; }
    }
}
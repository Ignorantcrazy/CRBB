using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRBBWeb.Models
{
    public class AlarmStatisticsViewModel
    {
        public int OneMalfunctionNumber { get; set; }
        public int OneWarningNumber { get; set; }

        public int TwoMalfunctionNumber { get; set; }
        public int TwoWarningNumber { get; set; }

        public int ThreeMalfunctionNumber { get; set; }
        public int ThreeWarningNumber { get; set; }

    }

    public class AlarmStatisticsModel
    {
        public int Number { get; set; }
        public string EventLevel { get; set; }

        public int EventType { get; set; }
    }
}
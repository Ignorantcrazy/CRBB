using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRBBWeb.Models
{
    public class EarlyWarningPopViewModel
    {
        public int ID { get; set; }
        public string EWarnText { get; set; }
        public string ExpertAdvice { get; set; }
        public int EWarnLevel { get; set; }

        public bool IsVoice { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonthlyReportMissionPlan
{
    public class ApiResultModel<T>
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public T Obj { get; set; }
    }
}

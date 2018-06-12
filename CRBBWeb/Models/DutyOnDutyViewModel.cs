using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRBBWeb.Models
{
    public class DutyOnDutyListViewModel
    {
        public List<DutyOnDutyViewModel> DutyOnDutyViewModel { get; set; }
        public List<DutyOnDutyRemainingViewModel> DutyOnDutyRemainingViewModel { get; set; }
    }
    public class DutyOnDutyViewModel
    {
        public int Number { get; set; }
        public string PlanTime { get; set; }
    }

    public class DutyOnDutyRemainingViewModel
    {
        public int Number { get; set; }
        public string ExecuteTime { get; set; }
    }
}
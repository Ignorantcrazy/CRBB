using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TipsMissionPlan.ViewModels
{
    public class TipsViewModel
    {
        public int ID { get; set; }
        public string KnowledgeTitle { get; set; }
        public string KeyWord { get; set; }
        public string Problem { get; set; }
        public string Solution { get; set; }
        public int Day { get; set; }
    }
}

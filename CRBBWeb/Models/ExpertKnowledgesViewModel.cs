using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRBBWeb.Models
{
    public class ExpertKnowledgesViewModel
    {
        public List<ExpertKnowledgeViewModel> ExpertKnowledgeViewModel { get; set; }
    }

    public class ExpertKnowledgeViewModel
    {
        public string AccessoryKey { get; set; }
        public int ApplyCount { get; set; }
        public string BaseTypeId { get; set; }
        public string CreateTime { get; set; }
        public string CreateUser { get; set; }
        public string EquipmentCategory { get; set; }
        public string EquipmentCategoryName { get; set; }
        public string KnowledgeTitle { get; set; }
        public string Problem { get; set; }
        public string Remark { get; set; }
        public string Solution { get; set; }
    }
}
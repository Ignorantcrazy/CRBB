using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRBBWeb.Models
{
    public class NavItemsViewModel
    {
        public List<NavItemViewModel> NavItemViewModels { get; set; }
        public int NotFixedSelectedCount { get; set; }
    }
}
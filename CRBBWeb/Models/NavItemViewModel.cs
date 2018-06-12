using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRBBWeb.Models
{
    public class NavItemViewModel
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public bool Fixed { get; set; }
        public bool IsSelected { get; set; }
        public bool Active { get; set; }
        public string Url { get; set; }
        public string ImgUrl { get; set; }

    }

    public class NavItemPostModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Fixed { get; set; }
        public string IsSelected { get; set; }
        public string Active { get; set; }
        public string Url { get; set; }
    }
}
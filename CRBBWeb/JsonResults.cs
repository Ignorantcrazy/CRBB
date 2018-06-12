using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRBBWeb
{
    public class JsonResults : System.Web.Mvc.JsonResult
    {
        public JsonResults() : base()
        {
            this.JsonRequestBehavior = System.Web.Mvc.JsonRequestBehavior.AllowGet;
        }
    }
}
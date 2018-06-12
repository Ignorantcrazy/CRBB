using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRBBWeb
{
    public class ResultModel
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public object Result { get; set; }
    }
}
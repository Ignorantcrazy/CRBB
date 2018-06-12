using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRBBWeb.Models
{
    public class ApiResultViewModel<T>
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public T Obj { get; set; }
    }
}
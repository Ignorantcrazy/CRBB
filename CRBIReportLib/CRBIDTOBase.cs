using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMFD.Entity
{
    public abstract class DTOBase { }
    public class DTOBaseRequest : DTOBase
    {
        public PageInfo PageInfo { get; set; }
        // public User user { get; set; }
        public DTOBaseRequest()
        {
            PageInfo = new PageInfo() { PageIndex = 0, PageSize = 10 };
        }
    }
    public class DTOBaseResponse<T> : DTOBase
    {
        public int TotalCount { get; set; }
        public List<T> DataList { get; set; }
    }
}
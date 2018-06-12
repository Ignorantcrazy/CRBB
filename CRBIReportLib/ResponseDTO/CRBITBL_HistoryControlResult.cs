using CRBIReportLib.Table;
using IMFD.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRBIReportLib.ResponseDTO
{
    public class CRBITBL_HistoryControlResult : DTOBaseResponse<CRBITBL_HistoryControlTable>
    {
        public int TotalCount { get; set; }
        public DataTable dt { get; set; }
    }
}


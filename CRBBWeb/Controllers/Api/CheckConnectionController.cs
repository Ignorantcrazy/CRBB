using CRBIReportLib.ReportBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace CRBBWeb.Controllers.Api
{
    public class CheckConnectionController : ApiController
    {
        public bool Get()
        {
            try
            {
                int siteId = int.Parse(System.Configuration.ConfigurationManager.AppSettings["SiteId"]);
                DataTable dt = CRBIYYBBReportProjectRule.Intance().GetEngineRoomScore(siteId);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}

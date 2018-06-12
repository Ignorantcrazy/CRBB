using CRBBWeb.Models;
using CRBICommonLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRBBWeb.Controllers.Api
{
    public class MonthlyReportController : ApiController
    {
        public ApiResultViewModel<string> Get()
        {
            ApiResultViewModel<string> result = new ApiResultViewModel<string>();
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Setting.ini");
                IniFile ini = new IniFile(filePath);
                bool isShow = bool.Parse(ini.ReadString("Report", "MonthlyReport", ""));
                string div = ini.ReadString("Report", "Dir", "");
                if (isShow)
                {
                    result.Status = true;
                    result.Obj = div;
                }
            }
            catch (Exception ex)
            {
                result.Status = false;
                result.Message = ex.Message;
            }
            return result;
        }
    }
}

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
    public class PollingBroadcastController : ApiController
    {
        public ApiResultViewModel<bool> Get()
        {
            ApiResultViewModel<bool> result = new ApiResultViewModel<bool>();
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Setting.ini");
                IniFile ini = new IniFile(filePath);
                var isChecked = ini.ReadString("PollingBroadcast", "Checked", "");
                result.Status = true;
                result.Obj = bool.Parse(isChecked);
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

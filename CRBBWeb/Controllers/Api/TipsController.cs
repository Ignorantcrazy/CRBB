using CRBBWeb.Models;
using CRBICommonLib;
using CRBIReportLib.ReportBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace CRBBWeb.Controllers.Api
{
    public class TipsController : ApiController
    {
        public ApiResultViewModel<TipsViewModel> Get()
        {
            ApiResultViewModel<TipsViewModel> result = new ApiResultViewModel<TipsViewModel>();
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Setting.ini");
                IniFile ini = new IniFile(filePath);
                bool isShow = bool.Parse(ini.ReadString("Tips", "Show", ""));
                if (isShow)
                {
                    DataTable dt = CRBIYYBBReportProjectRule.Intance().GetDailyKnowledgePop();
                    List<TipsViewModel> list = CRBICommonLib.ModelConvertHelper<TipsViewModel>.ConvertToModel(dt);
                    if (list.Count <= 0)
                    {
                        result.Status = true;
                        result.Obj = null;
                        return result;
                    }
                    result.Status = true;
                    Random r = new Random();
                    int i = r.Next(1, list.Count);
                    result.Obj = list[i];
                    if (result.Obj == null)
                    {
                        result.Status = true;
                        result.Obj = null;
                        return result;
                    }
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

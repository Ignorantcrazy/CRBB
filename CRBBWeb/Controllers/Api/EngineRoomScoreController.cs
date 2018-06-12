using CRBBWeb.Models;
using CRBIReportLib.ReportBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRBBWeb.Controllers.Api
{
    public class EngineRoomScoreController : ApiController
    {
        public ApiResultViewModel<Y_EngineRoomScoreViewModel> Get()
        {
            ApiResultViewModel<Y_EngineRoomScoreViewModel> result = new ApiResultViewModel<Y_EngineRoomScoreViewModel>();
            try
            {
                int siteId = int.Parse(System.Configuration.ConfigurationManager.AppSettings["SiteId"]);
                DataTable dt = CRBIYYBBReportProjectRule.Intance().GetEngineRoomScore(siteId);
                List<Y_EngineRoomScoreViewModel> list = CRBICommonLib.ModelConvertHelper<Y_EngineRoomScoreViewModel>.ConvertToModel(dt);
                result.Obj =list[0];
                result.Status = true;
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

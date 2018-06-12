using Newegg.Oversea.Framework.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRBIReportLib.DataAccessors
{
    public class CRBITBL_StationAccessor
    {
        private static readonly CRBITBL_StationAccessor _instance = new CRBITBL_StationAccessor();
        public static CRBITBL_StationAccessor Instance()
        {
            return _instance;
        }

        public DataTable proc_GetStationId()
        {
            var dataCommand = DataCommandManager.GetDataCommand("proc_GetStationId");

            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }
        public DataTable getStationIdById(int stationId)
        {
            var dataCommand = DataCommandManager.GetDataCommand("getStationIdById");
            dataCommand.SetParameterValue("@StationId", stationId);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }
    }
}


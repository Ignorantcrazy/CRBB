using CRBIReportLib.RequestDTO;
using CRBIReportLib.ResponseDTO;
using CRBIReportLib.Table;
using Newegg.Oversea.Framework.DataAccess;
using Newegg.Oversea.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRBIReportLib.DataAccessors
{

    public class CRBITBL_HistoryControlAccessor
    {
        private static readonly CRBITBL_HistoryControlAccessor _instance = new CRBITBL_HistoryControlAccessor();
        public static CRBITBL_HistoryControlAccessor Instance()
        {
            return _instance;
        }

        #region 简报用
        /// <summary>
        /// 示范、试点--城市、区县、企业--数量
        /// </summary>
        /// <param name="dtReportDate"></param>
        /// <param name="iType"></param>
        /// <returns></returns>
        public DataTable loadSamplePolitCityAndAreaNum(DateTime dtReportDate, int iType)
        {
            var dataCommand = DataCommandManager.GetDataCommand("loadSamplePolitCityAndAreaNum");
            dataCommand.SetParameterValue("@dtReportDate", dtReportDate);
            dataCommand.SetParameterValue("@iType", iType);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }
        /// <summary>
        /// 示范、优势企业数量
        /// </summary>
        /// <param name="dtReportDate"></param>
        /// <param name="iType"></param>
        /// <returns></returns>
        public DataTable loadSampleAdvanceEnterpriseNum(DateTime dtReportDate, int iType)
        {
            var dataCommand = DataCommandManager.GetDataCommand("loadSampleAdvanceEnterpriseNum");
            dataCommand.SetParameterValue("@iType", iType);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }
        /// <summary>
        /// 城市-申请量-同比增长
        /// </summary>
        public DataTable loadSamplePolitApplyCityNumAndRate(DateTime dtStart, DateTime dtEnd, int iType)
        {
            var dataCommand = DataCommandManager.GetDataCommand("loadSamplePolitApplyCityNumAndRate");
            dataCommand.SetParameterValue("@dtStart", dtStart);
            dataCommand.SetParameterValue("@dtEnd", dtEnd);
            dataCommand.SetParameterValue("@iType", iType);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }
        /// <summary>
        /// 城市-授权量-同比增长
        /// </summary>
        public DataTable loadSamplePolitAuthorizeCityNumAndRate(DateTime dtStart, DateTime dtEnd, int iType)
        {
            var dataCommand = DataCommandManager.GetDataCommand("loadSamplePolitAuthorizeCityNumAndRate");
            dataCommand.SetParameterValue("@dtStart", dtStart);
            dataCommand.SetParameterValue("@dtEnd", dtEnd);
            dataCommand.SetParameterValue("@iType", iType);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }
        /// <summary>
        /// 城市-申请量排名
        /// </summary>
        public DataTable loadSamplePolitCityApplyRank(DateTime dtStart, DateTime dtEnd, int iType)
        {
            var dataCommand = DataCommandManager.GetDataCommand("loadSamplePolitCityApplyRank");
            dataCommand.SetParameterValue("@dtStart", dtStart);
            dataCommand.SetParameterValue("@dtEnd", dtEnd);
            dataCommand.SetParameterValue("@iType", iType);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }
        /// <summary>
        /// 城市-授权量排名
        /// </summary>
        public DataTable loadSamplePolitCityAuthorizeRank(DateTime dtStart, DateTime dtEnd, int iType)
        {
            var dataCommand = DataCommandManager.GetDataCommand("loadSamplePolitCityAuthorizeRank");
            dataCommand.SetParameterValue("@dtStart", dtStart);
            dataCommand.SetParameterValue("@dtEnd", dtEnd);
            dataCommand.SetParameterValue("@iType", iType);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }
        /// <summary>
        /// 区县-申请量-同比增长
        /// </summary>
        public DataTable loadSamplePolitAreaApplyNum(DateTime dtStart, DateTime dtEnd, int iType)
        {
            var dataCommand = DataCommandManager.GetDataCommand("loadSamplePolitAreaApplyNum");
            dataCommand.SetParameterValue("@dtStart", dtStart);
            dataCommand.SetParameterValue("@dtEnd", dtEnd);
            dataCommand.SetParameterValue("@iType", iType);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }
        /// <summary>
        /// 区县-授权量-同比增长
        /// </summary>
        public DataTable loadSamplePolitAreaAuthorizeNum(DateTime dtStart, DateTime dtEnd, int iType)
        {
            var dataCommand = DataCommandManager.GetDataCommand("loadSamplePolitAreaAuthorizeNum");
            dataCommand.SetParameterValue("@dtStart", dtStart);
            dataCommand.SetParameterValue("@dtEnd", dtEnd);
            dataCommand.SetParameterValue("@iType", iType);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }
        /// <summary>
        /// 区县-申请量排名
        /// </summary>
        public DataTable loadSamplePolitAreaApplyRank(DateTime dtStart, DateTime dtEnd, int iType)
        {
            var dataCommand = DataCommandManager.GetDataCommand("loadSamplePolitAreaApplyRank");
            dataCommand.SetParameterValue("@dtStart", dtStart);
            dataCommand.SetParameterValue("@dtEnd", dtEnd);
            dataCommand.SetParameterValue("@iType", iType);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }
        /// <summary>
        /// 区县-授权量排名
        /// </summary>
        public DataTable loadSamplePolitAreaAuthorizeRank(DateTime dtStart, DateTime dtEnd, int iType)
        {
            var dataCommand = DataCommandManager.GetDataCommand("loadSamplePolitAreaAuthorizeRank");
            dataCommand.SetParameterValue("@dtStart", dtStart);
            dataCommand.SetParameterValue("@dtEnd", dtEnd);
            dataCommand.SetParameterValue("@iType", iType);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }
        /// <summary>
        /// 区县-发明专利申请量排名
        /// </summary>
        public DataTable loadSamplePolitAreaApplyInventRank(DateTime dtStart, DateTime dtEnd, int iType)
        {
            var dataCommand = DataCommandManager.GetDataCommand("loadSamplePolitAreaApplyInventRank");
            dataCommand.SetParameterValue("@dtStart", dtStart);
            dataCommand.SetParameterValue("@dtEnd", dtEnd);
            dataCommand.SetParameterValue("@iType", iType);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }
        /// <summary>
        /// 区县-发明专利授权量排名
        /// </summary>
        public DataTable loadSamplePolitAreaAuthorizeInventRank(DateTime dtStart, DateTime dtEnd, int iType)
        {
            var dataCommand = DataCommandManager.GetDataCommand("loadSamplePolitAreaAuthorizeInventRank");
            dataCommand.SetParameterValue("@dtStart", dtStart);
            dataCommand.SetParameterValue("@dtEnd", dtEnd);
            dataCommand.SetParameterValue("@iType", iType);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }
        /// <summary>
        /// 区域申请
        /// </summary>
        public DataTable loadSamplePolitAreaApplyNumOverRegion(DateTime dtStart, DateTime dtEnd)
        {
            var dataCommand = DataCommandManager.GetDataCommand("loadSamplePolitAreaApplyNumOverRegion");
            dataCommand.SetParameterValue("@dtStart", dtStart);
            dataCommand.SetParameterValue("@dtEnd", dtEnd);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }
        /// <summary>
        /// 区域授权
        /// </summary>
        public DataTable loadSamplePolitAreaAuthorizeNumOverRegion(DateTime dtStart, DateTime dtEnd)
        {
            var dataCommand = DataCommandManager.GetDataCommand("loadSamplePolitAreaAuthorizeNumOverRegion");
            dataCommand.SetParameterValue("@dtStart", dtStart);
            dataCommand.SetParameterValue("@dtEnd", dtEnd);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }
        /// <summary>
        /// 示范、优势企业-申请量-各企业具体数量
        /// </summary>
        /// <param name="dtReportDate"></param>
        /// <param name="iType"></param>
        /// <returns></returns>
        public DataTable loadSampleAdvanceEnterpriseApplyCountList(DateTime dtStart, DateTime dtEnd, int iType)
        {
            var dataCommand = DataCommandManager.GetDataCommand("loadSampleAdvanceEnterpriseApplyCountList");
            dataCommand.SetParameterValue("@iType", iType);
            dataCommand.SetParameterValue("@dtStart", dtStart);
            dataCommand.SetParameterValue("@dtEnd", dtEnd);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }
        /// <summary>
        /// 示范、优势企业-申请量-发明专利-总量
        /// </summary>
        /// <param name="dtReportDate"></param>
        /// <param name="iType"></param>
        /// <returns></returns>
        public DataTable loadSampleAdvanceEnterpriseApplyInventCountTotal(DateTime dtStart, DateTime dtEnd, int iType)
        {
            var dataCommand = DataCommandManager.GetDataCommand("loadSampleAdvanceEnterpriseApplyInventCountTotal");
            dataCommand.SetParameterValue("@iType", iType);
            dataCommand.SetParameterValue("@dtStart", dtStart);
            dataCommand.SetParameterValue("@dtEnd", dtEnd);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }
        /// <summary>
        /// 示范、优势企业-授权量-各企业具体数量
        /// </summary>
        /// <param name="dtReportDate"></param>
        /// <param name="iType"></param>
        /// <returns></returns>
        public DataTable loadSampleAdvanceEnterpriseAuthorizeCountList(DateTime dtStart, DateTime dtEnd, int iType)
        {
            var dataCommand = DataCommandManager.GetDataCommand("loadSampleAdvanceEnterpriseAuthorizeCountList");
            dataCommand.SetParameterValue("@iType", iType);
            dataCommand.SetParameterValue("@dtStart", dtStart);
            dataCommand.SetParameterValue("@dtEnd", dtEnd);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }
        /// <summary>
        /// 示范、优势企业-授权量-发明专利-总量
        /// </summary>
        /// <param name="dtReportDate"></param>
        /// <param name="iType"></param>
        /// <returns></returns>
        public DataTable loadSampleAdvanceEnterpriseAuthorizeInventCountTotal(DateTime dtStart, DateTime dtEnd, int iType)
        {
            var dataCommand = DataCommandManager.GetDataCommand("loadSampleAdvanceEnterpriseAuthorizeInventCountTotal");
            dataCommand.SetParameterValue("@iType", iType);
            dataCommand.SetParameterValue("@dtStart", dtStart);
            dataCommand.SetParameterValue("@dtEnd", dtEnd);
            var result = dataCommand.ExecuteDataSet().Tables[0];
            return result;
        }
        #endregion

        #region 维护数据

        public CRBITBL_HistoryControlResult LoadDataByType(CRBITBL_HistoryControlQuery query)
        {
            var pagingInfo = new PagingInfoEntity();
            pagingInfo.SortField = query.PageInfo.SortFields;
            pagingInfo.StartRowIndex = 1 + query.PageInfo.PageIndex * query.PageInfo.PageSize;
            pagingInfo.MaximumRows = query.PageInfo.PageSize - 1;
            if (pagingInfo.MaximumRows < 0)
            {
                pagingInfo.MaximumRows = 0;
            }
            if (pagingInfo.StartRowIndex < 0)
            {
                pagingInfo.StartRowIndex = 0;
            }
            var dataCommand = DataCommandManager.CreateCustomDataCommandFromConfig("loadSamplePolitInfoByType");
            using (var builder = new DynamicQuerySqlBuilder(dataCommand.CommandText, dataCommand, pagingInfo, "n_ID asc"))
            {
                builder.ConditionConstructor.AddCustomCondition(QueryConditionRelationType.AND, string.Format("n_Type={0}", query.iType));
                dataCommand.CommandText = builder.BuildQuerySql();
            }
            var result = dataCommand.ExecuteEntityList<CRBITBL_HistoryControlTable>();
            var totalCount = Convert.ToInt32(dataCommand.GetParameterValue("@TotalCount"));
            CRBITBL_HistoryControlResult response = new CRBITBL_HistoryControlResult();
            response.DataList = result;
            response.TotalCount = totalCount;
            return response;
        }
        public void DeleteDataByID(int ID)
        {
            var dataCommand = DataCommandManager.GetDataCommand("deleteSamplePolitInfoByID");
            dataCommand.SetParameterValue("@ID", ID);
            dataCommand.ExecuteNonQuery();
        }
        public void Insert(CRBITBL_HistoryControlQuery query)
        {
            var dataCommand = DataCommandManager.GetDataCommand("insertSamplePolitInfo");
            dataCommand.SetParameterValue("@s_ProvinceName", query.sProvinceName);
            dataCommand.SetParameterValue("@n_ProvinceCode", query.iProvinceCode);
            dataCommand.SetParameterValue("@s_CityName", query.sCityName);
            dataCommand.SetParameterValue("@n_CityCode", query.iCityCode);
            dataCommand.SetParameterValue("@s_AreaName", query.sAreaName);
            dataCommand.SetParameterValue("@n_AreaCode", query.iAreaCode);
            dataCommand.SetParameterValue("@dt_Start", query.dateStart);
            dataCommand.SetParameterValue("@dt_End", query.dateEnd);
            dataCommand.SetParameterValue("@s_EnterpriseName", query.sEnterpriseName);
            dataCommand.SetParameterValue("@n_EnterpriseID", query.iEnterpriseID);
            dataCommand.SetParameterValue("@b_IsValid", query.bIsValid);
            dataCommand.SetParameterValue("@n_Type", query.iType);
            dataCommand.ExecuteNonQuery();
        }
        public void Update(CRBITBL_HistoryControlQuery query)
        {
            var dataCommand = DataCommandManager.GetDataCommand("updateSamplePolitInfo");
            dataCommand.SetParameterValue("@ID", query.id);
            dataCommand.SetParameterValue("@s_ProvinceName", query.sProvinceName);
            dataCommand.SetParameterValue("@n_ProvinceCode", query.iProvinceCode);
            dataCommand.SetParameterValue("@s_CityName", query.sCityName);
            dataCommand.SetParameterValue("@n_CityCode", query.iCityCode);
            dataCommand.SetParameterValue("@s_AreaName", query.sAreaName);
            dataCommand.SetParameterValue("@n_AreaCode", query.iAreaCode);
            dataCommand.SetParameterValue("@dt_Start", query.dateStart);
            dataCommand.SetParameterValue("@dt_End", query.dateEnd);
            dataCommand.SetParameterValue("@s_EnterpriseName", query.sEnterpriseName);
            dataCommand.SetParameterValue("@n_EnterpriseID", query.iEnterpriseID);
            dataCommand.SetParameterValue("@b_IsValid", query.bIsValid);
            dataCommand.SetParameterValue("@n_Type", query.iType);
            dataCommand.ExecuteNonQuery();
        }
        public CRBITBL_HistoryControlResult LoadEnterpriseDataByType(int iType)
        {
            var dataCommand = DataCommandManager.GetDataCommand("loadEnterpriseDataByType");
            dataCommand.SetParameterValue("@iType", iType);
            var result = dataCommand.ExecuteEntityList<CRBITBL_HistoryControlTable>();
            CRBITBL_HistoryControlResult response = new CRBITBL_HistoryControlResult();
            response.DataList = result;
            response.TotalCount = result.Count;
            return response;
        }

        private int GetIDFromDT(DataTable dt)
        {
            int iExistID = 0;
            if (dt != null && dt.Rows.Count > 0)
            {
                int.TryParse(dt.Rows[0][0].ToString(), out iExistID);
            }
            return iExistID;
        }
        /// <summary>
        /// 查询是否已存在相同的示范、试点城市记录
        /// </summary>
        /// <returns>如果有重复，则返回重复数据的ID，没重复则返回0</returns>
        public int CheckSamplePolitCityExist(int iCode, int iType)
        {
            var dataCommand = DataCommandManager.GetDataCommand("checkSamplePolitCityExist");
            dataCommand.SetParameterValue("@n_CityCode", iCode);
            dataCommand.SetParameterValue("@n_Type", iType);
            DataTable result = dataCommand.ExecuteDataSet().Tables[0];
            return GetIDFromDT(result);
        }
        /// <summary>
        /// 查询是否已存在相同的示范、试点区县记录
        /// </summary>
        /// <returns>如果有重复，则返回重复数据的ID，没重复则返回0</returns>
        public int CheckSamplePolitAreaExist(int iCityCode, int iAreaCode, int iType)
        {
            var dataCommand = DataCommandManager.GetDataCommand("checkSamplePolitAreaExist");
            dataCommand.SetParameterValue("@n_CityCode", iCityCode);
            dataCommand.SetParameterValue("@n_AreaCode", iAreaCode);
            dataCommand.SetParameterValue("@n_Type", iType);
            DataTable result = dataCommand.ExecuteDataSet().Tables[0];
            return GetIDFromDT(result);
        }
        /// <summary>
        /// 查询是否已存在相同的示范、优势企业记录
        /// </summary>
        /// <returns>如果有重复，则返回重复数据的ID，没重复则返回0</returns>
        public int CheckSampleAdvanceEnterpriseExist(string sEnterpriseName, int iType)
        {
            var dataCommand = DataCommandManager.GetDataCommand("checkSampleAdvanceEnterpriseExist");
            dataCommand.SetParameterValue("@s_EnterpriseName", sEnterpriseName);
            dataCommand.SetParameterValue("@n_Type", iType);
            DataTable result = dataCommand.ExecuteDataSet().Tables[0];
            return GetIDFromDT(result);
        }
        /// <summary>
        /// 事务-删除旧记录，修改新记录
        /// </summary>
        public bool DeleteAndModifyInTransaction(CRBITBL_HistoryControlQuery query, int idModify, int idDelete)
        {
            var dataCommand = DataCommandManager.GetDataCommand("DeleteAndModifySampleInfoInTransaction");
            dataCommand.SetParameterValue("@n_IdDelete", idDelete);
            dataCommand.SetParameterValue("@n_IdModify", idModify);
            dataCommand.SetParameterValue("@s_ProvinceName", query.sProvinceName);
            dataCommand.SetParameterValue("@n_ProvinceCode", query.iProvinceCode);
            dataCommand.SetParameterValue("@s_CityName", query.sCityName);
            dataCommand.SetParameterValue("@n_CityCode", query.iCityCode);
            dataCommand.SetParameterValue("@s_AreaName", query.sAreaName);
            dataCommand.SetParameterValue("@n_AreaCode", query.iAreaCode);
            dataCommand.SetParameterValue("@dt_Start", query.dateStart);
            dataCommand.SetParameterValue("@dt_End", query.dateEnd);
            dataCommand.SetParameterValue("@s_EnterpriseName", query.sEnterpriseName);
            dataCommand.SetParameterValue("@n_EnterpriseID", query.iEnterpriseID);
            dataCommand.SetParameterValue("@b_IsValid", query.bIsValid);
            dataCommand.SetParameterValue("@n_Type", query.iType);
            DataTable result = dataCommand.ExecuteDataSet().Tables[0];
            if (result.Rows[0][0].ToString() == "0")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        #endregion
    }
}

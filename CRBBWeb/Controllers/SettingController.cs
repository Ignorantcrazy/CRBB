using CRBBWeb.Models;
using CRBICommonLib;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace CRBBWeb.Controllers
{
    public class SettingController : Controller
    {
        // GET: Setting
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult CheckDBConnection(DBConnectionViewModel db)
        {
            var json = new JsonResults();
            var rm = new ResultModel();
            bool isConnection = true;
            string connectionStr = "data source=" + db.DBServer + ";initial catalog=" + db.DBName + ";user id=" + db.UserName + ";password=" + db.Password + ";";
            SqlConnection sc = new SqlConnection(connectionStr);
            try
            {
                sc.Open();
                rm.Status = true;
                rm.Result = isConnection;
            }
            catch (Exception ex)
            {
                isConnection = false;
                rm.Message = ex.Message;
                rm.Status = false;
            }
            json.Data = rm;
            return json;
        }

        [HttpPost]
        public JsonResult SaveDBConnection(DBConnectionViewModel db)
        {
            var json = new JsonResults();
            var rm = new ResultModel();
            bool isSave = true;
            string connectionStr = "data source=" + db.DBServer + ";initial catalog=" + db.DBName + ";user id=" + db.UserName + ";password=" + db.Password + ";";
            try
            {
                connectionStr = Utilities.Encrypt(connectionStr);
                string baseDiv = AppDomain.CurrentDomain.BaseDirectory;
                XmlDocument xml = new XmlDocument();
                string filePath = Path.Combine(baseDiv, "bin\\Configuration\\Data\\Database.config");
                xml.Load(filePath);
                var element = xml.DocumentElement;
                element.FirstChild.FirstChild.InnerText = connectionStr;
                //var xmlNode = element.SelectSingleNode(@"/databaseList/database/connectionString");
                //xmlNode.InnerText = connectionStr;
                xml.Save(filePath);
                rm.Status = true;
                rm.Result = isSave;
            }
            catch (Exception ex)
            {
                isSave = false;
                rm.Message = ex.Message;
                rm.Status = false;
            }
            json.Data = rm;
            return json;
        }

        [HttpPost]
        public JsonResult SaveEarlyWarning(VoicePopViewModel vp)
        {
            var json = new JsonResults();
            var rm = new ResultModel();
            bool isSave = true;
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Setting.ini");
                IniFile ini = new IniFile(filePath);
                ini.WriteString("EarlyWarning", "Voice", vp.IsVoice.ToString());
                ini.WriteString("EarlyWarning", "Pop", vp.IsPop.ToString());
                rm.Status = true;
                rm.Result = isSave;
            }
            catch (Exception ex)
            {
                isSave = false;
                rm.Message = ex.Message;
                rm.Status = false;
            }
            json.Data = rm;
            return json;
        }

        [HttpPost]
        public JsonResult SaveWarning(VoicePopViewModel vp)
        {
            var json = new JsonResults();
            var rm = new ResultModel();
            bool isSave = true;
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Setting.ini");
                IniFile ini = new IniFile(filePath);
                ini.WriteString("Warning", "Voice", vp.IsVoice.ToString());
                ini.WriteString("Warning", "Pop", vp.IsPop.ToString());
                rm.Status = true;
                rm.Result = isSave;
            }
            catch (Exception ex)
            {
                isSave = false;
                rm.Message = ex.Message;
                rm.Status = false;
            }
            json.Data = rm;
            return json;
        }

        [HttpPost]
        public JsonResult SaveTips(bool isShow)
        {
            var json = new JsonResults();
            var rm = new ResultModel();
            bool isSave = true;
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Setting.ini");
                IniFile ini = new IniFile(filePath);
                ini.WriteString("Tips", "Show", isShow.ToString());
                //ini.WriteString("Tips", "Dir", dir);
                rm.Status = true;
                rm.Result = isSave;
            }
            catch (Exception ex)
            {
                isSave = false;
                rm.Message = ex.Message;
                rm.Status = false;
            }
            json.Data = rm;
            return json;
        }

        [HttpPost]
        public JsonResult SaveReport(bool isWekly,bool isMonthlyReport,string dir)
        {
            var json = new JsonResults();
            var rm = new ResultModel();
            if (string.IsNullOrEmpty(dir) || string.IsNullOrWhiteSpace(dir))
            {
                rm.Message = "请选择周/月报存储目录";
                rm.Status = false;
            }
            bool isSave = true;
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Setting.ini");
                IniFile ini = new IniFile(filePath);
                ini.WriteString("Report", "Wekly", isWekly.ToString());
                ini.WriteString("Report", "MonthlyReport", isMonthlyReport.ToString());
                ini.WriteString("Report", "Dir", dir);
                rm.Status = true;
                rm.Result = isSave;
            }
            catch (Exception ex)
            {
                isSave = false;
                rm.Message = ex.Message;
                rm.Status = false;
            }
            json.Data = rm;
            return json;
        }
    }
}
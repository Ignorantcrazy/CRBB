
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using CRBIReportLib.ReportBase;
//using CRBISmartReportToolLib;
namespace CRBIReportTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string sAppPath = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo dirBase = new DirectoryInfo(sAppPath);
            DirectoryInfo dirRoot = dirBase.Parent.Parent;
            string sRoot = dirRoot.FullName;
            Stopwatch timer = new Stopwatch();
            timer.Start();
             //测试数据
            //健康周报
            Console.WriteLine(string.Format("CR-BI数据查询框架开始执行：{0}", DateTime.Now.ToString()));
            Console.WriteLine("查询健康周报");
            CRBIYYBBReportProjectRule.Intance().GetHealthweeklyData();
            Console.WriteLine("查询区域级近一周整体健康状态");
            CRBIYYBBReportProjectRule.Intance().LoadData_A_7D_ZTJKZT(new CRBIHttpContextQuery() { });
            Console.WriteLine("区域级告警处理时效性分析");
            CRBIYYBBReportProjectRule.Intance().LoadData_A_AlarmDisposeTimes(new CRBIHttpContextQuery());
            Console.WriteLine("区域级告警分布");
            CRBIYYBBReportProjectRule.Intance().LoadData_A_AlarmDistribution(new CRBIHttpContextQuery());
            Console.WriteLine("区域级重点关注下周告警分布");
            CRBIYYBBReportProjectRule.Intance().LoadData_A_AlarmDistribution_NextWeek(new CRBIHttpContextQuery());
            Console.WriteLine("区域级综合保障能力");
            CRBIYYBBReportProjectRule.Intance().LoadData_A_ZHBBNL(new CRBIHttpContextQuery());

            Console.WriteLine("站点级综合保障能力");
            CRBIYYBBReportProjectRule.Intance().LoadData_S_ZHBBNL(new CRBIHttpContextQuery());
            Console.WriteLine("区域级综合评估雷达");
            CRBIYYBBReportProjectRule.Intance().LoadData_A_ZHPGLD(new CRBIHttpContextQuery());
            Console.WriteLine("站点级综合评估雷达");
            CRBIYYBBReportProjectRule.Intance().LoadData_S_ZHPGLD(new CRBIHttpContextQuery());
            Console.WriteLine("区域级无故障运行天数");
            CRBIYYBBReportProjectRule.Intance().LoadData_A_WGZYXTS(new CRBIHttpContextQuery());
            Console.WriteLine("站点级无故障运行天数");
            CRBIYYBBReportProjectRule.Intance().LoadData_S_WGZYXTS(new CRBIHttpContextQuery());
            Console.WriteLine("获取零故障设备");
            CRBIYYBBReportProjectRule.Intance().LoadData_A_S_ZeroBugMachine(new CRBIHttpContextQuery());
            Console.WriteLine("获取零故障设备");
            CRBIYYBBReportProjectRule.Intance().LoadData_S_ZeroBugMachine(new CRBIHttpContextQuery());



            Console.WriteLine("获取区域级零故障设备厂商");
            CRBIYYBBReportProjectRule.Intance().LoadData_A_ZeroBugFactory(new CRBIHttpContextQuery());
            Console.WriteLine("获取站点级零故障设备厂商");
            CRBIYYBBReportProjectRule.Intance().LoadData_S_ZeroBugFactory(new CRBIHttpContextQuery());
            Console.WriteLine("区域级告警分布");
            CRBIYYBBReportProjectRule.Intance().LoadData_A_AlarmDistribution(new CRBIHttpContextQuery());
            Console.WriteLine("站点级告警分布");
            CRBIYYBBReportProjectRule.Intance().LoadData_S_AlarmDistribution(new CRBIHttpContextQuery());
            Console.WriteLine("站点级获取一周告警分布");
            CRBIYYBBReportProjectRule.Intance().LoadData_S_AlarmDistributionByDate_1Week(new CRBIHttpContextQuery());
            Console.WriteLine("站点级获取一周活动告警分布");
            CRBIYYBBReportProjectRule.Intance().LoadData_S_ActiveAlarmDistributionByDate_1Week(new CRBIHttpContextQuery());
            Console.WriteLine("站点级获取各站点历史告警统计");
            CRBIYYBBReportProjectRule.Intance().LoadData_S_HistoryAlarmCountByMonth(new CRBIHttpContextQuery());
            Console.WriteLine("区域级告警处理时效性分析");
            CRBIYYBBReportProjectRule.Intance().LoadData_A_AlarmDisposeTimes(new CRBIHttpContextQuery());
            Console.WriteLine("站点级告警处理时效性分析");
            CRBIYYBBReportProjectRule.Intance().LoadData_S_AlarmDisposeTimes(new CRBIHttpContextQuery());
           

            Console.WriteLine("区域级重点关注下周告警分布");
            CRBIYYBBReportProjectRule.Intance().LoadData_A_AlarmDistribution_NextWeek(new CRBIHttpContextQuery());
            Console.WriteLine("站点级重点关注下周告警分布");
            CRBIYYBBReportProjectRule.Intance().LoadData_S_AlarmDistribution_NextWeek(new CRBIHttpContextQuery());
            Console.WriteLine("站点级重点关注设备");
            CRBIYYBBReportProjectRule.Intance().LoadData_S_VIPMachine(new CRBIHttpContextQuery());
            Console.WriteLine("站点级维护任务燃尽图");
            CRBIYYBBReportProjectRule.Intance().LoadData_S_TaskBrunDownChart(new CRBIHttpContextQuery());
            Console.WriteLine("站点级每日知识");
            CRBIYYBBReportProjectRule.Intance().LoadData_S_DailyKnowledge(new CRBIHttpContextQuery());
            Console.WriteLine("站点级维护计划");
            CRBIYYBBReportProjectRule.Intance().LoadData_S_TodoTask(new CRBIHttpContextQuery());
            Console.WriteLine("站点设备信息");
            CRBIYYBBReportProjectRule.Intance().LoadData_S_MachineInfo(new CRBIHttpContextQuery());
            Console.WriteLine("区域级支撑时间");
            CRBIYYBBReportProjectRule.Intance().LoadData_A_SupportTime(new CRBIHttpContextQuery());
            Console.WriteLine("站点级支撑时间");
            CRBIYYBBReportProjectRule.Intance().LoadData_S_SupportTime(new CRBIHttpContextQuery());

            Console.WriteLine("服务器信息");
            CRBIYYBBReportProjectRule.Intance().LoadData_IMUInfo(new CRBIHttpContextQuery());
            Console.WriteLine("当前值机信息");
            CRBIYYBBReportProjectRule.Intance().LoadData_CurrentPCinfo(new CRBIHttpContextQuery());
            Console.WriteLine("......");

            Console.WriteLine(string.Format("CR-BI数据查询框架结束执行：{0}", DateTime.Now.ToString()));
            Console.WriteLine("按“Y/y”结束执行");
            string str = Console.ReadLine();
            if (str.Equals("y") || str.Equals("Y"))
            {
                Console.WriteLine("结束执行！");
            }
            else
            {
                #region 报表相关
                //string sDocTemplatePath = Path.Combine(sRoot, "Templates", "专利申请授权情况简报（简版）.docx");
                //string sXmlFilePath = Path.Combine(sRoot, "XmlConfigs", "GDPAPatentReport_Simple_Config.XML");
                //string sReflectdFuncLib = "GDPASmartReportToolLib.GDPAReflectedFuncLib_Simple";

                //专利申请授权情况简报（完整版）.docx                      原模板 
                //1专利申请授权情况简报（完整版）.docm                  使用宏更新目录的模板
                //2专利申请授权情况简报（完整版） - 副本.docx        修改了XML结构以更新目录的模板

                string sDocTemplatePath = Path.Combine(sRoot, "Templates", "专利申请授权情况简报（完整版）.docm");
                string sXmlFilePath = Path.Combine(sRoot, "XmlConfigs", "GDPAPatentReport_Complete_Config.XML");
                string sReflectdFuncLib = "GDPASmartReportToolLib.GDPAReflectedFuncLib_Complete";

                sDocTemplatePath = Path.Combine(sRoot, "Templates", "柯蓝蓄电池充电测试报告.docm");
                sXmlFilePath = Path.Combine(sRoot, "XmlConfigs", "CRBIReport_Charge_1_Config.XML");
                sReflectdFuncLib = "CRBISmartReportToolLib.CRBIReflectedFunction_Charge_1";

                string sExcelTemplatePath = Path.Combine(sRoot, "Templates", "GDPATempExcelTemplate.xlsx");
                string sReportSaveDir = "d:\\OpenXmlTest";
                CRBIConst.SetDateTime(DateTime.Parse("2017-1-1"), DateTime.Parse("2017-9"));
                CRBIConst.const_LogPath = Path.Combine(sReportSaveDir, CRBIConst.const_LogParentDir, CRBIConst.const_LogName);



                //CRBIDocumentProcessor processor = new CRBIDocumentProcessor
                //                                     (sDocTemplatePath, sXmlFilePath, sExcelTemplatePath, sReflectdFuncLib, true, sReportSaveDir);
                //processor.GenerateDocx();
                #endregion

            }
           

            timer.Stop();
            Console.WriteLine(string.Format("用时{0}毫秒", timer.ElapsedMilliseconds));
            Console.ReadKey();
        }
    }
}

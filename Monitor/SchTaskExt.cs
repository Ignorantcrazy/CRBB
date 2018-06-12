using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskScheduler;

namespace Monitor
{
    public class SchTaskExt
    {
        /// <summary>
        /// delete task
        /// </summary>
        /// <param name="taskName"></param>
        private static void DeleteTask(string taskName)
        {
            TaskSchedulerClass ts = new TaskSchedulerClass();
            ts.Connect(null, null, null, null);
            ITaskFolder folder = ts.GetFolder("\\");
            folder.DeleteTask(taskName, 0);
        }

        /// <summary>
        /// get all tasks
        /// </summary>
        public static IRegisteredTaskCollection GetAllTasks()
        {
            TaskSchedulerClass ts = new TaskSchedulerClass();
            ts.Connect(null, null, null, null);
            ITaskFolder folder = ts.GetFolder("\\");
            IRegisteredTaskCollection tasks_exists = folder.GetTasks(1);
            return tasks_exists;
        }
        /// <summary>
        /// check task isexists
        /// </summary>
        /// <param name="taskName"></param>
        /// <returns></returns>
        public static bool IsExists(string taskName)
        {
            var isExists = false;
            IRegisteredTaskCollection tasks_exists = GetAllTasks();
            for (int i = 1; i <= tasks_exists.Count; i++)
            {
                IRegisteredTask t = tasks_exists[i];
                if (t.Name.Equals(taskName))
                {
                    isExists = true;
                    break;
                }
            }
            return isExists;
        }

        /// <summary>
        /// create task
        /// </summary>
        /// <param name="creator"></param>
        /// <param name="taskName"></param>
        /// <param name="path"></param>
        /// <param name="interval"></param>
        /// <returns>state</returns>
        public static _TASK_STATE CreateDailyTaskScheduler(string creator, string taskName, string path,string startDate)
        {
            try
            {
                if (IsExists(taskName))
                {
                    DeleteTask(taskName);
                }

                TaskSchedulerClass scheduler = new TaskSchedulerClass();
                scheduler.Connect(null, null, null, null);
                ITaskFolder folder = scheduler.GetFolder("\\");


                ITaskDefinition task = scheduler.NewTask(0);
                task.RegistrationInfo.Author = creator;
                task.RegistrationInfo.Description = "每日小知识";

                IDailyTrigger dt = (IDailyTrigger)task.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_DAILY);
                dt.DaysInterval = 1;
                dt.StartBoundary = DateTime.Parse(startDate).ToString("yyyy-MM-ddTHH:mm:ss");//start time

                IExecAction action = (IExecAction)task.Actions.Create(_TASK_ACTION_TYPE.TASK_ACTION_EXEC);
                action.Path = path;//path;

                task.Settings.ExecutionTimeLimit = "PT0S"; 
                task.Settings.DisallowStartIfOnBatteries = false;
                task.Settings.RunOnlyIfIdle = false;

                IRegisteredTask regTask = folder.RegisterTaskDefinition(taskName, task,
                                                                    (int)_TASK_CREATION.TASK_CREATE, null, //user
                                                                    null, // password
                                                                    _TASK_LOGON_TYPE.TASK_LOGON_INTERACTIVE_TOKEN,
                                                                    "");
                IRunningTask runTask = regTask.Run(null);
                return runTask.State;

            }
            catch (Exception ex)
            {
                return _TASK_STATE.TASK_STATE_RUNNING;
            }

        }

        /// <summary>
        /// create task
        /// </summary>
        /// <param name="creator"></param>
        /// <param name="taskName"></param>
        /// <param name="path"></param>
        /// <param name="interval"></param>
        /// <returns>state</returns>
        public static _TASK_STATE CreateWeeklyTaskScheduler(string creator, string taskName, string path, string startDate)
        {
            try
            {
                if (IsExists(taskName))
                {
                    DeleteTask(taskName);
                }

                //new scheduler
                TaskSchedulerClass scheduler = new TaskSchedulerClass();
                //pc-name/ip,username,domain,password
                scheduler.Connect(null, null, null, null);
                //get scheduler folder
                ITaskFolder folder = scheduler.GetFolder("\\");


                //set base attr 
                ITaskDefinition task = scheduler.NewTask(0);
                task.RegistrationInfo.Author = creator;//creator
                task.RegistrationInfo.Description = "周报";//description

                IWeeklyTrigger wt = (IWeeklyTrigger)task.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_WEEKLY);
                wt.WeeksInterval = 1;
                wt.DaysOfWeek = 5;
                wt.StartBoundary = DateTime.Parse(startDate).ToString("yyyy-MM-ddTHH:mm:ss");//start time

                //set action
                IExecAction action = (IExecAction)task.Actions.Create(_TASK_ACTION_TYPE.TASK_ACTION_EXEC);
                action.Path = path;

                task.Settings.ExecutionTimeLimit = "PT0S"; //运行任务时间超时停止任务吗? PTOS 不开启超时
                task.Settings.DisallowStartIfOnBatteries = false;//只有在交流电源下才执行
                task.Settings.RunOnlyIfIdle = false;//仅当计算机空闲下才执行

                IRegisteredTask regTask = folder.RegisterTaskDefinition(taskName, task,
                                                                    (int)_TASK_CREATION.TASK_CREATE, null, //user
                                                                    null, // password
                                                                    _TASK_LOGON_TYPE.TASK_LOGON_INTERACTIVE_TOKEN,
                                                                    "");
                IRunningTask runTask = regTask.Run(null);
                return runTask.State;

            }
            catch (Exception ex)
            {
                return _TASK_STATE.TASK_STATE_RUNNING;
            }

        }

        public static _TASK_STATE CreateMonthlyTaskScheduler(string creator, string taskName, string path, string startDate)
        {
            try
            {
                if (IsExists(taskName))
                {
                    DeleteTask(taskName);
                }

                //new scheduler
                TaskSchedulerClass scheduler = new TaskSchedulerClass();
                //pc-name/ip,username,domain,password
                scheduler.Connect(null, null, null, null);
                //get scheduler folder
                ITaskFolder folder = scheduler.GetFolder("\\");


                //set base attr 
                ITaskDefinition task = scheduler.NewTask(0);
                task.RegistrationInfo.Author = creator;//creator
                task.RegistrationInfo.Description = "月报";//description

                IMonthlyTrigger mt = (IMonthlyTrigger)task.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_MONTHLY);
                mt.RunOnLastDayOfMonth = true;
                mt.StartBoundary = DateTime.Parse(startDate).ToString("yyyy-MM-ddTHH:mm:ss");//start time

                //set action
                IExecAction action = (IExecAction)task.Actions.Create(_TASK_ACTION_TYPE.TASK_ACTION_EXEC);
                action.Path = path;

                task.Settings.ExecutionTimeLimit = "PT0S"; //运行任务时间超时停止任务吗? PTOS 不开启超时
                task.Settings.DisallowStartIfOnBatteries = false;//只有在交流电源下才执行
                task.Settings.RunOnlyIfIdle = false;//仅当计算机空闲下才执行

                IRegisteredTask regTask = folder.RegisterTaskDefinition(taskName, task,
                                                                    (int)_TASK_CREATION.TASK_CREATE, null, //user
                                                                    null, // password
                                                                    _TASK_LOGON_TYPE.TASK_LOGON_INTERACTIVE_TOKEN,
                                                                    "");
                IRunningTask runTask = regTask.Run(null);
                return runTask.State;

            }
            catch (Exception ex)
            {
                return _TASK_STATE.TASK_STATE_RUNNING;
            }

        }
    }
}

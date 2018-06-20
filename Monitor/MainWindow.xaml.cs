using Monitor.ViewModels;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using TaskScheduler;

namespace Monitor
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private int contentx = 25;
        private int labelx = 30;
        private int ballx = 80;
        private int sideThickness = 30;
        private NotifyIcon notifyIcon;
        private SafeguardAbilityWindow safeguardAbilityWindow;
        private PopBoxs popBoxs;
        private System.Windows.Threading.DispatcherTimer readDataTimer;
        private System.Timers.Timer pollingBroadcastTimer = null;
        private bool isRatingMode = true;
        public MainWindow()
        {
            Process[] pro = Process.GetProcessesByName("Monitor");
            if (pro.Length > 1)
            {
                this.Close();
            }

            InitializeComponent();
            WindowLoad();
        }

        private void WindowLoad()
        {
            try
            {
                var model = ApiTools<ApiResultModel<ViewModels.Y_EngineRoomScoreViewModel>>.ReadAsObjAsync("api/EngineRoomScore");
                label.Text = Enum.GetName(typeof(GradeEnum), model.Obj.ScoreLevel);
                BallBackgroundColor(model.Obj.ScoreLevel);
                labelScore.Text = model.Obj.EngineRoomScore.ToString();
            }
            catch (Exception ex)
            {
                this.notifyIcon = new NotifyIcon();
                this.notifyIcon.BalloonTipText = "站点联网异常";
                this.notifyIcon.ShowBalloonTip(2000);
                this.notifyIcon.Text = "站点联网异常";
                this.notifyIcon.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Images\\notifyIco\\notify-16-4.ico"));
                this.notifyIcon.Visible = true;
                System.Windows.Forms.MenuItem exitex = new System.Windows.Forms.MenuItem("退出");
                exitex.Click += new EventHandler(Close);
                System.Windows.Forms.MenuItem[] childenex = new System.Windows.Forms.MenuItem[] { exitex };
                notifyIcon.ContextMenu = new System.Windows.Forms.ContextMenu(childenex);
                grid1.ContextMenu = null;
                this.WindowStartupLocation = WindowStartupLocation.Manual;
                this.Left = SystemParameters.WorkArea.Width - sideThickness - 150;
                label.Text = "异常";
                Color startcolor = (Color)ColorConverter.ConvertFromString("red");
                Color endcolor = (Color)ColorConverter.ConvertFromString("red");
                ball.Fill = new LinearGradientBrush(startcolor, endcolor, 45);
                labelScore.Text = "站点联网";
                return;
            }
            this.notifyIcon = new NotifyIcon();
            this.notifyIcon.BalloonTipText = "系统监控中... ...";
            this.notifyIcon.ShowBalloonTip(2000);
            this.notifyIcon.Text = "系统监控中... ...";
            this.notifyIcon.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Images\\notifyIco\\notify-16-4.ico"));
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += NotifyIcon_DoubleClick;
            System.Windows.Forms.MenuItem exit = new System.Windows.Forms.MenuItem("退出");
            exit.Click += new EventHandler(Close);
            System.Windows.Forms.MenuItem psew = new System.Windows.Forms.MenuItem("预警系统");
            psew.Click += new EventHandler(psewClick);
            System.Windows.Forms.MenuItem SafeguardAbility = new System.Windows.Forms.MenuItem("打开保镖");
            SafeguardAbility.Click += new EventHandler(SafeguardAbilityClick);
            System.Windows.Forms.MenuItem IsSuspensionWindowShow = new System.Windows.Forms.MenuItem("显示/隐藏悬浮窗体");
            IsSuspensionWindowShow.Click += new EventHandler(IsSuspensionWindowShowClick);
            System.Windows.Forms.MenuItem[] childen = new System.Windows.Forms.MenuItem[] { SafeguardAbility, psew, IsSuspensionWindowShow, exit };
            notifyIcon.ContextMenu = new System.Windows.Forms.ContextMenu(childen);
            this.WindowStartupLocation = WindowStartupLocation.Manual;
            this.Left = SystemParameters.WorkArea.Width - sideThickness;
            

            //label.Text = "优";
            //labelScore.Text = "100";

            string quartz = System.Configuration.ConfigurationManager.AppSettings["Quartz"];
            readDataTimer = new System.Windows.Threading.DispatcherTimer();
            readDataTimer.Tick += new EventHandler(TimeCycle);
            readDataTimer.Interval = new TimeSpan(int.Parse(quartz.Split('-')[0]), int.Parse(quartz.Split('-')[1]), int.Parse(quartz.Split('-')[2]), int.Parse(quartz.Split('-')[3]));
            readDataTimer.Start();

            string tipsDoStr = System.Configuration.ConfigurationManager.AppSettings["tips"];
            DateTime tipsTime = DateTime.Parse(tipsDoStr);
            SchTaskExt.CreateDailyTaskScheduler("CRBB", "TipsMissionPlan", System.Configuration.ConfigurationManager.AppSettings["TipsMissionPlan"], tipsTime.ToString());

            //string weeklyDoStr = System.Configuration.ConfigurationManager.AppSettings["reports"];
            //DateTime weeklyTime = DateTime.Parse(weeklyDoStr);
            //SchTaskExt.CreateDailyTaskScheduler("CRBB", "WeeklyMissionPlan", System.Configuration.ConfigurationManager.AppSettings["WeeklyMissionPlan"], weeklyTime.ToString());

            //string monthlyDoStr = System.Configuration.ConfigurationManager.AppSettings["reports"];
            //DateTime monthlyTime = DateTime.Parse(monthlyDoStr);
            //SchTaskExt.CreateDailyTaskScheduler("CRBB", "MonthlyReportMissionPlan", System.Configuration.ConfigurationManager.AppSettings["MonthlyReportMissionPlan"], monthlyTime.ToString());
            OpenSafeguardAbilitryWindow();

        }

        private void TimeCycle(object sender, EventArgs e)
        {
            var model = ApiTools<ApiResultModel<bool>>.ReadAsObjAsync("api/IsPop");
            if (model.Status)
            {
                if (pollingBroadcastTimer != null)
                {
                    pollingBroadcastTimer.Stop();
                    pollingBroadcastTimer.Dispose();
                    pollingBroadcastTimer = null;
                }
                OpenPopBoxs();
            }
            else
            {
                PollingBroadcast();
            }
            if (isRatingMode)
            {
                GetRatingMode();
            }
            else
            {
                GetMonitoringMode();
            }
        }

        private void PollingBroadcast()
        {
            var model = ApiTools<ApiResultModel<System.Collections.Generic.List<Y_WarnFaultViewModels>>>.ReadAsObjAsync("api/PollingBroadcastItems");
            var ewModel = ApiTools<ApiResultModel<System.Collections.Generic.List<Y_EarlyWarningViewModels>>>.ReadAsObjAsync("api/EWarningPollingBroadcastItems");
            if ((model.Status && model.Obj.Count > 0) || (ewModel.Status && ewModel.Obj.Count > 0))
            {
                if (pollingBroadcastTimer == null)
                {
                    pollingBroadcastTimer = new System.Timers.Timer();
                    string quartz = System.Configuration.ConfigurationManager.AppSettings["WarningQuartz"];
                    double interval = int.Parse(quartz.Split('-')[0]) * 24 * 60 * 60 * 1000;
                    interval = interval+(int.Parse(quartz.Split('-')[1]) * 60 * 60 * 1000);
                    interval = interval + (int.Parse(quartz.Split('-')[2]) * 60 * 1000);
                    interval = interval +( int.Parse(quartz.Split('-')[3]) * 1000);
                    pollingBroadcastTimer.Interval = interval;
                    pollingBroadcastTimer.AutoReset = false;
                    pollingBroadcastTimer.Elapsed += delegate
                    {
                        System.Collections.Generic.List<string> list = new System.Collections.Generic.List<string>();
                        if (model.Status && model.Obj.Count > 0)
                        {
                            foreach (var item in model.Obj)
                            {
                                list.Add(item.EventName + ":" + item.ExpertAdvice);
                            }
                        }
                        if (ewModel.Status && ewModel.Obj.Count > 0)
                        {
                            foreach (var item in ewModel.Obj)
                            {
                                list.Add(item.EWarnText + ":" + item.ExpertAdvice);
                            }
                        }
                        if (list.Count > 0)
                        {
                            Process[] pro = Process.GetProcessesByName("PollingBroadcastSpeech");
                            if (pro.Length != 1)
                            {
                                System.Diagnostics.Process.Start(System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "PollingBroadcastSpeech.exe"), string.Join(" ", list.ToArray()));
                            }
                        }
                        pollingBroadcastTimer.Stop();
                        pollingBroadcastTimer.Dispose();
                        pollingBroadcastTimer = null;
                    };
                    pollingBroadcastTimer.Start();
                }
            }
        }

        private void GetRatingMode()
        {
            var model = ApiTools<ApiResultModel<ViewModels.Y_EngineRoomScoreViewModel>>.ReadAsObjAsync("api/EngineRoomScore");
            label.Text = Enum.GetName(typeof(GradeEnum), model.Obj.ScoreLevel);
            BallBackgroundColor(model.Obj.ScoreLevel);
            labelScore.Text = model.Obj.EngineRoomScore.ToString();
        }

        private void BallBackgroundColor(int scoreLevel)
        {
            Color startcolor, endcolor;
            switch ((GradeEnum)scoreLevel)
            {
                case GradeEnum.优:
                    startcolor = (Color)ColorConverter.ConvertFromString("green");
                    endcolor = (Color)ColorConverter.ConvertFromString("green");
                    ball.Fill = new LinearGradientBrush(startcolor, endcolor, 45);
                    break;
                case GradeEnum.良:
                    startcolor = (Color)ColorConverter.ConvertFromString("yellow");
                    endcolor = (Color)ColorConverter.ConvertFromString("yellow");
                    ball.Fill = new LinearGradientBrush(startcolor, endcolor, 45);
                    break;
                case GradeEnum.中:
                    startcolor = (Color)ColorConverter.ConvertFromString("orange");
                    endcolor = (Color)ColorConverter.ConvertFromString("orange");
                    ball.Fill = new LinearGradientBrush(startcolor, endcolor, 45);
                    break;
                case GradeEnum.差:
                    startcolor = (Color)ColorConverter.ConvertFromString("red");
                    endcolor = (Color)ColorConverter.ConvertFromString("red");
                    ball.Fill = new LinearGradientBrush(startcolor, endcolor, 45);
                    break;
                default:
                    break;
            }
        }

        private void GetMonitoringMode()
        {
            var model = ApiTools<ApiResultModel<MonitoringModeViewModel>>.ReadAsObjAsync("api/MonitoringMode");
            label.Text = model.Obj.Text;
            Color startcolor, endcolor;
            switch (model.Obj.Text)
            {
                case "告警":
                    startcolor = (Color)ColorConverter.ConvertFromString("red");
                    endcolor = (Color)ColorConverter.ConvertFromString("red");
                    ball.Fill = new LinearGradientBrush(startcolor, endcolor, 45);
                    break;
                case "预警":
                    startcolor = (Color)ColorConverter.ConvertFromString("yellow");
                    endcolor = (Color)ColorConverter.ConvertFromString("yellow");
                    ball.Fill = new LinearGradientBrush(startcolor, endcolor, 45);
                    break;
                case "正常":
                    startcolor = (Color)ColorConverter.ConvertFromString("green");
                    endcolor = (Color)ColorConverter.ConvertFromString("green");
                    ball.Fill = new LinearGradientBrush(startcolor, endcolor, 45);
                    break;
                default:
                    break;
            }
            labelScore.Text = model.Obj.Count.ToString();
        }

        private void OpenPopBoxs()
        {
            if (popBoxs != null)
            {
                if (popBoxs.IsClose)
                {
                    popBoxs = new PopBoxs();
                    popBoxs.Show();
                }
                else
                {
                    popBoxs.Close();
                    popBoxs = new PopBoxs();
                    popBoxs.Show();
                }
            }
            else
            {
                popBoxs = new PopBoxs();
                popBoxs.Show();
            }
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            OpenSafeguardAbilitryWindow();
        }

        private void OpenSafeguardAbilitryWindow()
        {
            if (safeguardAbilityWindow != null)
            {
                if (safeguardAbilityWindow.IsClose)
                {
                    safeguardAbilityWindow = new SafeguardAbilityWindow();
                    safeguardAbilityWindow.Show();
                }
            }
            else
            {
                safeguardAbilityWindow = new SafeguardAbilityWindow();
                safeguardAbilityWindow.Show();
            }
        }

        private int GetQuartzTime(int hour, int min, int sen)
        {
            return hour * 60 * 60 + min * 60 + sen;
        }

        private void psewClick(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "chrome.exe";
            p.StartInfo.Arguments = System.Configuration.ConfigurationManager.AppSettings["psewUrl"];
            p.Start();
        }

        private void SafeguardAbilityClick(object sender, EventArgs e)
        {
            OpenSafeguardAbilitryWindow();
        }

        private void IsSuspensionWindowShowClick(object sender, EventArgs e)
        {
            if (this.Visibility == Visibility.Hidden)
            {
                this.Show();
            }
            else
            {
                this.Hide();
            }
        }

        private void Close(object sender, EventArgs e)
        {
            Process[] pro = Process.GetProcessesByName("PollingBroadcastSpeech");
            if (pro.Length > 0)
            {
                pro[0].Kill();
            }
            System.Windows.Application.Current.Shutdown();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        protected override void OnSourceInitialized(EventArgs e)
        {
            base.OnSourceInitialized(e);
            this.win_SourceInitialized(this, e);
        }

        private void win_SourceInitialized(object sender, EventArgs e)
        {
            HwndSource hwndSource = PresentationSource.FromVisual(this) as HwndSource;
            if (hwndSource != null)
            {
                hwndSource.AddHook(new HwndSourceHook(WndProc));
            }
        }

        private IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            switch (msg)
            {
                case 1:
                    handled = true;
                    break;
                default: break;
            }
            return (System.IntPtr)0;
        }

        private void MainWindow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //MaintenanceShiftWindow ms = new MaintenanceShiftWindow();
            //ms.Show();
            //OpenSafeguardAbilitryWindow();
        }

        private void MainWindow_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            
            if (this.Left <= 0)
            {
                this.Left = -(this.Width - sideThickness);
                content.RenderTransformOrigin = new Point(0.5, 0.5);
                TranslateTransform tltf = new TranslateTransform();
                tltf.X = -contentx;
                tltf.Y = 0;
                TransformGroup trfg = new TransformGroup();
                trfg.Children.Add(tltf);
                content.RenderTransform = trfg;

                //label.RenderTransformOrigin = new Point(0.5, 0.5);
                //tltf = new TranslateTransform();
                //tltf.X = -labelx;
                //tltf.Y = 0;
                //trfg = new TransformGroup();
                //trfg.Children.Add(tltf);
                //label.RenderTransform = trfg;

                ball.RenderTransformOrigin = new Point(0.5, 0.5);
                tltf = new TranslateTransform();
                tltf.X = ballx;
                tltf.Y = 0;
                trfg = new TransformGroup();
                trfg.Children.Add(tltf);
                ball.RenderTransform = trfg;
            }
            if (this.Left >= SystemParameters.WorkArea.Width - this.Width)
            {
                this.Left = SystemParameters.WorkArea.Width - sideThickness;
            }
            if (this.Top <= 0)
            {
                this.Top = -sideThickness;
                grid1.RenderTransformOrigin = new Point(0.5, 0.5);
                RotateTransform rtf = new RotateTransform();
                rtf.CenterX = 0;
                rtf.CenterY = 0;
                rtf.Angle = 270;
                TranslateTransform ttf = new TranslateTransform();
                ttf.X = 0;
                ttf.Y = -43;
                TransformGroup tfg = new TransformGroup();
                tfg.Children.Add(rtf);
                tfg.Children.Add(ttf);
                grid1.RenderTransform = tfg;
            }

        }

        private void MainWindow_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {

            if (this.Left <= 0)
            {
                this.Left = 0;
                content.RenderTransformOrigin = new Point(0.5, 0.5);
                TranslateTransform tltf = new TranslateTransform();
                tltf.X = 5;
                tltf.Y = 0;
                TransformGroup trfg = new TransformGroup();
                trfg.Children.Add(tltf);
                content.RenderTransform = trfg;

                label.RenderTransformOrigin = new Point(0.5, 0.5);
                tltf = new TranslateTransform();
                tltf.X = 5;
                tltf.Y = 0;
                trfg = new TransformGroup();
                trfg.Children.Add(tltf);
                label.RenderTransform = trfg;

                ball.RenderTransformOrigin = new Point(0.5, 0.5);
                tltf = new TranslateTransform();
                tltf.X = 6;
                tltf.Y = 0;
                trfg = new TransformGroup();
                trfg.Children.Add(tltf);
                ball.RenderTransform = trfg;
            }
            if (this.Left >= SystemParameters.WorkArea.Width - this.Width)
            {
                this.Left = SystemParameters.WorkArea.Width - this.Width;
            }

            if (this.Top <= 0)
            {
                this.Top = 0;
                grid1.RenderTransformOrigin = new Point(0.5, 0.5);
                RotateTransform rtf = new RotateTransform();
                rtf.CenterX = 0;
                rtf.CenterY = 0;
                rtf.Angle = 0;
                TranslateTransform ttf = new TranslateTransform();
                ttf.X = 0;
                ttf.Y = 0;
                TransformGroup tfg = new TransformGroup();
                tfg.Children.Add(rtf);
                tfg.Children.Add(ttf);
                grid1.RenderTransform = tfg;
            }
        }

        private void MainWindow_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            //Point p = Mouse.GetPosition(e.Source as FrameworkElement);
            //if (p.X < this.Width && p.X > 40 && (p.Y < this.Height + 20))
            //{
            //    return;
            //}
            Thread.Sleep(500);
            if (this.Left <= 0)
            {
                this.Left = -(this.Width - sideThickness);
                content.RenderTransformOrigin = new Point(0.5, 0.5);
                TranslateTransform tltf = new TranslateTransform();
                tltf.X = -contentx;
                tltf.Y = 0;
                TransformGroup trfg = new TransformGroup();
                trfg.Children.Add(tltf);
                content.RenderTransform = trfg;

                label.RenderTransformOrigin = new Point(0.5, 0.5);
                tltf = new TranslateTransform();
                tltf.X = -labelx;
                tltf.Y = 0;
                trfg = new TransformGroup();
                trfg.Children.Add(tltf);
                label.RenderTransform = trfg;

                ball.RenderTransformOrigin = new Point(0.5, 0.5);
                tltf = new TranslateTransform();
                tltf.X = ballx;
                tltf.Y = 0;
                trfg = new TransformGroup();
                trfg.Children.Add(tltf);
                ball.RenderTransform = trfg;
            }
            if (this.Left >= SystemParameters.WorkArea.Width - this.Width)
            {
                this.Left = SystemParameters.WorkArea.Width - sideThickness;
            }
            if (this.Top <= 0)
            {
                this.Top = -sideThickness;
                grid1.RenderTransformOrigin = new Point(0.5, 0.5);
                RotateTransform rtf = new RotateTransform();
                rtf.CenterX = 0;
                rtf.CenterY = 0;
                rtf.Angle = 270;
                TranslateTransform ttf = new TranslateTransform();
                ttf.X = 0;
                ttf.Y = -43;
                TransformGroup tfg = new TransformGroup();
                tfg.Children.Add(rtf);
                tfg.Children.Add(ttf);
                grid1.RenderTransform = tfg;
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.MenuItem mi = (System.Windows.Controls.MenuItem)sender;
            switch (mi.Header.ToString())
            {
                case "打开运维保镖":
                    OpenSafeguardAbilitryWindow();
                    break;
                case "切换至监控模式":
                    isRatingMode = false;
                    GetMonitoringMode();
                    break;
                case "切换至评分模式":
                    isRatingMode = true;
                    GetRatingMode();
                    break;
                case "本次隐藏":
                    this.Hide();
                    break;
            }
        }
    }
}

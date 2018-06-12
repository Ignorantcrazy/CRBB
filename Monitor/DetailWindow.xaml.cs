using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Monitor
{
    /// <summary>
    /// DetailWindow.xaml 的交互逻辑
    /// </summary>
    public partial class DetailWindow : Window
    {
        public bool isClosed = false;
        public bool isMouseDown = false;
        public DetailWindow()
        {
            InitializeComponent();
            //timer = new System.Timers.Timer();
            //timer.Enabled = true;
            //timer.Interval = GetInterval();
            //timer.Elapsed += Timer_Elapsed;
            //this.listBox.ItemsSource = PList;
            this.WindowStartupLocation = WindowStartupLocation.Manual;
            this.Left = SystemParameters.WorkArea.Size.Width - this.Width;
            this.Top = SystemParameters.WorkArea.Size.Height - this.Height;
        }

        private static int GetInterval()
        {
            string[] quartzs = System.Configuration.ConfigurationManager.AppSettings["Quartz"].Split('-');
            int hours = int.Parse(quartzs[0]);
            int minute = int.Parse(quartzs[1]);
            int second = int.Parse(quartzs[2]);
            return second*1000 + minute*60*1000 + hours*60*60*1000;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //Dispatcher.Invoke(
            //    new Action(() => {
            //        Random r = new Random();
            //        PList.Clear();
            //        for (int i = 0; i < r.Next(0,50); i++)
            //        {
            //            PList.Add(new Person { IsFemale = true, Name = "预警：" + r.Next(0, 10).ToString() });
            //        }
            //    }));
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            isClosed = true;
            isMouseDown = false;
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            isMouseDown = true;
            base.OnMouseLeftButtonDown(e);
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "chrome.exe";
            p.StartInfo.Arguments = System.Configuration.ConfigurationManager.AppSettings["psewUrl"];
            p.Start();
        }

        private void image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {

        }
    }
    public class Person
    {
        public bool IsFemale { get; set; }
        public string Name { get; set; }
    }
}

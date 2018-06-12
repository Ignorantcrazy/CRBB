using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
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
    /// ListWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ListWindow : Window
    {
        public bool IsClose { get; set; }
        public List<MonitorAppDataModel> list { get; set; }
        public ListWindow()
        {
            InitializeComponent();

            this.WindowStartupLocation = WindowStartupLocation.Manual;
            this.Left = SystemParameters.WorkArea.Size.Width - this.Width;
            this.Top = SystemParameters.WorkArea.Size.Height - this.Height;
            IsClose = true;
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

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ListDetailWindow ldw = new ListDetailWindow(list);
            ldw.ShowDialog();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            IsClose = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            IsClose = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// ListDetailWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ListDetailWindow : Window
    {
        //public List<MonitorAppDataModel> list { get; set; }
        public ListDetailWindow()
        {
            InitializeComponent();

            //this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            //ObservableCollection<Event> memberData = new ObservableCollection<Event>();
            //foreach (var item in list)
            //{
            //    memberData.Add(new Event()
            //    {
            //        SiteName = item.Name,
            //        EventName = item.Content,
            //        EventType = ((int)item.Type).ToString()+"级告警",
            //        EvnetTime = item.Time.ToString()
            //    });
            //}
            //dataGrid.DataContext = memberData;
        }

        public ListDetailWindow(List<MonitorAppDataModel> list)
        {
            InitializeComponent();

            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            ObservableCollection<Event> memberData = new ObservableCollection<Event>();
            foreach (var item in list)
            {
                memberData.Add(new Event()
                {
                    SiteName = item.Name,
                    EventName = item.Content,
                    EventType = ((int)item.Type).ToString() + "级告警",
                    EvnetTime = item.Time.ToString()
                });
            }
            dataGrid.DataContext = memberData;
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }

    public class Event
    {
        public string SiteName { get; set; }
        public string EventType { get; set; }
        public string EventName { get; set; }
        public string EvnetTime { get; set; }
    }
}

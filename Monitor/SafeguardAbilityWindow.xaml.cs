using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
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
    /// SafeguardAbilityWindow.xaml 的交互逻辑
    /// </summary>
    public partial class SafeguardAbilityWindow : Window
    {
        public bool IsClose;
        public SafeguardAbilityWindow()
        {
            InitializeComponent();
            this.WebBrowser.MessageHook += WebBrowser_MessageHook;

            //string url = System.Configuration.ConfigurationManager.AppSettings["SafeguardAbility"];
            //url = url.Substring(0, url.LastIndexOf('/'));
            //string baseAddress = url.Substring(0, url.LastIndexOf('/'));
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri(baseAddress);
            bool res = true;
            try
            {
                //var response = client.GetAsync("api/CheckConnection");
                //var result = response.Result.Content.ReadAsStringAsync();
                res = bool.Parse(ApiTools<Object>.ReadAsStringAsync("api/CheckConnection"));
            }
            catch (Exception)
            {
                res = false;
            }
            if (res)
            {
                isOnlineText.Text = "正常";
            }
            else
            {
                isOnlineText.Text = "异常";
            }
        }

        private IntPtr WebBrowser_MessageHook(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            if (msg == 130)
            {
                this.Close();
            }
            return hwnd;
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            IsClose = false;
            string url = System.Configuration.ConfigurationManager.AppSettings["SafeguardAbility"];
            this.WebBrowser.Navigate(url);
        }

        private void image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void SetImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.WebBrowser.InvokeScript("OpenSetterModel");
        }

        private void MinImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {
            IsClose = true;
        }
    }
}

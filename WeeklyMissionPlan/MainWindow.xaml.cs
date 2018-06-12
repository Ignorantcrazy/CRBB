using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WeeklyMissionPlan
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private string filePath = "";
        public MainWindow()
        {
            InitializeComponent();

            this.WindowStartupLocation = WindowStartupLocation.Manual;
            this.Left = SystemParameters.WorkArea.Size.Width - this.Width;
            this.Top = SystemParameters.WorkArea.Size.Height - this.Height;
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                var result = ApiTools<ApiResultModel<string>>.ReadAsObjAsync("api/Weekly");
                if (result.Status)
                {
                    if (result.Obj != null)
                    {
                        EWarnText.Text = "机房周报";
                        ExpertAdvice.Text = "机房周报已经生成";
                        filePath = result.Obj;
                        if (string.IsNullOrEmpty(filePath))
                        {
                            this.Close();
                        }
                        return;
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    this.Close();
                }
            }
            catch
            {
                this.Close();   
            }
            
        }

        private void image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                return;
            }
            System.Diagnostics.Process.Start("explorer.exe ", filePath);
        }
    }
}

using System;
using System.Collections.Generic;
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
using System.Threading;

namespace Monitor
{
    /// <summary>
    /// PopBoxs.xaml 的交互逻辑
    /// </summary>
    public partial class PopBoxs : Window
    {
        //public string m_EWarnText { get; set; }
        //public string m_ExpertAdvice { get; set; }
        public bool IsClose { get; set; }
        System.Timers.Timer timer;
        private string speech;
        public PopBoxs()
        {
            InitializeComponent();

            this.WindowStartupLocation = WindowStartupLocation.Manual;
            this.Left = SystemParameters.WorkArea.Size.Width - this.Width;
            this.Top = SystemParameters.WorkArea.Size.Height - this.Height;
        }
        private void TimerUp(object sender, System.Timers.ElapsedEventArgs e)
        {
            SpeechSpeak();
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

        private void Window_Closed(object sender, EventArgs e)
        {
            IsClose = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            IsClose = false;

            var warnFaultModel = ApiTools<ApiResultModel<ViewModels.WarnFaultPopViewModel>>.ReadAsObjAsync("api/Warninng");
            if (warnFaultModel.Status)
            {
                if (warnFaultModel.Obj != null)
                {
                    EWarnText.Text = warnFaultModel.Obj.EventName;
                    ExpertAdvice.Text = warnFaultModel.Obj.ExpertAdvice;
                    if (warnFaultModel.Obj.IsVoice)
                    {
                        speech = this.EWarnText.Text + ":" + this.ExpertAdvice.Text;
                        InitTimer();
                    }
                    var result = ApiTools<ApiResultModel<bool>>.PostAsync("api/Warninng", warnFaultModel.Obj.ID);
                    if (result.Status == false)
                    {
                        MessageBox.Show(result.Message);
                    }
                    return;
                }
            }
            var earlyWarningModel = ApiTools<ApiResultModel<ViewModels.EarlyWarningPopViewModel>>.ReadAsObjAsync("api/EarlyWarning");
            if (earlyWarningModel.Status)
            {
                if (earlyWarningModel.Obj != null)
                {
                    EWarnText.Text = earlyWarningModel.Obj.EWarnText;
                    ExpertAdvice.Text = earlyWarningModel.Obj.ExpertAdvice;
                    if (earlyWarningModel.Obj.IsVoice)
                    {
                        speech = this.EWarnText.Text + ":" + this.ExpertAdvice.Text;
                        InitTimer();
                    }

                    var result = ApiTools<ApiResultModel<bool>>.PostAsync("api/EarlyWarning", earlyWarningModel.Obj.ID);
                    if (result.Status == false)
                    {
                        MessageBox.Show(result.Message);
                    }
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

        private void InitTimer()
        {
            int interval = 1000;
            timer = new System.Timers.Timer(interval);
            timer.AutoReset = false;
            timer.Enabled = true;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(TimerUp);
        }

        private void SpeechSpeak()
        {
            System.Diagnostics.Process.Start(System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "SpeechSynthesizerTool.exe"), speech).WaitForExit(10000);
            //System.Speech.Synthesis.SpeechSynthesizer synth = new System.Speech.Synthesis.SpeechSynthesizer();
            //synth.SetOutputToDefaultAudioDevice();
            //synth.Speak(speech);
            //synth.Dispose();
        }
    }
}

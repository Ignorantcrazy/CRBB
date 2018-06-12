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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Monitor
{
    /// <summary>
    /// CustomButton.xaml 的交互逻辑
    /// </summary>
    public partial class CustomButton : UserControl
    {
        public CustomButton()
        {
            InitializeComponent();
        }

        //按钮是否可用
        private bool isEnable = true;
        //按钮文本
        private string text = "";
        //按钮文本字体
        private FontFamily textFamily = new FontFamily("宋体");
        //按钮文本字体大小
        private double textSize = 10;
        //按钮文本字体颜色
        private Brush textColor = Brushes.Black;
        //正在被按下状态
        private bool isClicking = false;
        //背景图片
        private BitmapSource backImage;
        //正常背景资源
        private ImageSource EnablebackImage;
        //不可用背景资源
        private ImageSource unEnablebackImage;
        //按下事件
        public event EventHandler click;
        /// <summary>
        /// 设置或获取控件可用状态
        /// </summary>
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Appearance"), System.ComponentModel.Description("设置或获取控件可用状态")]
        public bool IsEnable
        {
            get
            {
                return isEnable;
            }
            set
            {
                this.btnText.IsEnabled = value;
                this.btnImage.IsEnabled = value;
                isEnable = value;
                if (isEnable)
                {
                    btnImage.Source = EnablebackImage;
                }
                else
                {
                    btnImage.Source = unEnablebackImage;
                }
            }
        }
        /// <summary>
        /// 设置或获取控件文本
        /// </summary>
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Appearance"), System.ComponentModel.Description("设置或获取控件文本")]
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                this.btnText.Text = value;
                text = value;
            }
        }
        /// <summary>
        /// 设置或获取控件文本字体
        /// </summary>
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Appearance"), System.ComponentModel.Description("设置或获取控件文本字体")]
        public FontFamily TextFamily
        {
            get
            {
                return textFamily;
            }
            set
            {
                this.btnText.FontFamily = value;
                textFamily = value;
            }
        }
        /// <summary>
        /// 设置或获取控件文本字体大小
        /// </summary>
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Appearance"), System.ComponentModel.Description("设置或获取控件文本字体大小")]
        public double TextSize
        {
            get
            {
                return textSize;
            }
            set
            {
                this.btnText.FontSize = value;
                textSize = value;
            }
        }
        /// <summary>
        /// 设置或获取控件文本字体颜色
        /// </summary>
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Appearance"), System.ComponentModel.Description("设置或获取控件文本字体颜色")]
        public Brush TextColor
        {
            get
            {
                return textColor;
            }
            set
            {
                this.btnText.Foreground = value;
                textColor = value;
            }
        }
        /// <summary>
        /// 设置或获取控件背景图片
        /// </summary>
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Appearance"), System.ComponentModel.Description("设置或获取控件背景图片")]
        public BitmapSource BackImage
        {
            get
            {
                return backImage;
            }
            set
            {
                backImage = value;
                getBackImageSource(value);
                if (isEnable)
                {
                    btnImage.Source = EnablebackImage;
                }
                else
                {
                    btnImage.Source = unEnablebackImage;
                }
            }
        }

        private void UserControl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEnable)
            {
                           isClicking = true;
                           btnImage.Margin = new Thickness(13, 6, 13, 28);
                       }
        }

        private void UserControl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (isEnable)
            {
                if (isClicking)
                {
                    isClicking = false;
                    if (click != null)
                    {
                        click(this, null);
                    }
                    btnImage.Margin = new Thickness(9, 2, 9, 24);
                }
            }
        }

        private void UserControl_MouseEnter(object sender, MouseEventArgs e)
        {
            if (isEnable)
            {
                btnImage.Margin = new Thickness(9, 2, 9, 24);
            }
            MainBorder.Visibility = System.Windows.Visibility.Visible;
        }

        private void UserControl_MouseLeave(object sender, MouseEventArgs e)
        {
            if (isEnable)
            {
                if (isClicking)
                {
                    isClicking = false;
                }
                btnImage.Margin = new Thickness(9, 2, 9, 24);
            }
            MainBorder.Visibility = System.Windows.Visibility.Hidden;
        }

        private void getBackImageSource(BitmapSource i)
        {
            if (i == null)
            {
                EnablebackImage = null;
                unEnablebackImage = null;
                return;
            }
            FormatConvertedBitmap b = new FormatConvertedBitmap();
            b.BeginInit();
            b.Source = i;
            b.DestinationFormat = PixelFormats.Gray8;
            b.EndInit();
            FormatConvertedBitmap b1 = new FormatConvertedBitmap();
            b1.BeginInit();
            b1.Source = i;
            b1.EndInit();
            EnablebackImage = b1;
            unEnablebackImage = b;
        }
    }
}

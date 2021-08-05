using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AcrylicClock
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        DispatcherTimer _Timer = new DispatcherTimer();
        private readonly string DateTimeLong = DateTime.Now.ToLongTimeString();

        public MainPage()
        {
            this.InitializeComponent();

            _Timer.Interval = TimeSpan.FromSeconds(1);
            _Timer.Tick += (sender, e) => { Update_Time(sender, e); };
            _Timer.Start();
        }

        private void Update_Time(object sender, object e)
        {
            //throw new NotImplementedException();
            this.MiddleNum.Text = $"{DateTime.Now.Hour.ToString("00")} : {DateTime.Now.Minute.ToString("00")} : {DateTime.Now.Second.ToString("00")}";
        }

        private void AppExit(Object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void ButtomSliderValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            string msg = String.Format("{0}", e.NewValue);
            //string msg = String.Format("{0}", DateTimeLong);
            //this.MiddleNum.Text = msg;
            //this.MiddleNum.FontSize = double.Parse(msg);
            //this.MiddleNum.FontSize = 60.0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Windows.Threading;

namespace Smart_Challenge
{
    public partial class s9lvl4 : PhoneApplicationPage
    {
        DispatcherTimer tmr = new DispatcherTimer();
        int c;
        public s9lvl4()
        {
            InitializeComponent();
            c = 0;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Veloce! Rompi più di tre uova";

            }
            else
            {
                Instr.Text = "Fast! Break more than three eggs";
            }
            tmr.Interval = TimeSpan.FromSeconds(4);
            tmr.Tick += new EventHandler(OnTimerTick);
            tmr.Start();
        }

        void OnTimerTick(object sender, EventArgs e)
        {
            tmr.Stop();
            NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }


        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult m = MessageBox.Show(VarGlobal.text2, VarGlobal.text1, MessageBoxButton.OKCancel);
            if (m == MessageBoxResult.Cancel)
            {
                //SE L'UTENTE ANNULLA ALLORA BLOCCO LA FUNZIONE DEL TASTO INDIETRO
                e.Cancel = true;
            }
            else
            {
                tmr.Stop();
                while (NavigationService.CanGoBack)
                {
                    NavigationService.RemoveBackEntry();
                }

                NavigationService.Navigate(new Uri("/UltimolvlMenu.xaml", UriKind.Relative));
            }
        }

        private void u2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            c++;
            u2.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl9/uovocotto.png") as ImageSource;
            if (c > 3)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet9/s9lvl5.xaml", UriKind.Relative));
            }
        }

        private void u3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            c++;
            u3.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl9/uovocotto.png") as ImageSource;
            if (c > 3)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet9/s9lvl5.xaml", UriKind.Relative));
            }
        }

        private void u1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            c++;
            u1.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl9/uovocotto.png") as ImageSource;
            if (c > 3)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet9/s9lvl5.xaml", UriKind.Relative));
            }
        }

        private void u5_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            c++;
            u5.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl9/uovocotto.png") as ImageSource;
            if (c > 3)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet9/s9lvl5.xaml", UriKind.Relative));
            }
        }

        private void u4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            c++;
            u4.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl9/uovocotto.png") as ImageSource;
            if (c > 3)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet9/s9lvl5.xaml", UriKind.Relative));
            }
        }
      
    }
}
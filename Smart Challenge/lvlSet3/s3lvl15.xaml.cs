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
    public partial class s3lvl15 : PhoneApplicationPage
    {

        DispatcherTimer timer = new DispatcherTimer();
        public s3lvl15()
        {
            InitializeComponent();
            VarGlobal.flag1 = false;
            VarGlobal.flag2 = false;
            VarGlobal.flag3 = false;
            VarGlobal.flag4 = false;
            VarGlobal.flag5 = false;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            
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
                timer.Stop();
                while (NavigationService.CanGoBack)
                {
                    NavigationService.RemoveBackEntry();
                }

                NavigationService.Navigate(new Uri("/lvlMenu.xaml", UriKind.Relative));
            }
        } 

            private void grid1_Loaded(object sender, RoutedEventArgs e)
            {
                string checkLang = (string)VarGlobal.settings["lingua"];
                if (checkLang == "Italia")
                {
                    Instr.Text = "Spegni il fuoco da destra verso sinistra!";

                }
                else
                {
                    Instr.Text = "Put out the fire from right to left!";
                }
            }

            private void f1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                VarGlobal.flag1 = true;
                f1.Visibility = Visibility.Collapsed;
            }

            private void f2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                if (VarGlobal.flag1 == true)
                {
                    VarGlobal.flag2 = true;
                    f2.Visibility = Visibility.Collapsed;
                }
                else
                {
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
                }
            }

            private void f3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                if (VarGlobal.flag2 == true)
                {
                    VarGlobal.flag3 = true;
                    f3.Visibility = Visibility.Collapsed;
                }
                else
                {
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
                }
            }

            private void f4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                if (VarGlobal.flag3 == true)
                {
                    VarGlobal.flag4 = true;
                    f4.Visibility = Visibility.Collapsed;
                }
                else
                {
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
                }
                timer.Interval = TimeSpan.FromSeconds(1);
                timer.Tick += new EventHandler(OnTimerTick2);
                timer.Start();

            }

            private void f5_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                if (VarGlobal.flag4 == true)
                {
                    timer.Stop();
                    NavigationService.Navigate(new Uri("/lvlSet3/s3lvl16.xaml", UriKind.Relative));
                }

                else
                {
                    timer.Stop();
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
                }
            }

            private void stella_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                VarGlobal.star = true;
                stella.Visibility = Visibility.Collapsed;
            }
            void OnTimerTick2(object sender, EventArgs e)
            {
                timer.Stop();
                stella.Visibility = Visibility.Collapsed;
            }
            

           
    }
}
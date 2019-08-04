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
    public partial class s9lvl16 : PhoneApplicationPage
    {
        DispatcherTimer tmr = new DispatcherTimer();
        int c;
        public s9lvl16()
        {
            InitializeComponent();
            c = 0;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "DIFENDI LA TERRA: Capitolo Due";

            }
            else
            {
                Instr.Text = "DEFEND THE EARTH: Chapter Two";
            }
            tmr.Interval = TimeSpan.FromSeconds(2);
            tmr.Tick += new EventHandler(vai1);
            tmr.Start();
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
                go1.Stop();
                go2.Stop();
                go3.Stop();
                while (NavigationService.CanGoBack)
                {
                    NavigationService.RemoveBackEntry();
                }

                NavigationService.Navigate(new Uri("/UltimolvlMenu.xaml", UriKind.Relative));
            }
        }

        void vai1(object sender, EventArgs e)
        {
            tmr.Stop();
            go1.Begin();
            go2.Begin();
            go3.Begin();
            go1.Completed += go_Completed;
            go2.Completed += go_Completed;
            go3.Completed += go_Completed;

        }


        void go_Completed(object sender, EventArgs e)
        {
            tmr.Stop();
            go1.Stop();
            go2.Stop();
            go3.Stop();
            NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

        private void u1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            c++;
            go1.Stop();
            u1.Visibility = Visibility.Collapsed;
            if (c == 3)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet9/s9lvl17.xaml", UriKind.Relative));
            }
        }

        private void u2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            c++;
            go2.Stop();
            u2.Visibility = Visibility.Collapsed;
            if (c == 3)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet9/s9lvl17.xaml", UriKind.Relative));
            }
        }

        private void u3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            c++;
            go3.Stop();
            u3.Visibility = Visibility.Collapsed;
            if (c == 3)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet9/s9lvl17.xaml", UriKind.Relative));
            }
        }

    }
}
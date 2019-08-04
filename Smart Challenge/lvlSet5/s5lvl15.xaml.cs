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
    public partial class s5lvl15 : PhoneApplicationPage
    {
        int count = 0;
        DispatcherTimer tmr = new DispatcherTimer();
        public s5lvl15()
        {
            InitializeComponent();
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Vorrei un sole grande! Ma non esagerare ...";

            }
            else
            {
                Instr.Text = "I would like a large sun! But do not exaggerate ...";
            }
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

                NavigationService.Navigate(new Uri("/NewlvlMenu.xaml", UriKind.Relative));
            }
        }

        private void s1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;

            if (count == 2)
            {
                s2.Visibility = Visibility.Visible;
                s1.Visibility = Visibility.Collapsed;
            }
        }

        private void s2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;

            if (count == 5)
            {
                s3.Visibility = Visibility.Visible;
                s2.Visibility = Visibility.Collapsed;
            }
        }

        private void s3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;

            if (count == 7)
            {
                s4.Visibility = Visibility.Visible;
                s3.Visibility = Visibility.Collapsed;

                tmr.Interval = TimeSpan.FromSeconds(3);
                tmr.Tick += new EventHandler(OnTimerTick);
                tmr.Start();
            }
        }

        private void s4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tmr.Stop();
            NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

        void OnTimerTick(object sender, EventArgs e)
        {
            tmr.Stop();
            NavigationService.Navigate(new Uri("/lvlSet5/s5lvl16.xaml", UriKind.Relative));
        }

           
    }
}
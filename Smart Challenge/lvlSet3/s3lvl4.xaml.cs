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
    public partial class s3lvl4 : PhoneApplicationPage
    {

        DispatcherTimer tmr = new DispatcherTimer();
        public s3lvl4()
        {
            InitializeComponent();
            VarGlobal.count = 0;

           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Veloce! Premi il bottone più piccolo. ";

            }
            else
            {
                Instr.Text = "Quick! Press the smallest button. ";
            }

            tmr.Interval = TimeSpan.FromSeconds(1);
            tmr.Tick += new EventHandler(OnTimerTick);
            tmr.Start();
        }





        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            
            MessageBoxResult m = MessageBox.Show("Vuoi davvero fermare la partita?", "Attenzione!", MessageBoxButton.OKCancel);
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

                NavigationService.Navigate(new Uri("/lvlMenu.xaml", UriKind.Relative));
            }
        } 

            void OnTimerTick(object sender, EventArgs e)
            {
                tmr.Stop();
                if (VarGlobal.count >= 1)
                {
                    NavigationService.Navigate(new Uri("/lvlSet3/s3lvl5.xaml", UriKind.Relative));
                }
                else
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }

            private void bot_Copy1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                VarGlobal.count ++;
            }

            private void bot_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }


           
    }
}
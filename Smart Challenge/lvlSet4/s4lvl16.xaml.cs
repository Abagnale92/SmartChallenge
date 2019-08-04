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
    public partial class s4lvl16 : PhoneApplicationPage
    {
        DispatcherTimer tmr = new DispatcherTimer();
        int i = 0;
        public s4lvl16()
        {
            InitializeComponent();

        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Premi sul tasto rosso per gonfiare il palloncino!";

            }
            else
            {
                Instr.Text = "Press the red button to inflate the balloon!";
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

        private void b1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            i++;
            if (i == 3)
            {
                p1.Source = null;
                p2.Source = null;
                p3.Source = null;
                p4.Source = null;
                b1.Source = null;
                b2.Source = null;
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet4/s4lvl17.xaml", UriKind.Relative));
            }
            else
            {
                switch (i)
                {
                    case 1:
                        {
                            p2.Visibility = Visibility.Visible;
                            b2.Visibility = Visibility.Visible;
                            b1.Visibility = Visibility.Collapsed;

                            tmr.Interval = TimeSpan.FromSeconds(3);
                            tmr.Tick += new EventHandler(OnTimerTick);
                            tmr.Start();
                            break;
                        }
                    case 2:
                        {
                            p3.Visibility = Visibility.Visible;
                            break;
                        } 
                }
            }
        }

             void OnTimerTick(object sender, EventArgs e)
        {
            tmr.Stop();
            b1.Visibility = Visibility.Visible;
            b2.Visibility = Visibility.Collapsed;
        }

        private void b2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tmr.Stop();
            NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }


        
    }
}
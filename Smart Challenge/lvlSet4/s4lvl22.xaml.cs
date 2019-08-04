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
    public partial class s4lvl22 : PhoneApplicationPage
    {
        DispatcherTimer tmr = new DispatcherTimer();
        int count = 0;
        public s4lvl22()
        {
            InitializeComponent();
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Vediamo se sei fortunato: scegli un pinguino";

            }
            else
            {
                Instr.Text = "Let's see if you get lucky: choose a penguin";
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

        private void a_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Sei fortunato! Premi sui pinguini per andare avanti";

            }
            else
            {
                Instr.Text = "You're in luck! Tap on the penguins to move forward";
            }

            a.Visibility = Visibility.Collapsed;
            b.Visibility = Visibility.Collapsed;

            p1.Visibility = Visibility.Visible;
            p2.Visibility = Visibility.Visible;
            p3.Visibility = Visibility.Visible;
            p4.Visibility = Visibility.Visible;
            p5.Visibility = Visibility.Visible;
            p6.Visibility = Visibility.Visible;
            p7.Visibility = Visibility.Visible;
            p8.Visibility = Visibility.Visible;
            p9.Visibility = Visibility.Visible;
        }

        private void b_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Mi dispiace... Veloce! Premi sui pinguini per andare avanti";

            }
            else
            {
                Instr.Text = "Sorry about that... Fast! Tap on the penguins to move forward";
            }

            tmr.Interval = TimeSpan.FromSeconds(5);
            tmr.Tick += new EventHandler(OnTimerTick);
            tmr.Start();

            a.Visibility = Visibility.Collapsed;
            b.Visibility = Visibility.Collapsed;

            p1.Visibility = Visibility.Visible;
            p2.Visibility = Visibility.Visible;
            p3.Visibility = Visibility.Visible;
            p4.Visibility = Visibility.Visible;
            p5.Visibility = Visibility.Visible;
            p6.Visibility = Visibility.Visible;
            p7.Visibility = Visibility.Visible;
            p8.Visibility = Visibility.Visible;
            p9.Visibility = Visibility.Visible;
        }

        void OnTimerTick(object sender, EventArgs e)
        {
            tmr.Stop();
            NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

        private void p1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            p1.Visibility = Visibility.Collapsed;

            if (count == 9)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet4/s4lvl23.xaml", UriKind.Relative));
            }
        }

        private void p2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            p2.Visibility = Visibility.Collapsed;

            if (count == 9)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet4/s4lvl23.xaml", UriKind.Relative));
            }
        }

        private void p3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            p3.Visibility = Visibility.Collapsed;

            if (count == 9)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet4/s4lvl23.xaml", UriKind.Relative));
            }
        }

        private void p8_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            p8.Visibility = Visibility.Collapsed;
            if (count == 9)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet4/s4lvl23.xaml", UriKind.Relative));
            }
        }

        private void p5_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            p5.Visibility = Visibility.Collapsed;
            if (count == 9)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet4/s4lvl23.xaml", UriKind.Relative));
            }
        }

        private void p4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            p4.Visibility = Visibility.Collapsed;
            if (count == 9)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet4/s4lvl23.xaml", UriKind.Relative));
            }
        }

        private void p7_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            p7.Visibility = Visibility.Collapsed;
            if (count == 9)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet4/s4lvl23.xaml", UriKind.Relative));
            }
        }

        private void p9_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            p9.Visibility = Visibility.Collapsed;
            if (count == 9)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet4/s4lvl23.xaml", UriKind.Relative));
            }
        }

        private void p6_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            p6.Visibility = Visibility.Collapsed;
            if (count == 9)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet4/s4lvl23.xaml", UriKind.Relative));
            }
        }

           
    }
}
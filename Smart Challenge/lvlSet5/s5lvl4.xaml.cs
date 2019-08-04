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
    public partial class s5lvl4 : PhoneApplicationPage
    {
        int count = 0;
        DispatcherTimer tmr = new DispatcherTimer();
        public s5lvl4()
        {
            InitializeComponent();
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Veloce   Tappa i punti esclamativi";

            }
            else
            {
                Instr.Text = "Fast   Tap exclamation points";
            }
            tmr.Interval = TimeSpan.FromSeconds(5);
            tmr.Tick += new EventHandler(OnTimerTick);
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
                while (NavigationService.CanGoBack)
                {
                    NavigationService.RemoveBackEntry();
                }

                NavigationService.Navigate(new Uri("/NewlvlMenu.xaml", UriKind.Relative));
            }
        }

        private void i_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            i.Visibility = Visibility.Collapsed;
            if (count == 6)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet5/s5lvl5.xaml", UriKind.Relative));
            }
        }

        private void i1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            i1.Visibility = Visibility.Collapsed;
            if (count == 6)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet5/s5lvl5.xaml", UriKind.Relative));
            }
        }

        private void i2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            i2.Visibility = Visibility.Collapsed;
            if (count == 6)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet5/s5lvl5.xaml", UriKind.Relative));
            }
        }

        private void i3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            i3.Visibility = Visibility.Collapsed;
            if (count == 6)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet5/s5lvl5.xaml", UriKind.Relative));
            }
        }

        private void i4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            i4.Visibility = Visibility.Collapsed;
            if (count == 6)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet5/s5lvl5.xaml", UriKind.Relative));
            }
        }

        private void i5_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            i5.Visibility = Visibility.Collapsed;
            if (count == 6)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet5/s5lvl5.xaml", UriKind.Relative));
            }
        }


        void OnTimerTick(object sender, EventArgs e)
        {
            tmr.Stop();
            NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }
            

           
    }
}
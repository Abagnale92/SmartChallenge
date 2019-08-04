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
    public partial class s4lvl17 : PhoneApplicationPage
    {
        DispatcherTimer tmr = new DispatcherTimer();
        public s4lvl17()
        {
            InitializeComponent();
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Osserva!";

            }
            else
            {
                Instr.Text = "Observe!";
            }
            tmr.Interval = TimeSpan.FromSeconds(3);
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

        void OnTimerTick(object sender, EventArgs e)
        {
            tmr.Stop();
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Quanti erano i pianeti?";

            }
            else
            {
                Instr.Text = "How were the planets?";
            }

            p1.Visibility = Visibility.Collapsed;
            p2.Visibility = Visibility.Collapsed;
            p3.Visibility = Visibility.Collapsed;
            p4.Visibility = Visibility.Collapsed;
            p5.Visibility = Visibility.Collapsed;
            p6.Visibility = Visibility.Collapsed;
            p7.Visibility = Visibility.Collapsed;
            p8.Visibility = Visibility.Collapsed;
            b1.Visibility = Visibility.Visible;
            b2.Visibility = Visibility.Visible;
            b3.Visibility = Visibility.Visible;
            b4.Visibility = Visibility.Visible;
          
        }

        private void btn_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Button rispScelta = (Button)sender;
            string asd = rispScelta.Name;
            string asd2 = asd.Substring(1);
            if (asd2 == "1")
            {
                NavigationService.Navigate(new Uri("/lvlSet4/s4lvl18.xaml", UriKind.Relative));
                p1.Source = null;
                p2.Source = null;
                p3.Source = null;
                p4.Source = null;
                p5.Source = null;
                p6.Source = null;
                p7.Source = null;
                p8.Source = null;
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }
           
    }
}
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
    public partial class s4lvl14 : PhoneApplicationPage
    {
        DispatcherTimer tmr = new DispatcherTimer();
        
        public s4lvl14()
        {
            InitializeComponent();

        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Veloce! Premi sui più numerosi!";

            }
            else
            {
                Instr.Text = "Fast! Tap on many more!";
            }
            tmr.Interval = TimeSpan.FromSeconds(6);
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

                NavigationService.Navigate(new Uri("/NewlvlMenu.xaml", UriKind.Relative));
            }
        }

        private void a_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tmr.Stop();
            NavigationService.Navigate(new Uri("/lvlSet4/s4lvl15.xaml", UriKind.Relative));
            a1.Source = null;
            a2.Source = null;
            a3.Source = null;
            a4.Source = null;
            b1.Source = null;
            b2.Source = null;
            b3.Source = null;
            b4.Source = null;
            b5.Source = null;

        }

        private void b_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tmr.Stop();
            NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }



    }
}
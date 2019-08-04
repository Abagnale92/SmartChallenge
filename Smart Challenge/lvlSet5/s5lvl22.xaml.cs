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
    public partial class s5lvl22 : PhoneApplicationPage
    {
        DispatcherTimer tmr = new DispatcherTimer();
        int count = 0;
        public s5lvl22()
        {
            InitializeComponent();
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Non premere!";

            }
            else
            {
                Instr.Text = "No tap!";
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
            if (count > 0)
            {
                NavigationService.Navigate(new Uri("/lvlSet5/s5lvl23.xaml", UriKind.Relative));
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

        private void b_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
        }
           
    }
}
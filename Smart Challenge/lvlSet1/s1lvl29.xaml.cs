using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Threading;


namespace Smart_Challenge.lvlSet1
{
    public partial class s1lvl29 : PhoneApplicationPage
    {

        DispatcherTimer tmr = new DispatcherTimer();
        public s1lvl29()
        {
            InitializeComponent();

        }

        private void grid1_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = " Il pinguino viene chiuso nella scatola. ";

            }
            else
            {
                Instr.Text = " The penguin gets closed in the box. ";
            }

            tmr.Interval = TimeSpan.FromSeconds(2);
            tmr.Tick += new EventHandler(OnTimerTick); // Richiama la funzione : cosa succede appena finisce il tempo?
            tmr.Start();
        }

        void OnTimerTick(object sender, EventArgs e)
        {
            tmr.Stop();

            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = " Il pinguino è vivo o morto? ";
                Risp1.Content = " Vivo ";
                Risp2.Content = " Morto ";

            }
            else
            {
                Instr.Text = " The penguin is alive or dead? ";
                Risp1.Content = " Alive ";
                Risp2.Content = " Dead ";
            }

            Gatto.Visibility = Visibility.Collapsed;
            ScatolaAperta.Visibility = Visibility.Collapsed;
            ScatolaChiusa.Visibility = Visibility.Visible;
            Risp1.Visibility = Visibility.Visible;
            Risp2.Visibility = Visibility.Visible;
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

                NavigationService.Navigate(new Uri("/lvlMenu.xaml", UriKind.Relative));
            }
        } 

        private void Risp1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.scelta == false)
            {
                tmr.Stop();
                ScatolaAperta.Source = null;
                ScatolaChiusa.Source = null;
                NavigationService.Navigate(new Uri("/lvlSet1/s1lvl30.xaml", UriKind.Relative));
            }
            else
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

        private void Risp2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.scelta == true)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet1/s1lvl30.xaml", UriKind.Relative));
            }
            else
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

    }
}
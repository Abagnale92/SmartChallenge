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
    public partial class s1lvl28 : PhoneApplicationPage
    {

        DispatcherTimer tmr = new DispatcherTimer();
        public s1lvl28()
        {
            InitializeComponent();
        }

        private void grid1_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = " Osserva l'orologio. ";

            }
            else
            {
                Instr.Text = " Watch the clock. ";
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
                Instr.Text = " Somma i minuti con le ore e premi sul risultato esatto! ";

            }
            else
            {
                Instr.Text = " Add up the hours and minutes with the press on the exact result! ";
                
            }

            Clock.Visibility = Visibility.Collapsed;
            arr1.Visibility = Visibility.Collapsed;
            arr1_Copy.Visibility = Visibility.Collapsed;
            btn1.Visibility = Visibility.Visible;
            btn2.Visibility = Visibility.Visible;
            btn3.Visibility = Visibility.Visible;
            btn4.Visibility = Visibility.Visible;

        }

        private void btn_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Button rispScelta = (Button)sender;
            string c = rispScelta.Content.ToString();
            if (c == "31")
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet1/s1lvl29.xaml", UriKind.Relative));
            }
            else
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
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

                NavigationService.Navigate(new Uri("/lvlMenu.xaml", UriKind.Relative));
            }
        } 
    }
}
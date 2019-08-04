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
    public partial class s1lvl14 : PhoneApplicationPage
    {

        DispatcherTimer tmr = new DispatcherTimer();
        public s1lvl14()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Osserva l'immagine";

            }
            else
            {
                Instr.Text = "Look at the image";
            }

            tmr.Interval = TimeSpan.FromSeconds(1);
            tmr.Tick += new EventHandler(OnTimerTick);
            tmr.Start();
        }

        void OnTimerTick(object sender, EventArgs e)
        {
            tmr.Stop();
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Quale pezzo manca?";

            }
            else
            {
                Instr.Text = "Which is the missing piece?";
            }
            picture.Visibility = Visibility.Collapsed;
            puzzle.Visibility = Visibility;
            ok1.Visibility = Visibility;
            no1.Visibility = Visibility;
            no2.Visibility = Visibility;
            no3.Visibility = Visibility;
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

            private void no1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {

                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }

            private void no2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }

            private void no3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }

            private void ok1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                ok1.Margin = new Thickness(172, 284, 0, 0);
                ok1.Height = 172;
                ok1.Width = 205;
                DispatcherTimer tmr = new DispatcherTimer();
                tmr.Interval = TimeSpan.FromSeconds(1);
                tmr.Tick += new EventHandler(ClickOK);
                tmr.Start();
            }

            void ClickOK(object sender, EventArgs e)
            {
                ((DispatcherTimer)sender).Stop();
                picture.Source = null;
                puzzle.Source = null;
                no1.Source = null;
                no2.Source = null;
                no3.Source = null;
                ok1.Source = null;
             
                NavigationService.Navigate(new Uri("/lvlSet1/s1lvl15.xaml", UriKind.Relative));
            }

            

           
    }
}
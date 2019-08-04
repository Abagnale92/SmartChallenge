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
    public partial class s1lvl15 : PhoneApplicationPage
    {

        DispatcherTimer tmr = new DispatcherTimer();
        public s1lvl15()
        {
            InitializeComponent();
            VarGlobal.count = 0;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Premi fino a che l'uovo non si apre";

            }
            else
            {
                Instr.Text = "Press until the egg breaks";
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

            private void chick_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }

            private void egg_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                if (VarGlobal.count < 6)
                    VarGlobal.count = VarGlobal.count + 1;

                if (VarGlobal.count == 6)
                {
                    egg.Visibility = Visibility.Collapsed;
                    eggUp.Visibility = Visibility;
                    eggDown.Visibility = Visibility;
                }

            }

            private void eggUp_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                tmr.Interval = TimeSpan.FromSeconds(1);
                tmr.Tick += new EventHandler(OnTimerTick);
                tmr.Start();
                eggUp.Margin = new Thickness(30, 239, 0, 0);
                Instr.Foreground = new SolidColorBrush(Colors.Red);
                string checkLang = (string)VarGlobal.settings["lingua"];
                if (checkLang == "Italia")
                {
                    Instr.Text = "Tocca il pinguino!";

                }
                else
                {
                    Instr.Text = "Touch the penguin!";
                }
            }

            void OnTimerTick(object sender, EventArgs e)
            {
                tmr.Stop();
                chick.Source = null;
                egg.Source = null;
                eggUp.Source = null;
                eggDown.Source = null;
                NavigationService.Navigate(new Uri("/lvlSet1/s1lvl16.xaml", UriKind.Relative));
            }
    }
}
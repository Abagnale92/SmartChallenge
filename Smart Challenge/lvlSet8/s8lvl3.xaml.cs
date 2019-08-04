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

namespace Smart_Challenge
{
    public partial class s8lvl3 : PhoneApplicationPage
    {
        public s8lvl3()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Tap sui bottoni dall'alto verso il basso";

            }
            else
            {
                Instr.Text = "Tap the button from the high to bottom";
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
                while (NavigationService.CanGoBack)
                {
                    NavigationService.RemoveBackEntry();
                }

                NavigationService.Navigate(new Uri("/UltimolvlMenu.xaml", UriKind.Relative));
            }
        }

        private void b13_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            b13.Visibility = Visibility.Collapsed;
        }

        private void b12_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (b13.Visibility == Visibility.Collapsed)
                b12.Visibility = Visibility.Collapsed;
            else
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

        private void b11_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (b12.Visibility == Visibility.Collapsed)
                b11.Visibility = Visibility.Collapsed;
            else
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

        private void b10_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (b11.Visibility == Visibility.Collapsed)
                b10.Visibility = Visibility.Collapsed;
            else
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

        private void b9_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (b10.Visibility == Visibility.Collapsed)
                b9.Visibility = Visibility.Collapsed;
            else
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

        private void b8_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (b9.Visibility == Visibility.Collapsed)
                b8.Visibility = Visibility.Collapsed;
            else
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

        private void b7_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (b8.Visibility == Visibility.Collapsed)
                b7.Visibility = Visibility.Collapsed;
            else
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

        private void b6_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (b7.Visibility == Visibility.Collapsed)
                b6.Visibility = Visibility.Collapsed;
            else
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

        private void b5_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (b6.Visibility == Visibility.Collapsed)
                b5.Visibility = Visibility.Collapsed;
            else
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

        private void b4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (b5.Visibility == Visibility.Collapsed)
                b4.Visibility = Visibility.Collapsed;
            else
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

        private void b3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (b4.Visibility == Visibility.Collapsed)
                b3.Visibility = Visibility.Collapsed;
            else
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

        private void b2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (b3.Visibility == Visibility.Collapsed)
                b2.Visibility = Visibility.Collapsed;
            else
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

        private void b1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (b2.Visibility == Visibility.Collapsed)
            {
                b1.Visibility = Visibility.Collapsed;
                NavigationService.Navigate(new Uri("/lvlSet8/s8lvl4.xaml", UriKind.Relative));
            }
            else
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }
      
    }
}
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
    public partial class s8lvl11 : PhoneApplicationPage
    {
        public s8lvl11()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Ordina in modo crescente lettere e numeri!";

            }
            else
            {
                Instr.Text = "Sort in increasing order letters and numbers!";
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

        private void g_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            g.Visibility = Visibility.Collapsed;
        }

        private void _17_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (g.Visibility == Visibility.Collapsed)
                _17.Visibility = Visibility.Collapsed;
            else
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

        private void r_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (_17.Visibility == Visibility.Collapsed)
               r.Visibility = Visibility.Collapsed;
            else
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

        private void _21_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (r.Visibility == Visibility.Collapsed)
            {
                _21.Visibility = Visibility.Collapsed;
                NavigationService.Navigate(new Uri("/lvlSet8/s8lvl12.xaml", UriKind.Relative));
            }
            else
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }
      
    }
}
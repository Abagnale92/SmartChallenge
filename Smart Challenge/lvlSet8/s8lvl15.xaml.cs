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
    public partial class s8lvl15 : PhoneApplicationPage
    {
        public s8lvl15()
        {
            InitializeComponent();
            VarGlobal.check = 10;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Tocca le immagini per ordine cronologico!";

            }
            else
            {
                Instr.Text = "Touch the images for chronologic's order!";
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

        private void lupin_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            lupin.Visibility = Visibility.Collapsed;
        }

        private void lamu_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if(  lupin.Visibility == Visibility.Collapsed)
            lamu.Visibility = Visibility.Collapsed;
            else
            NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

        private void pollon_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (lamu.Visibility == Visibility.Collapsed)
                pollon.Visibility = Visibility.Collapsed;
            else
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

        private void ranma_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (pollon.Visibility == Visibility.Collapsed)
                ranma.Visibility = Visibility.Collapsed;
            else
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

        private void goku_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (ranma.Visibility == Visibility.Collapsed)
                goku.Visibility = Visibility.Collapsed;
            else
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

        private void hamtaro_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (lupin.Visibility == Visibility.Collapsed)
            {
                lamu.Visibility = Visibility.Collapsed;
                NavigationService.Navigate(new Uri("/lvlSet8/s8lvl16.xaml", UriKind.Relative));
            }
            else
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }
      
    }
}
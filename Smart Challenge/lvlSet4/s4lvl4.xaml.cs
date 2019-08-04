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
    public partial class s4lvl4 : PhoneApplicationPage
    {
        public s4lvl4()
        {
            InitializeComponent();
            VarGlobal.flag1 = false;
            VarGlobal.flag2 = false;
            VarGlobal.flag3 = false; 
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Premi SECONDO, QUARTO, PRIMO e TERZO";
                primo.Text = "PRIMO";
                secondo.Text = "SECONDO";
                terzo.Text = "TERZO";
                quarto.Text = "QUARTO";
            }
            else
            {
                Instr.Text = "Tap SECOND, FOURTH, FIRST and THIRD";
                primo.Text = "FIRST";
                secondo.Text = "SECOND";
                terzo.Text = "THIRD";
                quarto.Text = "FOURTH";
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

                NavigationService.Navigate(new Uri("/NewlvlMenu.xaml", UriKind.Relative));
            }
        }

        private void secondo_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            VarGlobal.flag1 = true;
            Instr.Visibility = Visibility.Collapsed;
            secondo.Visibility = Visibility.Collapsed;
        }

        private void quarto_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

            if (VarGlobal.flag1 == true)
            {
                VarGlobal.flag2 = true;
                quarto.Visibility = Visibility.Collapsed;
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

        private void primo_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag2 == true)
            {
                VarGlobal.flag3 = true;
                primo.Visibility = Visibility.Collapsed;
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

        private void terzo_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag3 == true)
            {
                terzo.Visibility = Visibility.Collapsed;
                NavigationService.Navigate(new Uri("/lvlSet4/s4lvl5.xaml", UriKind.Relative));
            }

            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

            

           
    }
}
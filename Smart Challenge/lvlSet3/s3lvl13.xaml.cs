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
    public partial class s3lvl13 : PhoneApplicationPage
    {
        public s3lvl13()
        {
            InitializeComponent();
            VarGlobal.flag1 = false;
            VarGlobal.flag2 = false;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            
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

                NavigationService.Navigate(new Uri("/lvlMenu.xaml", UriKind.Relative));
            }
        } 

            private void grid1_Loaded(object sender, RoutedEventArgs e)
            {
                string checkLang = (string)VarGlobal.settings["lingua"];
                if (checkLang == "Italia")
                {
                    Instr.Text = "Accendi il fuoco: tocca i sassi, l'erba e la legna";

                }
                else
                {
                    Instr.Text = "Light the Fire: touch the stones, grass and wood";
                }
            }

            private void sassi_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                VarGlobal.flag1 = true;
                sassi.Visibility = Visibility.Collapsed;
                Instr.Visibility = Visibility.Collapsed;
            }

            private void erba_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                if (VarGlobal.flag1 == true)
                {
                    VarGlobal.flag2 = true;
                    erba.Visibility = Visibility.Collapsed;
                }
                else
                {
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
                }
            }

            private void ramo_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                if (VarGlobal.flag2 == true)
                {
                    NavigationService.Navigate(new Uri("/lvlSet3/s3lvl14.xaml", UriKind.Relative));
                }

                else
                {
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
                }
            } 

            

           
    }
}
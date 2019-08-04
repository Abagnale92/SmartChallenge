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
    public partial class s6lvl1 : PhoneApplicationPage
    {
        public s6lvl1()
        {
            InitializeComponent();
            VarGlobal.livello = 6;
            VarGlobal.check = 0;

            VarGlobal.flag1 = false;
            VarGlobal.flag2 = false;   
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Forma il pupazzo di neve";

            }
            else
            {
                Instr.Text = "Form the snowman";
            }
            VarGlobal.stopWatch.Start();
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

        private void star_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            VarGlobal.star = true;
            star.Visibility = Visibility.Collapsed;
        }

        private void p1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            VarGlobal.flag1 = true;
            pezzo1.Visibility = Visibility.Visible;
            p1.Visibility = Visibility.Collapsed;
        }

        private void p2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag1 == true)
            {
                VarGlobal.flag2 = true;
                pezzo2.Visibility = Visibility.Visible;
                p2.Visibility = Visibility.Collapsed;
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }

        }

        private void p3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag2 == true)
            {
                
                pezzo3.Visibility = Visibility.Visible;
                p3.Visibility = Visibility.Collapsed;
                NavigationService.Navigate(new Uri("/lvlSet6/s6lvl2.xaml", UriKind.Relative));
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }
     

           
    }
}
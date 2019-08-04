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
    public partial class s6lvl5 : PhoneApplicationPage
    {
        int count = 0;
        public s6lvl5()
        {
            InitializeComponent();
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Fai indossare i cappelli di Natale";

            }
            else
            {
                Instr.Text = "Do wear Christmas hats";
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

        private void p1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            c1.Visibility = Visibility.Visible;

            if(count==3)
                NavigationService.Navigate(new Uri("/lvlSet6/s6lvl6.xaml", UriKind.Relative));           
        }

        private void p2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            c2.Visibility = Visibility.Visible;

            if (count == 3)
                NavigationService.Navigate(new Uri("/lvlSet6/s6lvl6.xaml", UriKind.Relative));  
        }

        private void p3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            c3.Visibility = Visibility.Visible;

            if (count == 3)
                NavigationService.Navigate(new Uri("/lvlSet6/s6lvl6.xaml", UriKind.Relative));  
        }

            

           
    }
}
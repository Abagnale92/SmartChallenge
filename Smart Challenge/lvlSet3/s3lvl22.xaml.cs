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
    public partial class s3lvl22 : PhoneApplicationPage
    {
        int i = 0;
        public s3lvl22()
           
        {
            InitializeComponent();
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Accendi il computer! Premi i pulsanti da sinistra verso destra!";

            }
            else
            {
                Instr.Text = "Turn up the computer! Push the botton from left to right!";
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

                NavigationService.Navigate(new Uri("/lvlMenu.xaml", UriKind.Relative));
            }
        } 

            private void img1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                VarGlobal.flag1 = true;
                img1_2.Visibility = Visibility.Visible;
            }

            private void img2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                if (VarGlobal.flag1 == true)
                {
                    VarGlobal.flag2 = true;
                    img2_2.Visibility = Visibility.Visible;
                    i++;
                }
                else
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
 
            }

            private void img3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                if (VarGlobal.flag2 == true)
                {
                    VarGlobal.flag3 = true;
                    img3_2.Visibility = Visibility.Visible;
                    img2_2.Visibility = Visibility.Collapsed;
                }
                else
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }

            private void img4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                if (VarGlobal.flag3 == true && i == 2)
                {
                    img4_2.Visibility = Visibility.Visible;
                    NavigationService.Navigate(new Uri("/lvlSet3/s3lvl23.xaml", UriKind.Relative));
                }
                else
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            } 

            

           
    }
}
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
    public partial class s3lvl10 : PhoneApplicationPage
    {
        Boolean flag1 = false;
        Boolean flag2 = false;
        Boolean flag3 = false;
        Boolean flag4 = false;

        public s3lvl10()
        {
            InitializeComponent();
            
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Tocca i pinguini dal più grande al più piccolo.";

            }
            else
            {
                Instr.Text = "Touch the penguins from the biggest to the smallest.";
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

            private void img5_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                if (flag4 == true)
                {
                    NavigationService.Navigate(new Uri("/lvlSet3/s3lvl11.xaml", UriKind.Relative));
                }
                else
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }

            private void img2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                flag1 = true;
                img2.Visibility = Visibility.Collapsed;
            }

            private void img4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                if (flag1 == true)
                {
                    flag2 = true;
                    img4.Visibility = Visibility.Collapsed;
                }
                else
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
                
            }

            private void img1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                if (flag2 == true)
                {
                    flag3 = true;
                    img1.Visibility = Visibility.Collapsed;
                }
                else
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }

            private void img3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                if (flag3 == true)
                {
                    flag4 = true;
                    img3.Visibility = Visibility.Collapsed;
                }
                else
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            } 

            

           
    }
}

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
    public partial class s3lvl1 : PhoneApplicationPage
    {
        public s3lvl1()
        {
            InitializeComponent();
            VarGlobal.flag1 = false;
            VarGlobal.flag2 = false;
            VarGlobal.flag3 = false;
            VarGlobal.flag4 = false;
            VarGlobal.flag5 = false;
            VarGlobal.flag6 = false;
            VarGlobal.livello = 3;
            VarGlobal.check = 0;
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            VarGlobal.stopWatch.Start();
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Tocca i bottoni da sinistra verso destra";

            }
            else
            {
                Instr.Text = "Touch the button from left to right";
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

            private void B1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                VarGlobal.flag1 = true;
                B1.Visibility = Visibility.Collapsed;
            }

            private void B2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                if (VarGlobal.flag1 == true)
                {
                    VarGlobal.flag2 = true;
                    B2.Visibility = Visibility.Collapsed;
                }
                else
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }

            private void B3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                if (VarGlobal.flag2 == true)
                {
                    VarGlobal.flag3 = true;
                    B3.Visibility = Visibility.Collapsed;
                    B4.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl3/trg.png") as ImageSource;
                }
                else
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }

            private void ER_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }

            private void B5_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                if (VarGlobal.flag3 == true)
                {
                    VarGlobal.flag4 = true;
                    B5.Visibility = Visibility.Collapsed;
                }
                else
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));

            }

            private void B6_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                if (VarGlobal.flag4 == true)
                {
                    VarGlobal.flag5 = true;
                    B6.Visibility = Visibility.Collapsed;
                }
                else
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }

            private void B7_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                if (VarGlobal.flag5 == true)
                {
                    VarGlobal.flag6 = true;
                    B7.Visibility = Visibility.Collapsed;
                    NavigationService.Navigate(new Uri("/lvlSet3/s3lvl2.xaml", UriKind.Relative));
                }
                else
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            } 

            

           
    }
}
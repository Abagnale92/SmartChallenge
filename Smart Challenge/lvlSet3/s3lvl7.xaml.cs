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
    public partial class s3lvl7 : PhoneApplicationPage
    {
        public s3lvl7()
        {
            InitializeComponent();
           VarGlobal.flag1 = false;
            VarGlobal.flag2 = false;
            VarGlobal.flag3 = false;
            VarGlobal.flag4 = false;
             VarGlobal.flag5 = false;
            VarGlobal.flag6 = false;
            VarGlobal.flag7 = false;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
             string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Ordina le Lettere";

            }
            else
            {
                Instr.Text = "Order the letters";
          
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

        private void B_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
             if (VarGlobal.flag1 == true)
                {
                    VarGlobal.flag2 = true;
                    B.Visibility = Visibility.Collapsed;
                }
                else
                {
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
                }
        }

        private void A_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            VarGlobal.flag1 = true;
                A.Visibility = Visibility.Collapsed;
        }

        private void C_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
             if (VarGlobal.flag2 == true)
                {
                    VarGlobal.flag3 = true;
                    C.Visibility = Visibility.Collapsed;
                }
                else
                {
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
                }
        }

        private void D_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
             if (VarGlobal.flag3 == true)
                {
                    VarGlobal.flag4 = true;
                    D.Visibility = Visibility.Collapsed;
                }
                else
                {
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
                }
        }

        private void E_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
             if (VarGlobal.flag4 == true)
                {
                    VarGlobal.flag5 = true;
                    E.Visibility = Visibility.Collapsed;
                }
                else
                {
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
                }
        }

        private void F_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
             if (VarGlobal.flag5 == true)
                {
                    VarGlobal.flag6 = true;
                    F.Visibility = Visibility.Collapsed;
                }
                else
                {
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
                }
        }

        private void G_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
             if (VarGlobal.flag6 == true)
                {
                    VarGlobal.flag7 = true;
                    G.Visibility = Visibility.Collapsed;
                  NavigationService.Navigate(new Uri("/lvlSet3/s3lvl8.xaml", UriKind.Relative));
                }
                else
                {
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
                }
        }


            }

            

           
    }

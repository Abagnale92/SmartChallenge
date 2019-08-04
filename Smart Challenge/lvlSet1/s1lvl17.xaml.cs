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
    public partial class s1lvl17 : PhoneApplicationPage
    {
        public s1lvl17()
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
                Instr.Text = "Tocca i pinguini da destra verso sinistra";

            }
            else
            {
                Instr.Text = "Touch the penguins from right to left";
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

        private void libro1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            VarGlobal.flag1 = true;
            libro1.Visibility = Visibility.Collapsed;
        }

        private void libro2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag1 == true)
            {
                VarGlobal.flag2 = true;
                libro2.Visibility = Visibility.Collapsed;
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

        private void libro3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag2 == true)
            {
                VarGlobal.flag3 = true;
                libro3.Visibility = Visibility.Collapsed;
                libro4.Visibility = Visibility.Visible;
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

        private void libro4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag3 == true)
            {
                VarGlobal.flag4 = true;
                libro4.Visibility = Visibility.Collapsed;
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

        private void libro5_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag4 == true)
            {
                VarGlobal.flag5 = true;
                libro5.Visibility = Visibility.Collapsed;
                libro6.Visibility = Visibility.Visible;
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

        private void libro6_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag5 == true)
            {
                VarGlobal.flag6 = true;
                libro6.Visibility = Visibility.Collapsed;
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

        private void libro7_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag6 == true)
            {
                VarGlobal.flag7 = true;
                libro6.Visibility = Visibility.Collapsed;
                libro1.Source = null;
                libro2.Source = null;
                libro3.Source = null;
                libro4.Source = null;
                libro5.Source = null;
                libro6.Source = null;
                libro7.Source = null;
                NavigationService.Navigate(new Uri("/lvlSet1/s1lvl18.xaml", UriKind.Relative));
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

       
        }
    }

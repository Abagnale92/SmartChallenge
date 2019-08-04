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
    public partial class s5lvl1 : PhoneApplicationPage
    {

        public s5lvl1()
        {
            InitializeComponent();
            VarGlobal.livello = 5;
            VarGlobal.check = 0;
            VarGlobal.flag1 = false;
            VarGlobal.flag2 = false;
            VarGlobal.flag3 = false;
            VarGlobal.flag4 = false;
            VarGlobal.flag6 = false;
            VarGlobal.flag7 = false;
            VarGlobal.flag8 = false;
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Ordina in modo crescente";
            }
            else
            {
                Instr.Text = "Sort in ascending order";
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

        private void p1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            VarGlobal.flag1 = true;
            p1.Visibility = Visibility.Collapsed;
        }

        private void p2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag1 == true)
            {
                VarGlobal.flag2 = true;
                p2.Visibility = Visibility.Collapsed;
                l2.Visibility = Visibility.Visible;
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
                VarGlobal.flag3 = true;
                p3.Visibility = Visibility.Collapsed;
                l3.Visibility = Visibility.Visible;
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

        private void p4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag3 == true)
            {
                VarGlobal.flag4 = true;
                p4.Visibility = Visibility.Collapsed;
                l4.Visibility = Visibility.Visible;
                l5.Visibility = Visibility.Visible;
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

        private void p5_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag4 == true)
            {
                VarGlobal.flag5 = true;
                p5.Visibility = Visibility.Collapsed;
                l6.Visibility = Visibility.Visible;
                
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

        private void p6_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag5 == true)
            {
                VarGlobal.flag6 = true;
                p6.Visibility = Visibility.Collapsed;
                l7.Visibility = Visibility.Visible;
                l8.Visibility = Visibility.Visible;
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

        private void p7_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag6 == true)
            {
                VarGlobal.flag7 = true;
                p7.Visibility = Visibility.Collapsed;
                l9.Visibility = Visibility.Visible;
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

        private void p8_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag7 == true)
            {
                VarGlobal.flag8 = true;
                p8.Visibility = Visibility.Collapsed;
                l1.Visibility = Visibility.Visible;
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

        private void p9_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag8 == true)
            {

                p9.Visibility = Visibility.Collapsed;
                l10.Visibility = Visibility.Visible;
                ok.Visibility = Visibility.Visible;
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

        private void ok_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/lvlSet5/s5lvl2.xaml", UriKind.Relative));
        }
     

           
    }
}
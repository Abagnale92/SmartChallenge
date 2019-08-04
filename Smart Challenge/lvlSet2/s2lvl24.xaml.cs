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
    public partial class s2lvl24 : PhoneApplicationPage
    {
        public s2lvl24()
        {
            InitializeComponent();
            VarGlobal.flag1 = false;
            VarGlobal.flag2 = false;
            VarGlobal.flag3 = false;
            VarGlobal.flag4 = false;
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Ordina i paesi dal più freddo al più caldo!";
                bot1.Content = "Deserto del Lut";
            }
            else
            {
                Instr.Text = "Order the countries from colder to warmer!";
                bot1.Content= "Lut desert";
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

            private void bot1_MouseEnter(object sender, MouseEventArgs e)
            {
                if (VarGlobal.flag4 == true)
                {
                    NavigationService.Navigate(new Uri("/lvlSet2/s2lvl25.xaml", UriKind.Relative));
                }
                else
                {
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
                }
            }


            private void bot1_Copy_MouseEnter(object sender, MouseEventArgs e)
            {
                VarGlobal.flag1 = true;
                bot1_Copy.Visibility = Visibility.Collapsed;
            }


            private void bot1_Copy1_MouseEnter(object sender, MouseEventArgs e)
            {
                if (VarGlobal.flag1 == true)
                {
                    VarGlobal.flag2 = true;
                    bot1_Copy1.Visibility = Visibility.Collapsed;
                }
                else
                {
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
                }
            }


            private void bot1_Copy2_MouseEnter(object sender, MouseEventArgs e)
            {
                if (VarGlobal.flag3 == true)
                {
                    VarGlobal.flag4 = true;
                    bot1_Copy2.Visibility = Visibility.Collapsed;
                }
                else
                {
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
                }
            }


            private void bot1_Copy3_MouseEnter(object sender, MouseEventArgs e)
            {
                if (VarGlobal.flag2 == true)
                {
                    VarGlobal.flag3 = true;
                    bot1_Copy3.Visibility = Visibility.Collapsed;
                }
                else
                {
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
                }
            } 

            

           
    }
}
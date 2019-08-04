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
    public partial class s2lvl7 : PhoneApplicationPage
    {
        public s2lvl7()
        {
            InitializeComponent();
            VarGlobal.flag1 = false;
            VarGlobal.flag2 = false;
            VarGlobal.flag3 = false;
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Tocca le immagini per ordine cronologico!";

            }
            else
            {
                Instr.Text = "Touch the images for chronologic's order! ";
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

            private void Im1_MouseEnter(object sender, MouseEventArgs e)
            {
                VarGlobal.flag1 = true;
                Im1.Visibility = Visibility.Collapsed;
            }

            private void Im4_MouseEnter(object sender, MouseEventArgs e)
            {
                if (VarGlobal.flag3 == true)
                {
                    Im1.Source = null;
                    Im2.Source = null;
                    Im3.Source = null;
                    Im4.Source = null;
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    NavigationService.Navigate(new Uri("/lvlSet2/s2lvl8.xaml", UriKind.Relative));
                }
                else
                {
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
                }
            }

            private void Im2_MouseEnter(object sender, MouseEventArgs e)
            {
                if (VarGlobal.flag1 == true)
                {
                    VarGlobal.flag2 = true;
                    Im2.Visibility = Visibility.Collapsed;
                }
                else
                {
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
                }
            }


            private void Im3_MouseEnter(object sender, MouseEventArgs e)
            {
                if (VarGlobal.flag2 == true)
                {
                    VarGlobal.flag3 = true;
                    Im3.Visibility = Visibility.Collapsed;
                }
                else
                {
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
                }
            } 

            

           
    }
}
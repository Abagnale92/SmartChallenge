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
    public partial class s1lvl12 : PhoneApplicationPage
    {
        public s1lvl12()
        {
            InitializeComponent();
            VarGlobal.flag1 = false;
            VarGlobal.flag2 = false;
            VarGlobal.flag3 = false;
            VarGlobal.flag4 = false;
            VarGlobal.flag5 = false;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Tocca i pinguini da sinistra verso destra";

            }
            else
            {
                Instr.Text = "Touch the penguins from left to right";
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

            private void duck1_MouseEnter(object sender, MouseEventArgs e)
            {
                VarGlobal.flag1 = true;
                duck1.Visibility = Visibility.Collapsed;
            }

            private void duck2_MouseEnter(object sender, MouseEventArgs e)
            {
                if (VarGlobal.flag1 == true)
                {
                    VarGlobal.flag2 = true;
                    duck2.Visibility = Visibility.Collapsed;
                }
                else
                {
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
                }
            }

            private void duck3_MouseEnter(object sender, MouseEventArgs e)
            {
                if (VarGlobal.flag2 == true)
            {
                VarGlobal.flag3 = true;
                duck3.Visibility = Visibility.Collapsed;
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
            }

            private void duck4_MouseEnter(object sender, MouseEventArgs e)
            {
                  if (VarGlobal.flag3 == true)
            {
                VarGlobal.flag4 = true;
                duck4.Visibility = Visibility.Collapsed;
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
            }

            private void duck5_MouseEnter(object sender, MouseEventArgs e)
            {
                if (VarGlobal.flag4 == true)
                {
                    duck1.Source = null;
                    duck2.Source = null;
                    duck3.Source = null;
                    duck4.Source = null;
                    duck5.Source = null;
                    NavigationService.Navigate(new Uri("/lvlSet1/s1lvl13.xaml", UriKind.Relative));
                }

                else
                {
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
                }
            } 

            

           
    }
}
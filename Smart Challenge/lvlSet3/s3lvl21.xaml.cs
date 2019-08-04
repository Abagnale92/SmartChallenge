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
    public partial class s3lvl21 : PhoneApplicationPage
    {
        public s3lvl21()
        {
            InitializeComponent();
            VarGlobal.flag1 = false;
            VarGlobal.flag2 = false;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            
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

            private void grid1_Loaded(object sender, RoutedEventArgs e)
            {
                string checkLang = (string)VarGlobal.settings["lingua"];
                if (checkLang == "Italia")
                {
                    Instr.Text = "La stazione radio è spenta: premi gli interruttori da sinistra verso destra!";

                }
                else
                {
                    Instr.Text = "The radio station is off: press the switches from left to right!";
                }
            }

            private void off1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                VarGlobal.flag1 = true;
                off1.Visibility = Visibility.Collapsed;
                on1.Visibility = Visibility;
                
            }

            private void off2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                if (VarGlobal.flag1 == true)
                {
                    VarGlobal.flag2 = true;
                    off2.Visibility = Visibility.Collapsed;
                    on2.Visibility = Visibility;
                }
                else
                {
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
                }
            }

            private void off3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                if (VarGlobal.flag2 == true)
                {
                    on3.Visibility = Visibility;
                    NavigationService.Navigate(new Uri("/lvlSet3/s3lvl22.xaml", UriKind.Relative));
                }

                else
                {
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
                }
            }


            

           
    }
}
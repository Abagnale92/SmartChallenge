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
using System.Windows.Threading;

namespace Smart_Challenge
{
    public partial class s1lvl4 : PhoneApplicationPage
    {
        public s1lvl4()
        {
            InitializeComponent();
            VarGlobal.flag1 = false;
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

        private void PhoneApplicationPage_Loaded_1(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Moltiplica i numeri di colore blu nel livello precedente";

            }
            else
            {
                Instr.Text = "Multiply the blue numbers in the previous level";
            }
        }

        private void numPad0_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag1 == false)
            {
                calc1.Text = calc1.Text + "0";
            }
            else
            {
                calc2.Text = calc2.Text + "0";
            }
        }

        private void numPad1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag1 == false)
            {
                calc1.Text = calc1.Text + "1";
            }
            else
            {
                calc2.Text = calc2.Text + "1";
            }
        }

        private void numPad2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag1 == false)
            {
                calc1.Text = calc1.Text + "2";
            }
            else
            {
                calc2.Text = calc2.Text + "2";
            }
        }

        private void numPad3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag1 == false)
            {
                calc1.Text = calc1.Text + "3";
            }
            else
            {
                calc2.Text = calc2.Text + "3";
            }
        }

        private void numPad4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag1 == false)
            {
                calc1.Text = calc1.Text + "4";
            }
            else
            {
                calc2.Text = calc2.Text + "4";
            }
        }

        private void numPad5_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag1 == false)
            {
                calc1.Text = calc1.Text + "5";
            }
            else
            {
                calc2.Text = calc2.Text + "5";
            }
        }

        private void numPad6_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag1 == false)
            {
                calc1.Text = calc1.Text + "6";
            }
            else
            {
                calc2.Text = calc2.Text + "6";
            }
        }

        private void numPad7_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag1 == false)
            {
                calc1.Text = calc1.Text + "7";
            }
            else
            {
                calc2.Text = calc2.Text + "7";
            }
        }

        private void numPad8_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag1 == false)
            {
                calc1.Text = calc1.Text + "8";
            }
            else
            {
                calc2.Text = calc2.Text + "8";
            }
        }

        private void numPad9_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag1 == false)
            {
                calc1.Text = calc1.Text + "9";
            }
            else
            {
                calc2.Text = calc2.Text + "9";
            }
        }

        private void numPadX_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (calc1.Text != "")
                VarGlobal.flag1 = true;
                calc1.Visibility = Visibility.Collapsed;
                calc2.Visibility = Visibility;
        }

        private void numPadM_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

        private void numPadP_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

        private void numPadU_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (calc2.Text != "")
            {
                if (calc1.Text == "15" && calc2.Text == "6" || calc1.Text == "6" && calc2.Text == "15")
                    NavigationService.Navigate(new Uri("/lvlSet1/s1lvl5.xaml", UriKind.Relative));
                else
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }
    }


}
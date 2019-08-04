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
    public partial class s1lvl3 : PhoneApplicationPage
    {
        public s1lvl3()
        {
            InitializeComponent();
            VarGlobal.flag1 = false;
            VarGlobal.flag2 = false;
            VarGlobal.flag3 = false;
            VarGlobal.flag4 = false;
            VarGlobal.flag5 = false;
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Tocca i numeri nel seguente ordine: 15-9-3-6-8";

            }
            else
            {
                Instr.Text = "Tap the numbers in this order: 15-9-3-6-8";
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

        private void n3_MouseEnter(object sender, MouseEventArgs e)
        {
            if (VarGlobal.flag2 == true)
            {
                VarGlobal.flag3 = true;
                n3.Visibility = Visibility.Collapsed;
                n8.Margin = new Thickness(190, 210, 152, 195);
                n6.Margin = new Thickness(180, 200, 350, 180);
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

        private void n8_MouseEnter(object sender, MouseEventArgs e)
        {
            if (VarGlobal.flag4 == true)
            {
                NavigationService.Navigate(new Uri("/lvlSet1/s1lvl4.xaml", UriKind.Relative));
            }

            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

        private void n6_MouseEnter(object sender, MouseEventArgs e)
        {
            if (VarGlobal.flag3 == true)
            {
                VarGlobal.flag4 = true;
                n6.Visibility = Visibility.Collapsed;
                n8.Margin = new Thickness(367, 0, 0, 181);
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

        private void n15_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            VarGlobal.flag1 = true;
            n15.Visibility = Visibility.Collapsed;
            Instr.Visibility = Visibility.Collapsed;
            n9.Margin = new Thickness(0, 0, 274, 293);
            n8.Margin = new Thickness(155, 0, 0, 270);
            n6.Margin = new Thickness(0, 265, 119, 164);
            n3.Margin = new Thickness(267, 266, 462, 147);
        }

        private void n9_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag1 == true)
            {
                VarGlobal.flag2 = true;
                n9.Visibility = Visibility.Collapsed;
                n8.Margin = new Thickness(180, 200, 120, 180);
                n6.Margin = new Thickness(150, 223, 152, 195);
                n3.Margin = new Thickness(518, 93, 211, 320);
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }








        
    }

}
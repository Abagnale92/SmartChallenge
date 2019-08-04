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
    public partial class s5lvl9 : PhoneApplicationPage
    {
        public s5lvl9()
        {
            InitializeComponent();
            VarGlobal.flag1 = false;
            VarGlobal.flag2 = false;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Tappa dal basso verso l'alto";

            }
            else
            {
                Instr.Text = "Tap from the bottom to up";
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

                NavigationService.Navigate(new Uri("/NewlvlMenu.xaml", UriKind.Relative));
            }
        }

        private void star_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            VarGlobal.star = true;
            star.Visibility = Visibility.Collapsed;
        }

        private void b3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            VarGlobal.flag1 = true;
            b3.Visibility = Visibility.Collapsed;
        }

        private void b2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag1 == true)
            {
                VarGlobal.flag2 = true;
                b2.Visibility = Visibility.Collapsed;
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

        private void b1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag2 == true)
            {
                NavigationService.Navigate(new Uri("/lvlSet5/s5lvl10.xaml", UriKind.Relative));
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

            

           
    }
}
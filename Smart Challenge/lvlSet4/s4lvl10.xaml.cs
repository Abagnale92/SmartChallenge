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
    public partial class s4lvl10 : PhoneApplicationPage
    {
        public s4lvl10()
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
                Instr.Text = "Ordina in modo crescente";

            }
            else
            {
                Instr.Text = "Sort in ascending order";
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


        private void l2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            VarGlobal.flag1 = true;
        }

        private void n2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag1 == true)
            {
                VarGlobal.flag2 = true;
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

        private void l1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag2 == true)
            {
                VarGlobal.flag3 = true;
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

        private void n1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag3 == true)
            {
                NavigationService.Navigate(new Uri("/lvlSet4/s4lvl11.xaml", UriKind.Relative));
            }

            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }
           
    }
}
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
    public partial class s7lvl3 : PhoneApplicationPage
    {
        int count;
        public s7lvl3()
        {
            InitializeComponent();
            count = 0;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Premi sugli squali piccoli";

            }
            else
            {
                Instr.Text = "Tap the small sharks";
            }

            go.Begin();
            onde.Begin();

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

                NavigationService.Navigate(new Uri("/UltimolvlMenu.xaml", UriKind.Relative));
            }
        }

        private void g_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

        private void p1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            p1.Visibility = Visibility.Collapsed;
            if (count == 3)
                NavigationService.Navigate(new Uri("/lvlSet7/s7lvl4.xaml", UriKind.Relative));
        }

        private void p2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            p2.Visibility = Visibility.Collapsed;
            if (count == 3)
                NavigationService.Navigate(new Uri("/lvlSet7/s7lvl4.xaml", UriKind.Relative));
        }

        private void p3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            p3.Visibility = Visibility.Collapsed;
            if (count == 3)
                NavigationService.Navigate(new Uri("/lvlSet7/s7lvl4.xaml", UriKind.Relative));
        }
      
    }
}
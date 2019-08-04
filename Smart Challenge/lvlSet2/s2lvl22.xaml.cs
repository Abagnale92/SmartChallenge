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
    public partial class s2lvl22 : PhoneApplicationPage
    {
        public s2lvl22()
        {
            InitializeComponent();
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];

            if (checkLang == "Italia")
            {
                Instr.Text = "Quale animale o animali possono equilibrare la bilancia al centro?";
                b1.Content = "Orso";
                b2.Content = "Orso e Topo";
                b3.Content = "Topo";
            }
            else
            {
                Instr.Text = "What animal or animals can balance the scales in the center?";
                b1.Content = "Bear";
                b2.Content = "Bear and Mouse";
                b3.Content = "Mouse";
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

            private void grid1_Loaded(object sender, RoutedEventArgs e)
            {
               
            }

            private void btn_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                Button rispScelta = (Button)sender;
                string asd = rispScelta.Name;
                string asd2 = asd.Substring(1);
                if (asd2 == "2")
                {
                    NavigationService.Navigate(new Uri("/lvlSet2/s2lvl23.xaml", UriKind.Relative));
                }
                else
                {
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
                }
            }

           
    }
}
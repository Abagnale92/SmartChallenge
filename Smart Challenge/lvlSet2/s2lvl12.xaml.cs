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
    public partial class s2lvl12 : PhoneApplicationPage
    {
        public s2lvl12()
        {
            InitializeComponent();
           
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

                    Instr.Text = "Cosa bevono di solito gli inglesi alle 17:00?";


                else

                    Instr.Text = "What do you usually drink the British at 5:00 pm?";
            }

            private void s_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                Image lol = (Image)sender;
                string asd = lol.Name;
                string asd2 = asd.Substring(1);
                if (asd2 == "2")
                {
                    s1.Source = null;
                    s2.Source = null;
                    s3.Source = null;
                    GC.Collect();
                    NavigationService.Navigate(new Uri("/lvlSet2/s2lvl13.xaml", UriKind.Relative));
                }
                else
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }

          

            
            

           
    }
}
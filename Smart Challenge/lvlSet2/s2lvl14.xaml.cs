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
    public partial class s2lvl14 : PhoneApplicationPage
    {
        public s2lvl14()
        {
            InitializeComponent();
          
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];

            if (checkLang == "Italia")

                Instr.Text = "Scegli l'oggetto giusto.";


            else

                Instr.Text = "Choose the right one.";
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

            private void image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                string c = (((Image)sender).Name).Substring(3);
                if (c == "1")
                {
                    hat1.Source = null;
                    hat2.Source = null;
                    hat3.Source = null;
                    NavigationService.Navigate(new Uri("/lvlSet2/s2lvl15.xaml", UriKind.Relative));
                }
                else
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            } 

            

           
    }
}
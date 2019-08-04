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
    public partial class s3lvl17 : PhoneApplicationPage
    {
        public s3lvl17()
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
                {
                    Instr.Text = "Ti attaccano: scegli l'oggetto     sto.";
                    Instr1.Text = " giu";
                }
                else
                {
                    Instr.Text = "Attack you: choose the object";
                    Instr2.Text = "right.";
                }
            }

            private void o_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                Image lol = (Image)sender;
                string asd = lol.Name;
                string asd2 = asd.Substring(1);
                if (asd2 == "3")
                    NavigationService.Navigate(new Uri("/lvlSet3/s3lvl18.xaml", UriKind.Relative));
                else
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }

           
    }
}
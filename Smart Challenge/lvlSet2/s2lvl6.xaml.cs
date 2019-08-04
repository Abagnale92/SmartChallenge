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
    public partial class s2lvl6 : PhoneApplicationPage
    {
        public s2lvl6()
        {
            InitializeComponent();
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Quante coppie di animali portò Mosè sull'Arca?";
                bot1.Content = "Nessuna";
                bot2.Content = "100 coppie";
                bot3.Content = "Più di 100 coppie";
            }
            else
            {
                Instr.Text = "How many animal's couples Moses brought on the Ark? ";
                bot1.Content = "None";
                bot2.Content = "100 couple";
                bot3.Content = "More than 100 couple";
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

            private void Button_Click_1(object sender, RoutedEventArgs e)
            {
                 Button rispScelta = (Button)sender;
            string c = rispScelta.Content.ToString();
            if (c == "Nessuna" || c == "None")
            {
                Arca.Source = null;
                NavigationService.Navigate(new Uri("/lvlSet2/s2lvl7.xaml", UriKind.Relative));
            }
            else
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            } 

            

           
    }
}
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
    public partial class s2lvl10 : PhoneApplicationPage
    {
        public s2lvl10()
        {
            InitializeComponent();
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Ricordi quale pezzo mancava nel livello 4?";

            }
            else
            {
                Instr.Text = "Do you remember which piece was missing in the level 4?";
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

            private void piece_tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
               
                Image lol = (Image)sender;
                String nome = lol.Name;
                nome = nome.Substring(5);
                if (nome == "1")
                {
                    piece1.Source = null;
                    piece3.Source = null;
                    piece2.Source = null;
                    piece4.Source = null;
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    NavigationService.Navigate(new Uri("/lvlSet2/s2lvl11.xaml", UriKind.Relative));
                }
                else
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));

            } 

            

           
    }
}
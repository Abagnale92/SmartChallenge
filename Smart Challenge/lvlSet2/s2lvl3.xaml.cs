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
    public partial class s2lvl3 : PhoneApplicationPage
    {
        public s2lvl3()
        {
            InitializeComponent();
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Ora scegli la porta con la toppa giusta.";

            }
            else
            {
                Instr.Text = "Now choose the door with the right keyhole.";
            }
        }





        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult m = MessageBox.Show("Vuoi davvero fermare la partita?", "Attenzione!", MessageBoxButton.OKCancel);
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

            private void door_tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
               
                Image lol = (Image)sender;
                String nome = lol.Name;
                nome = nome.Substring(4);
                if (nome == "1")
                {
                    door1.Source = null;
                    door2.Source = null;
                    door3.Source = null;
                    

                    NavigationService.Navigate(new Uri("/lvlSet2/s2lvl4.xaml", UriKind.Relative));
                }
                else
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));

            } 

            

           
    }
}
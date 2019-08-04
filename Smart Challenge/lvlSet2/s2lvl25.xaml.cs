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
    public partial class s2lvl25 : PhoneApplicationPage
    {
        public s2lvl25()
        {
            InitializeComponent();
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Si torna a casa : scegli la nave per un ritorno sicuro!";
                N3.Text = "Zattera"; 
            }
            else
            {
                Instr.Text = "You return home: choose the ship for a safe return!";
                N3.Text = "Raft";
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

            private void Titanic_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }

            private void concordia_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }

            private void zattera_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                if((int)VarGlobal.flaglvl2["value"] < 2)
                 VarGlobal.flaglvl2["value"] = 2;
                VarGlobal.stopWatch.Stop();
                VarGlobal.check = 0;
                NavigationService.Navigate(new Uri("/end.xaml", UriKind.Relative));
               
            } 

            

           
    }
}
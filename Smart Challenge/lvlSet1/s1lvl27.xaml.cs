using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Smart_Challenge.lvlSet1
{
    public partial class s1lvl27 : PhoneApplicationPage
    {
        public s1lvl27()
        {
            InitializeComponent();
            VarGlobal.scelta = false;
        }

        private void grid1_Loaded(object sender, RoutedEventArgs e)
        {
            // Testo-Lingua
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Scegli : Dolcino o Veleno?";

            }
            else
            {
                Instr.Text = "Choose: Sweet or Poison?";
            }
        }

        private void Dolcetto_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Dolcetto.Source = null;
            Poison.Source = null;
            NavigationService.Navigate(new Uri("/lvlSet1/s1lvl28.xaml", UriKind.Relative));
        }

        private void Poison_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            VarGlobal.scelta = true;
            Dolcetto.Source = null;
            Poison.Source = null;
            NavigationService.Navigate(new Uri("/lvlSet1/s1lvl28.xaml", UriKind.Relative));
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
    }
}
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
    public partial class s4lvl8 : PhoneApplicationPage
    {
        public s4lvl8()
        {
            InitializeComponent();
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Inserisci 89559339";

            }
            else
            {
                Instr.Text = "Insert 89559339";
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

                NavigationService.Navigate(new Uri("/NewlvlMenu.xaml", UriKind.Relative));
            }
        }

        private void numPad(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Image lol = (Image)sender;
            calc1.Text += lol.Name.Substring(1);
            Instr.Visibility = Visibility.Collapsed;
        }

        private void numPad0_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (calc1.Text == "89559339")
                NavigationService.Navigate(new Uri("/lvlSet4/s4lvl9.xaml", UriKind.Relative));
            else
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

           
    }
}
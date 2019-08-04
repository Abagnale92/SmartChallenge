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
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Media;
namespace Smart_Challenge
{
    public partial class s6lvl22 : PhoneApplicationPage
    {
        int count = 0;
        public s6lvl22()
        {
            InitializeComponent();
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Filo rosso o filo blu?";
                rosso.Text = "FILO ROSSO";
                blu.Text = "FILO BLU";

            }
            else
            {
                Instr.Text = "Red wire or blue wire?";
                rosso.Text = "RED WIRE";
                blu.Text = "BLUE WIRE";
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

        private void blu_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            trema.Begin();
            trema.Completed += trema_Completed;
        }

        private void rosso_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            trema.Begin();
            trema.Completed += trema_Completed;
        }


        void trema_Completed(object sender, EventArgs e)
        {
            if (count > 0)
            {
                fiamma.Visibility = Visibility.Collapsed;
                NavigationService.Navigate(new Uri("/lvlSet6/s6lvl23.xaml", UriKind.Relative));
            }
            else
            {
                fiamma.Visibility = Visibility.Collapsed;
                bomba.Visibility = Visibility.Collapsed;
                boom.Visibility = Visibility.Visible;
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }
           
    }
}
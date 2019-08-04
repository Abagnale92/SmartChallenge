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
    public partial class s5lvl5 : PhoneApplicationPage
    {
        int count = 0;
        public s5lvl5()
        {
            InitializeComponent();
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Tappa i colori sbagliati";
                rosso1.Text = "ROSSO";
                rosso2.Text = "ROSSO";
                rosso3.Text = "ROSSO";
                blu1.Text = "BLU";
                blu2.Text = "BLU";
                blu3.Text = "BLU";
                verde1.Text = "VERDE";
                verde2.Text = "VERDE";
                verde3.Text = "VERDE";
                viola1.Text = "VIOLA";
                viola2.Text = "VIOLA";
                viola3.Text = "VIOLA";

            }
            else
            {
                Instr.Text = "Tap wrong colors";
                rosso1.Text = "RED";
                rosso2.Text = "RED";
                rosso3.Text = "RED";
                blu1.Text = "BLUE";
                blu2.Text = "BLUE";
                blu3.Text = "BLUE";
                verde1.Text = "GREEN";
                verde2.Text = "GREEN";
                verde3.Text = "GREEN";
                viola1.Text = "VIOLET";
                viola2.Text = "VIOLET";
                viola3.Text = "VIOLET";
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

        private void NO_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

        private void viola1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            viola1.Visibility = Visibility.Collapsed;
            if (count == 3)
                NavigationService.Navigate(new Uri("/lvlSet5/s5lvl6.xaml", UriKind.Relative));
        }

        private void blu2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            blu2.Visibility = Visibility.Collapsed;
            if (count == 3)
                NavigationService.Navigate(new Uri("/lvlSet5/s5lvl6.xaml", UriKind.Relative));
        }

        private void rosso3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            rosso3.Visibility = Visibility.Collapsed;
            if (count == 3)
                NavigationService.Navigate(new Uri("/lvlSet5/s5lvl6.xaml", UriKind.Relative));
        }

            

           
    }
}
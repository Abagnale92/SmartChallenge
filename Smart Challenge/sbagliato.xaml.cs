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
    public partial class sbagliato : PhoneApplicationPage
    {

        public sbagliato()
        {
            InitializeComponent();
            if (VarGlobal.check != 0)
            {
                checkpoint.Visibility = Visibility.Visible;
                arrow.Visibility = Visibility.Visible;
                bar.Visibility = Visibility.Visible;
            }
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                checkpoint.Text = "ritorna al checkpoint";
                wrong.Text = "sbagliato!";
                menu.Text = "ritorna all'inizio";
            }
            else
            {
                checkpoint.Text = "return to the checkpoint";
                wrong.Text = "wrong!";
                menu.Text = "return to the beginning";

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

                switch (VarGlobal.livello)
                {
                    case 1: NavigationService.Navigate(new Uri("/lvlMenu.xaml", UriKind.Relative)); break;
                    case 2: NavigationService.Navigate(new Uri("/lvlMenu.xaml", UriKind.Relative)); break;
                    case 3: NavigationService.Navigate(new Uri("/lvlMenu.xaml", UriKind.Relative)); break;
                    case 4: NavigationService.Navigate(new Uri("/NewlvlMenu.xaml", UriKind.Relative)); break;
                    case 5: NavigationService.Navigate(new Uri("/NewlvlMenu.xaml", UriKind.Relative)); break;
                    case 6: NavigationService.Navigate(new Uri("/NewlvlMenu.xaml", UriKind.Relative)); break;
                    case 7: NavigationService.Navigate(new Uri("/UltimolvlMenu.xaml", UriKind.Relative)); break;
                    case 8: NavigationService.Navigate(new Uri("/UltimolvlMenu.xaml", UriKind.Relative)); break;
                    case 9: NavigationService.Navigate(new Uri("/UltimolvlMenu.xaml", UriKind.Relative)); break;
                }

            }
        } 

      

        private void checkpoint_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            switch (VarGlobal.check)
            {
                case 1: NavigationService.Navigate(new Uri("/lvlSet1/s1lvl10.xaml", UriKind.Relative)); break;
                case 2: NavigationService.Navigate(new Uri("/lvlSet1/s1lvl20.xaml", UriKind.Relative)); break;
                case 3: NavigationService.Navigate(new Uri("/lvlSet2/s2lvl13.xaml", UriKind.Relative)); break;
                case 4: NavigationService.Navigate(new Uri("/lvlSet3/s3lvl12.xaml", UriKind.Relative)); break;
                case 5: NavigationService.Navigate(new Uri("/lvlSet4/s4lvl11.xaml", UriKind.Relative)); break;
                case 6: NavigationService.Navigate(new Uri("/lvlSet5/s5lvl11.xaml", UriKind.Relative)); break;
                case 7: NavigationService.Navigate(new Uri("/lvlSet6/s6lvl11.xaml", UriKind.Relative)); break;
                case 8: NavigationService.Navigate(new Uri("/lvlSet7/s7lvl12.xaml", UriKind.Relative)); break;
                case 9: NavigationService.Navigate(new Uri("/lvlSet8/s8lvl8.xaml", UriKind.Relative)); break;
                case 10: NavigationService.Navigate(new Uri("/lvlSet8/s8lvl15.xaml", UriKind.Relative)); break;
                case 11: NavigationService.Navigate(new Uri("/lvlSet9/s9lvl10.xaml", UriKind.Relative)); break;
            }
        }

        private void menu_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            switch (VarGlobal.livello)
            {
                case 1: NavigationService.Navigate(new Uri("/lvlSet1/s1lvl1.xaml", UriKind.Relative)); break;
                case 2: NavigationService.Navigate(new Uri("/lvlSet2/s2lvl1.xaml", UriKind.Relative)); break;
                case 3: NavigationService.Navigate(new Uri("/lvlSet3/s3lvl1.xaml", UriKind.Relative)); break;
                case 4: NavigationService.Navigate(new Uri("/lvlSet4/s4lvl1.xaml", UriKind.Relative)); break;
                case 5: NavigationService.Navigate(new Uri("/lvlSet5/s5lvl1.xaml", UriKind.Relative)); break;
                case 6: NavigationService.Navigate(new Uri("/lvlSet6/s6lvl1.xaml", UriKind.Relative)); break;
                case 7: NavigationService.Navigate(new Uri("/lvlSet7/s7lvl1.xaml", UriKind.Relative)); break;
                case 8: NavigationService.Navigate(new Uri("/lvlSet8/s8lvl1.xaml", UriKind.Relative)); break;
                case 9: NavigationService.Navigate(new Uri("/lvlSet9/s9lvl1.xaml", UriKind.Relative)); break;
            }
        } 
    }
}
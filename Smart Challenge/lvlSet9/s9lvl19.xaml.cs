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
    public partial class s9lvl19 : PhoneApplicationPage
    {
        int c;
        public s9lvl19()
        {
            InitializeComponent();
            c = 0;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Uccidi l'alieno";

            }
            else
            {
                Instr.Text = "Kill the alien";
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
                go.Stop();
                while (NavigationService.CanGoBack)
                {
                    NavigationService.RemoveBackEntry();
                }

                NavigationService.Navigate(new Uri("/UltimolvlMenu.xaml", UriKind.Relative));
            }
        }

        private void m_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            go.Begin();
            c++;

            switch (c)
            {
                case 1:
                    {
                        a1.Visibility = Visibility.Collapsed;
                        a2.Visibility = Visibility.Visible;
                        break;
                    }
                case 2:
                    {
                        a2.Visibility = Visibility.Collapsed;
                        a3.Visibility = Visibility.Visible;
                        break;
                    }
                case 3:
                    {
                        go.Stop();
                        NavigationService.Navigate(new Uri("/lvlSet9/s9lvl20.xaml", UriKind.Relative));
                        break;
                    }
            }
        }
      
    }
}
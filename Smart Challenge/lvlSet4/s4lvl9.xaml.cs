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
    public partial class s4lvl9 : PhoneApplicationPage
    {
        public s4lvl9()
        {
            InitializeComponent();
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Chi è la cognata della sorella di tuo padre?";
                b1.Content = "Tua zia";
                b2.Content = "Tua madre";
                b3.Content = "Tua nonna";
            }
            else
            {
                Instr.Text = "Who is the sister in law of your father's sister?";
                b1.Content = "Your aunt";
                b2.Content = "Your mother";
                b3.Content = "Your grandmother";
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


        private void btn_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Button rispScelta = (Button)sender;
            string asd = rispScelta.Name;
            string asd2 = asd.Substring(1);
            if (asd2 == "2")
            {
                NavigationService.Navigate(new Uri("/lvlSet4/s4lvl10.xaml", UriKind.Relative));
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }
           
    }
}
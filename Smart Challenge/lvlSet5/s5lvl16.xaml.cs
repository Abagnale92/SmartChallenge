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
    public partial class s5lvl16 : PhoneApplicationPage
    {
        int count = 0;
        public s5lvl16()
        {
            InitializeComponent();
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Quanto pesano tutti e tre insieme?";

            }
            else
            {
                Instr.Text = "How much they weigh all three together?";
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

        private void piu_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            num.Text = count.ToString();
        }

        private void meno_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count--;
            num.Text = count.ToString();
        }

        private void ok_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (count == 27)
                NavigationService.Navigate(new Uri("/lvlSet5/s5lvl17.xaml", UriKind.Relative));
            else
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

           
    }
}
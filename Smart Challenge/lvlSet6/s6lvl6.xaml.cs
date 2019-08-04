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
    public partial class s6lvl6 : PhoneApplicationPage
    {
        int count = 0;
        public s6lvl6()
        {
            InitializeComponent();
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            pingu.Begin();
            pingu.AutoReverse = true;
            pingu.Completed += pingu_Completed;

            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Togli i cappelli di Natale";

            }
            else
            {
                Instr.Text = "Take away Christmas hats";
            }
        }

        void pingu_Completed(object sender, EventArgs e)
        {
            pingu.Begin();
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

        private void p1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            c1.Visibility = Visibility.Collapsed;

            if (count == 3)
                NavigationService.Navigate(new Uri("/lvlSet6/s6lvl7.xaml", UriKind.Relative));
        }

        private void p2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            c2.Visibility = Visibility.Collapsed;

            if (count == 3)
                NavigationService.Navigate(new Uri("/lvlSet6/s6lvl7.xaml", UriKind.Relative));
        }

        private void p3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            c3.Visibility = Visibility.Collapsed;

            if (count == 3)
                NavigationService.Navigate(new Uri("/lvlSet6/s6lvl7.xaml", UriKind.Relative));
        }

           
    }
}
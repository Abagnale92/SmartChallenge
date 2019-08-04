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
    public partial class s6lvl12 : PhoneApplicationPage
    {
        int count = 0;
        public s6lvl12()
        {
            InitializeComponent();
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            punti.Begin();
            punti.Completed += punti_Completed;

            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Quanti erano i puntini gialli?";

            }
            else
            {
                Instr.Text = "How many were the yellow dots?";
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

        void punti_Completed(object sender, EventArgs e)
        {
            punti.Begin();

            Instr.Visibility = Visibility.Visible;
            meno.Visibility = Visibility.Visible;
            num.Visibility = Visibility.Visible;
            piu.Visibility = Visibility.Visible;
            ok.Visibility = Visibility.Visible;

            p1.Visibility = Visibility.Collapsed;
            p2.Visibility = Visibility.Collapsed;
            p3.Visibility = Visibility.Collapsed;
            p4.Visibility = Visibility.Collapsed;
            p5.Visibility = Visibility.Collapsed;
            b1.Visibility = Visibility.Collapsed;
            b2.Visibility = Visibility.Collapsed;
            b3.Visibility = Visibility.Collapsed;
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
            if (count == 5)
                NavigationService.Navigate(new Uri("/lvlSet6/s6lvl13.xaml", UriKind.Relative));
            else
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }   

           
    }
}
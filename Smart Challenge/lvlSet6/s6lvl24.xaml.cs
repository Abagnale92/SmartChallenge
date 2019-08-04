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
    public partial class s6lvl24 : PhoneApplicationPage
    {
        int count = 0;
        public s6lvl24()
        {
            InitializeComponent();
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            go.Begin();
            go.AutoReverse = true;
            go.Completed += go_Completed;

            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Fai scomparire i razzi ";

            }
            else
            {
                Instr.Text = "Do disappear rockets";
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

        void go_Completed(object sender, EventArgs e)
        {
            go.Begin();
        }

        private void r1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            r1.Visibility = Visibility.Collapsed;

                if(count==3)
                    NavigationService.Navigate(new Uri("/lvlSet6/s6lvl25.xaml", UriKind.Relative));
        }

        private void r2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            r2.Visibility = Visibility.Collapsed;

            if (count == 3)
                NavigationService.Navigate(new Uri("/lvlSet6/s6lvl25.xaml", UriKind.Relative));
        }

        private void r3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            r3.Visibility = Visibility.Collapsed;

            if (count == 3)
                NavigationService.Navigate(new Uri("/lvlSet6/s6lvl25.xaml", UriKind.Relative));
        }

           
    }
}
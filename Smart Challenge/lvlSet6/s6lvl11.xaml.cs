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
using ShakeGestures;

namespace Smart_Challenge
{
    public partial class s6lvl11 : PhoneApplicationPage
    {
        public s6lvl11()
        {
            InitializeComponent();
            VarGlobal.check = 7;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            go.Begin();
            go.AutoReverse = true;
            go.Completed += go_Completed;

            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Premi il bottone";

            }
            else
            {
                Instr.Text = "Tap the button";
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

        private void b_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/lvlSet6/s6lvl12.xaml", UriKind.Relative));
        }

            

           
    }
}
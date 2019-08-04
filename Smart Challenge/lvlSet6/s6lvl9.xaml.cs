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
    public partial class s6lvl9 : PhoneApplicationPage
    {
        public s6lvl9()
        {
            InitializeComponent();
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            fiamma.Begin();
            fiamma.AutoReverse = true;
            fiamma.Completed += fiamma_Completed;

            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Spegni la candela";
            }
            else
            {
                Instr.Text = "Extinguish the candle";
            }
        }

        void fiamma_Completed(object sender, EventArgs e)
        {
            fiamma.Begin();
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

        private void f_Hold(object sender, System.Windows.Input.GestureEventArgs e)
        {
            f.Visibility = Visibility.Collapsed;
            NavigationService.Navigate(new Uri("/lvlSet6/s6lvl10.xaml", UriKind.Relative));
        }

            

           
    }
}
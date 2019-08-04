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
using System.Windows.Threading;

namespace Smart_Challenge
{
    public partial class s2lvl21 : PhoneApplicationPage
    {
        public s2lvl21()
        {
            InitializeComponent();
            VarGlobal.count = 0;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            
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

                NavigationService.Navigate(new Uri("/lvlMenu.xaml", UriKind.Relative));
            }
        } 

            private void grid1_Loaded(object sender, RoutedEventArgs e)
            {
                string checkLang = (string)VarGlobal.settings["lingua"];
                if (checkLang == "Italia")
                {
                    Instr.Text = "Tocca fino a che il ghiaccio non si rompe.";

                }
                else
                {
                    Instr.Text = "Touch until the ice breaks.";
                }
            }


            private void cubetto_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                if (VarGlobal.count < 6)
                    VarGlobal.count = VarGlobal.count + 1;

                if (VarGlobal.count == 6)
                {
                    cubetto.Visibility = Visibility.Collapsed;
                    cubettoUp.Visibility = Visibility;
                    cubettoDown.Visibility = Visibility;
                    pingu.Visibility = Visibility.Visible;
                    pingu.Margin = new Thickness(500, 50, 0, 0);

                    string checkLang = (string)VarGlobal.settings["lingua"];
                    if (checkLang == "Italia")
                    {
                        Instr.Text = "Tocca il pinguino!";

                    }
                    else
                    {
                        Instr.Text = "Touch the penguin!";
                    }
                }

            }

            private void pingu_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                NavigationService.Navigate(new Uri("/lvlSet2/s2lvl22.xaml", UriKind.Relative));
            }

    
           
    }
}
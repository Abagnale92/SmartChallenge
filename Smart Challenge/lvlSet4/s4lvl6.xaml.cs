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
    public partial class s4lvl6 : PhoneApplicationPage
    {   
        int count = 0;

        public s4lvl6()
        {
            InitializeComponent();
            
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Premi cinque volte sul pinguino arrabbiato";

            }
            else
            {
                Instr.Text = "Tap five times the angry penguin";
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

        
        private void p_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }
        private void star_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            VarGlobal.star = true;
            star.Visibility = Visibility.Collapsed;
        }

        private void p3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;

            if (count == 5)
            {
                p1.Source = null;
                p2.Source = null;
                p3.Source = null;

                NavigationService.Navigate(new Uri("/lvlSet4/s4lvl7.xaml", UriKind.Relative));
            }
            else
            {
                switch (count)
                {
                    case 1:
                        {
                            p1.Margin = new Thickness(500, 180, 0, 180);
                            p2.Margin = new Thickness(200, 100, 500, 200);
                            p3.Margin = new Thickness(100, 300, 500, 50);
                            break;
                        }
                    case 2:
                        {
                            p1.Margin = new Thickness(500, 180, 0, 180);
                            p2.Margin = new Thickness(100, 300, 500, 50);
                            p3.Margin = new Thickness(200, 100, 500, 200);
                            star.Visibility = Visibility.Visible;
                            break;
                        }
                    case 3:
                        {
                            p1.Margin = new Thickness(200, 100, 500, 200);
                            p2.Margin = new Thickness(100, 300, 500, 50);
                            p3.Margin = new Thickness(500, 180, 0, 180);
                            break;
                        }
                    case 4:
                        {
                            p1.Margin = new Thickness(100, 300, 500, 50);
                            p2.Margin = new Thickness(500, 180, 0, 180);
                            p3.Margin = new Thickness(200, 100, 500, 200);
                            break;
                        }
                }
            }
                
        }

            

           
    }
}
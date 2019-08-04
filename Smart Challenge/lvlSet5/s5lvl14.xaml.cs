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
    public partial class s5lvl14 : PhoneApplicationPage
    {
        public s5lvl14()
        {
            InitializeComponent();  
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
             nuvole.Begin();
             nuvole.AutoReverse = true;
             nuvole.Completed += nuvole_Completed;
            
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Dov'è il sole?";

            }
            else
            {
                Instr.Text = "Where is the sun?";
            }
            
        }

        void nuvole_Completed(object sender, EventArgs e)
        {
            nuvole.Begin();
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

        private void PhoneApplicationPage_OrientationChanged(object sender, OrientationChangedEventArgs e)
        {
            n1.Visibility = Visibility.Collapsed;
            n2.Visibility = Visibility.Collapsed;
            n3.Visibility = Visibility.Collapsed;
            n4.Visibility = Visibility.Collapsed;
            
            sole.Visibility = Visibility.Visible;
        }

        private void sole_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/lvlSet5/s5lvl15.xaml", UriKind.Relative));
        }

        

           
    }
}
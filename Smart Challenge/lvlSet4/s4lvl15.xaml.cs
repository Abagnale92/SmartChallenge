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
    public partial class s4lvl15 : PhoneApplicationPage
    {
        public s4lvl15()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Colora le stelle";

            }
            else
            {
                Instr.Text = "Paint the stars";
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

        private void star3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            star3.Source = new ImageSourceConverter().ConvertFromString("/Images/starFull.png") as ImageSource;
            star1.Visibility = Visibility.Visible;
        }

        private void star1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            star1.Source = new ImageSourceConverter().ConvertFromString("/Images/starFull.png") as ImageSource;
            star2.Visibility = Visibility.Visible;
        }

        private void star2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            star2.Source = new ImageSourceConverter().ConvertFromString("/Images/starFull.png") as ImageSource;
            star4.Visibility = Visibility.Visible;
        }


        private void star4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            star4.Source = new ImageSourceConverter().ConvertFromString("/Images/starFull.png") as ImageSource;

            NavigationService.Navigate(new Uri("/lvlSet4/s4lvl16.xaml", UriKind.Relative));

            star1.Source = null;
            star2.Source = null;
            star3.Source = null;
            star4.Source = null;
        }

            

           
    }
}
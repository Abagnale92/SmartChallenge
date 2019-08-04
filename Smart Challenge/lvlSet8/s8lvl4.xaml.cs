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
    public partial class s8lvl4 : PhoneApplicationPage
    {
        int count;
        public s8lvl4()
        {
            InitializeComponent();
            count = 0;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Premi da destra verso sinitra a cominciare dal bottone rosso in alto";

            }
            else
            {
                Instr.Text = "Tap from right to left box starting with the red button at the top";
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

                NavigationService.Navigate(new Uri("/UltimolvlMenu.xaml", UriKind.Relative));
            }
        }

        private void br1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            br1.Visibility = Visibility.Collapsed;
            br2.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl3/powButt.png") as ImageSource;
        }

        private void bv1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (br1.Visibility == Visibility.Collapsed)
            {
                bv1.Visibility = Visibility.Collapsed;
                bb2.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl3/trg.png") as ImageSource;
            }
            else
                NavigationService.Navigate(new Uri("/sbagliato", UriKind.Relative));
        }

        private void br2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (bv1.Visibility == Visibility.Collapsed)
            {
                br2.Visibility = Visibility.Collapsed;
                bb2.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl3/buttonb.png") as ImageSource;
                bb1.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl2/vioPoint.png") as ImageSource;
            }
            else
                NavigationService.Navigate(new Uri("/lvlSet8/s8lvl4.xaml", UriKind.Relative));
        }

        private void bb2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (br2.Visibility == Visibility.Collapsed)
            {
                bb2.Visibility = Visibility.Collapsed;
                bv2.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl1/point.png") as ImageSource;
                bb1.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl3/button2.png") as ImageSource;
            }
            else
                NavigationService.Navigate(new Uri("/lvlSet8/s8lvl4.xaml", UriKind.Relative));
        }

        private void bv2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));

        }

        private void bb1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (bb2.Visibility == Visibility.Collapsed)
            {
                bb1.Visibility = Visibility.Collapsed;
                bv2.Visibility = Visibility.Collapsed;
                string checkLang = (string)VarGlobal.settings["lingua"];
                if (checkLang == "Italia")
                {
                    Instr.Text = "Premi 5 volte il bottone grande";

                }
                else
                {
                    Instr.Text = "Tap 5 times the big button";
                }

            }
            else
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

        private void B_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            if(count == 5)
                NavigationService.Navigate(new Uri("/lvlSet8/s8lvl5.xaml", UriKind.Relative));
        }
      
    }
}
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
    public partial class s8lvl18 : PhoneApplicationPage
    {
        int count = 0;

        public s8lvl18()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Addormenta i granchi";

            }
            else
            {
                Instr.Text = "Asleep the crabs";
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

        private void granchio1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            granchio1.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl8/granchio2.png") as ImageSource;
            if (count == 7)
            {
                NavigationService.Navigate(new Uri("/lvlSet8/s8lvl19.xaml", UriKind.Relative));
            }
        }

        private void granchio2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            granchio2.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl8/granchio2.png") as ImageSource;
            if (count == 7)
            {
                NavigationService.Navigate(new Uri("/lvlSet8/s8lvl19.xaml", UriKind.Relative));
            }
        }

        private void granchio3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            granchio3.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl8/granchio2.png") as ImageSource;
            if (count == 7)
            {
                NavigationService.Navigate(new Uri("/lvlSet8/s8lvl19.xaml", UriKind.Relative));
            }
        }

        private void granchio4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            granchio4.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl8/granchio2.png") as ImageSource;
            if (count == 7)
            {
                NavigationService.Navigate(new Uri("/lvlSet8/s8lvl19.xaml", UriKind.Relative));
            }
        }

        private void granchio5_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            granchio5.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl8/granchio2.png") as ImageSource;
            if (count == 7)
            {
                NavigationService.Navigate(new Uri("/lvlSet8/s8lvl19.xaml", UriKind.Relative));
            }
        }

        private void granchio6_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            granchio6.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl8/granchio2.png") as ImageSource;
            if (count == 7)
            {
                NavigationService.Navigate(new Uri("/lvlSet8/s8lvl19.xaml", UriKind.Relative));
            }
        }

        private void granchio7_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            granchio7.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl8/granchio2.png") as ImageSource;
            if (count == 7)
            {
                NavigationService.Navigate(new Uri("/lvlSet8/s8lvl19.xaml", UriKind.Relative));
            }
        }

        private void granchioer2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

       
      
    }
}
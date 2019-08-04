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
    public partial class s1lvl5 : PhoneApplicationPage
    {
        public s1lvl5()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Seleziona il tuo sistema operativo ";

            }
            else
            {
                Instr.Text = "Select your operating system";
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

                NavigationService.Navigate(new Uri("/lvlMenu.xaml", UriKind.Relative));
            }
        } 

            private void wp7_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                apple.Source = null;
                android.Source = null;
                wp7.Source = null;
                NavigationService.Navigate(new Uri("/lvlSet1/s1lvl6.xaml", UriKind.Relative)); 
            }

            private void apple_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }

            private void android_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }

           

            

           
    }
}
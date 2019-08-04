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
    public partial class s3lvl23 : PhoneApplicationPage
    {
        public s3lvl23()
        {
            InitializeComponent();
            VarGlobal.flag1 = false;
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

        private void PhoneApplicationPage_Loaded_1(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Inserisci la password che ti è stata data prima";

            }
            else
            {
                Instr.Text = "Insert the password that we gave you before";
            }
        }

        
        private void numPad(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Image lol = (Image)sender;
            calc1.Text += lol.Name.Substring(1);
        }

        private void numPad0_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if(calc1.Text == "15338")
                NavigationService.Navigate(new Uri("/lvlSet3/s3lvl24.xaml", UriKind.Relative));
            else
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }
    }


}
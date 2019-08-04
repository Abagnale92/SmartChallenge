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
    public partial class s3lvl24 : PhoneApplicationPage
    {
        int i = 0;
        public s3lvl24()
        {
            InitializeComponent();
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Invia il messaggio giusto e verrai salvato!";

            }
            else
            {
                Instr.Text = "Send the right message and you're going to be saved!";
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

            private void letter_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                TextBlock asd = (TextBlock)sender;
                text.Text = text.Text + " "+ asd.Text;
                i++;
               

            }

            private void but_Click(object sender, RoutedEventArgs e)
            {
                 if(text.Text == " H E L P")
                     NavigationService.Navigate(new Uri("/lvlSet3/s3lvl25.xaml", UriKind.Relative));
                 else
                     NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            } 

            

           
    }
}
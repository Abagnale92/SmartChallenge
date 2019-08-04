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

namespace Smart_Challenge.lvlSet1
{
    public partial class s2lvl18 : PhoneApplicationPage
    {


        int i = 0;
        public s2lvl18()
        {
            InitializeComponent();
        }

   

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];

            if (checkLang == "Italia")

                Instr.Text = "Tocca i punti blu.";


            else

                Instr.Text = "Touch the blue points.";

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


        private void point_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            string c = (((Image)sender).Name).Substring(0, 3);
            if (c == "blu")
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            else
            {
                i++;
            }

            if(i==3)
                NavigationService.Navigate(new Uri("/lvlSet2/s2lvl19.xaml", UriKind.Relative));

        }

 

     
    }
}
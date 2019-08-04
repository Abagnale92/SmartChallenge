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
    public partial class s9lvl20 : PhoneApplicationPage
    {
        public s9lvl20()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Complimenti sei diventato un EROE! \n Grazie per aver giocato a Smart Challenge! \n Spero che ti sia piaciuto!";

            }
            else
            {
                Instr.Text = "Congratulations you have become a HERO! \n Thank you for playing at Smart Challenge! \n I hope you enjoyed it!";
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

        private void ok_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            VarGlobal.stopWatch.Stop();
            VarGlobal.check = 0; 
            NavigationService.Navigate(new Uri("/end.xaml", UriKind.Relative));
        }
      
    }
}
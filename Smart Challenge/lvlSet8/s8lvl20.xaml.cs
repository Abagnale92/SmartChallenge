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
    public partial class s8lvl20 : PhoneApplicationPage
    {
        public s8lvl20()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            rondine.Begin();
            granchio1.Begin();
            rondine.Completed += rondine_Completed;
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Prendi la rondine";

            }
            else
            {
                Instr.Text = "Tap the swallow";
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
                rondine.Stop();
                while (NavigationService.CanGoBack)
                {
                    NavigationService.RemoveBackEntry();
                }

                NavigationService.Navigate(new Uri("/UltimolvlMenu.xaml", UriKind.Relative));
            }
        }

        private void uccello_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            rondine.Stop();
            VarGlobal.stopWatch.Stop();
            VarGlobal.check = 0;

            if ((int)VarGlobal.flaglvl2["value"] < 8)
                VarGlobal.flaglvl2["value"] = 8;
            NavigationService.Navigate(new Uri("/end.xaml", UriKind.Relative));
        }

        void rondine_Completed(object sender, EventArgs e)
        {
            rondine.Stop();
            NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }
    }
}
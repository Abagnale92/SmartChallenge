using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Smart_Challenge.lvlSet1
{
    public partial class s1lvl20 : PhoneApplicationPage
    {
        public s1lvl20()
        {
            InitializeComponent();
            VarGlobal.check = 2;
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                txtCheckpoint.Text = "Secondo Checkpoint! Dacci dentro! \n Clicca per andare avanti. ";

            }
            else
            {
                txtCheckpoint.Text = "Second Checkpoint! Go For it! Click to go forward.";

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

        private void button_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            NavigationService.Navigate(new Uri("/lvlSet1/s1lvl21.xaml", UriKind.Relative));
        }
    }
}
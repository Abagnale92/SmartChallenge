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
    public partial class s3lvl25 : PhoneApplicationPage
    {
        public s3lvl25()
        {
            InitializeComponent();
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Congratulazioni, il tuo messaggio è arrivato \n a destinazione! Sei salvo! \n Hai completato i primi \n tre livelli di Smart Challenge.";
                end.Text = "Fine!";
            }
            else
            {
                Instr.Text = "Congratulations, your message reached \n its destination! You're safe \n You have completed the first \n three levels of Smart Challenge. ";
                end.Text = "The end!";
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

            private void end_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                VarGlobal.stopWatch.Stop();
                VarGlobal.check = 0;

                if ((int)VarGlobal.flaglvl2["value"] < 3)
                VarGlobal.flaglvl2["value"] = 3;
               NavigationService.Navigate(new Uri("/end.xaml", UriKind.Relative));
               
            }

           

            

           
    }
}
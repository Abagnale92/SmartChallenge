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
    public partial class s7lvl20 : PhoneApplicationPage
    {
        public s7lvl20()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Nel forziere c'è una bottiglia con all'interno un messaggio. Leggi il messaggio!";

            }
            else
            {
                Instr.Text = "In the chest there is a bottle with a message inside. Read the message!";
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

        private void vb_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            cassa.Visibility = Visibility.Collapsed;
            b.Visibility = Visibility.Collapsed;
            Instr.Visibility = Visibility.Collapsed;
            mex.Visibility = Visibility.Visible;
            ok.Visibility = Visibility.Visible;

            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                mex.Text = "Mi dispiace ma nella mia vita non sono riuscito a rubare qualche tesoro. Forse dovevo fare un altro mestiere, tipo il falegname come mio padre ...";

            }
            else
            {
                mex.Text = "I'm sorry but in my life I could not stealing some treasure. Maybe I should do another job, type the carpenter like my father ...";
            }
        }

        private void ok_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            VarGlobal.stopWatch.Stop();
            VarGlobal.check = 0;

            if ((int)VarGlobal.flaglvl2["value"] < 7)
            VarGlobal.flaglvl2["value"] = 7;
            NavigationService.Navigate(new Uri("/end.xaml", UriKind.Relative));
        }
      
    }
}
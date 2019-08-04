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
    public partial class s5lvl25 : PhoneApplicationPage
    {
        public s5lvl25()
        {
            InitializeComponent();
            VarGlobal.flag1 = false;
            VarGlobal.flag2 = false;
            VarGlobal.flag3 = false;
            VarGlobal.flag4 = false;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Un contadino deve trasportare \n da una riva all'altra di un fiume \n una pecora, un lupo e un cavolo, ma dispone di un' unica barca con due soli posti. \n Se il lupo venisse lasciato solo con la pecora la divorerebbe, \n e lo stesso farebbe la pecora col cavolo se fosse lasciata sola con tale ortaggio.\n Come può fare il contadino a portare tutti \n dall'altra parte?";

            }
            else
            {
                Instr.Text = "A farmer has to carry \n from shore to shore of a river \n a sheep, a wolf and a cabbage, but has a only boat with only two seats. \n If the wolf were to be left alone with the sheep would eat, \n and the sheep would do the same with the cabbage if it was left alone with this vegetable. \n How can the farmer to bring all of \n the other side?";
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

                NavigationService.Navigate(new Uri("/NewlvlMenu.xaml", UriKind.Relative));
            }
        }

        private void p1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            VarGlobal.flag1 = true;
            p1.Visibility = Visibility.Collapsed;
            p2.Visibility = Visibility.Visible;
        }

        private void l1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag1 == true)
            {
                VarGlobal.flag2 = true;
                l1.Visibility = Visibility.Collapsed;
                l2.Visibility = Visibility.Visible;
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

        private void p2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag2 == true)
            {
                VarGlobal.flag3 = true;
                p2.Visibility = Visibility.Collapsed;
                p3.Visibility = Visibility.Visible;
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

        private void c1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag3 == true)
            {
                VarGlobal.flag4 = true;
                c1.Visibility = Visibility.Collapsed;
                c2.Visibility = Visibility.Visible;
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

        private void p3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (VarGlobal.flag4 == true)
            {
                
                p3.Visibility = Visibility.Collapsed;
                p4.Visibility = Visibility.Visible;

                VarGlobal.stopWatch.Stop();
                VarGlobal.check = 0;

                if ((int)VarGlobal.flaglvl2["value"] < 5)
                VarGlobal.flaglvl2["value"] = 5;
                
                NavigationService.Navigate(new Uri("/end.xaml", UriKind.Relative));

            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

        private void l2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

        private void c2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

        private void ok_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Instr.Visibility = Visibility.Collapsed;
            ok.Visibility = Visibility.Collapsed;

            p1.Visibility = Visibility.Visible;
            c1.Visibility = Visibility.Visible;
            l1.Visibility = Visibility.Visible;
            river.Visibility = Visibility.Visible;
        }

            

           
    }
}
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
    public partial class s1lvl1 : PhoneApplicationPage
    {
        public s1lvl1()
        {
            InitializeComponent();
            VarGlobal.flag1 = false;
            VarGlobal.flag2 = false;
            VarGlobal.flag3 = false;
            VarGlobal.check = 0;
            VarGlobal.livello = 1;
        }
   

      
        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
         
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Tocca il pallone da calcio";

            }
            else
            {
                Instr.Text = "Tap the soccer ball";
            }
            VarGlobal.stopWatch.Start();
        }

            private void Soccer_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                VarGlobal.flag1 = true;
                Soccer.Visibility = Visibility.Collapsed;
                string checkLang = (string)VarGlobal.settings["lingua"];
                if (checkLang == "Italia")
                {

                    Instr.Text = "Tocca il pallone da basket";

                }
                else
                {

                    Instr.Text = "Tap the basket ball";
                }
            }

            private void Basket_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                if (VarGlobal.flag1 == true)
                {
                    VarGlobal.flag2 = true;
                    Basket.Visibility = Visibility.Collapsed;
                    string checkLang = (string)VarGlobal.settings["lingua"];
                    if (checkLang == "Italia")
                    {

                        Instr.Text = "Ora tocca il pallone da rugby";

                    }
                    else
                    {

                        Instr.Text = "Now tap the rugby ball";
                    }
                }

                else
                {
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
                }
            }

            private void Rugby_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                if (VarGlobal.flag2 == true)
                {
                    VarGlobal.flag3 = true;
                    Soccer.Source = null;
                    Rugby.Source = null;
                    Basket.Source = null;       
                    NavigationService.Navigate(new Uri("/lvlSet1/s1lvl2.xaml", UriKind.Relative));
                }

                else
                {
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
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

            

           
    }
}
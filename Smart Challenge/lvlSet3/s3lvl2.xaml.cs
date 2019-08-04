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
    public partial class s3lvl2 : PhoneApplicationPage
    {
        public s3lvl2()
        {
            InitializeComponent();
            VarGlobal.count = 0;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Libera il pinguino";

            }
            else
            {
                Instr.Text = "Free the penguin";
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

            private void Cage_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                if (VarGlobal.count < 3)
                    VarGlobal.count = VarGlobal.count + 1;
                if (VarGlobal.count == 1)
                {
                    Cage.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl3/Cage1.png") as ImageSource;
                }

                if (VarGlobal.count == 2)
                {
                    Cage.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl3/Cage2.png") as ImageSource;
                }
                    if (VarGlobal.count == 3)
                        Cage.Visibility = Visibility.Collapsed;


            }

            private void ping_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                NavigationService.Navigate(new Uri("/lvlSet3/s3lvl3.xaml", UriKind.Relative));
            } 

            

           
    }
}
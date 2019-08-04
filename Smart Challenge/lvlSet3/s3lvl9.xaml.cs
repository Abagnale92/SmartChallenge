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
    public partial class s3lvl9 : PhoneApplicationPage
    {
        public s3lvl9()
        {
            InitializeComponent();
            VarGlobal.count = 0;
            VarGlobal.count1 = 0;
            VarGlobal.count2 = 0;
            VarGlobal.flag1 = false;
            VarGlobal.flag2 = false;
            VarGlobal.flag3 = false;

           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Libera i Pinguini da sinistra a destra!";

            }
            else
            {
                Instr.Text = "Free the Penguins from left to right";

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

            private void cage_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                VarGlobal.flag1 = true;
                if (VarGlobal.count < 3)
                    VarGlobal.count = VarGlobal.count + 1;
                if (VarGlobal.count == 1)
                {
                    cage.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl3/Cage1.png") as ImageSource;
                }

                if (VarGlobal.count == 2)
                {
                    cage.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl3/Cage2.png") as ImageSource;
                }
                if (VarGlobal.count == 3)
                    cage.Visibility = Visibility.Collapsed;
            }

            private void cage_Copy_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                if (VarGlobal.flag1 == true)
                {
                    VarGlobal.flag2 = true;
                    if (VarGlobal.count1 < 3)
                        VarGlobal.count1 = VarGlobal.count1 + 1;
                    if (VarGlobal.count1 == 1)
                    {
                        cage3.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl3/Cage1.png") as ImageSource;
                    }

                    if (VarGlobal.count1 == 2)
                    {
                        cage3.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl3/Cage2.png") as ImageSource;
                    }
                    if (VarGlobal.count1 == 3)
                        cage3.Visibility = Visibility.Collapsed;
                }
                else
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));

            }

            private void cage_Copy1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                if (VarGlobal.flag2 == true)
                {
                    VarGlobal.flag3 = true;
                    if (VarGlobal.count2 < 3)
                        VarGlobal.count2 = VarGlobal.count2 + 1;
                    if (VarGlobal.count2 == 1)
                    {
                        cage6.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl3/Cage1.png") as ImageSource;
                    }

                    if (VarGlobal.count2 == 2)
                    {
                        cage6.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl3/Cage2.png") as ImageSource;
                    }
                    if (VarGlobal.count2 == 3)
                    { cage6.Visibility = Visibility.Collapsed;

                    NavigationService.Navigate(new Uri("/lvlSet3/s3lvl10.xaml", UriKind.Relative));
                    }

                }

                else
                    NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
    }
           
    }
}
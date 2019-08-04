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
    public partial class s1lvl19 : PhoneApplicationPage
    {
        public s1lvl19()
        {
            InitializeComponent();
        }

        private void grid1_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = " Tocca la freccia rossa! ";

            }
            else
            {
                Instr.Text = "Tap the red arrow!";
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

        private void f_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Image lol = (Image)sender;
            string asd = lol.Name;
            string asd2 = asd.Substring(1);
            if (asd2 == "5")
            {
                f1.Source = null;
                f2.Source = null;
                f3.Source = null;
                f4.Source = null;
                f5.Source = null;
                f6.Source = null;
                f7.Source = null;
                f8.Source = null;
                f9.Source = null;
                f10.Source = null;
                NavigationService.Navigate(new Uri("/lvlSet1/s1lvl20.xaml", UriKind.Relative));
            }
            else
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }
    }
}
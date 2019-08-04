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

namespace Smart_Challenge
{
    public partial class s4lvl13 : PhoneApplicationPage
    {
        DispatcherTimer tmr = new DispatcherTimer();
        int i = 0;
        public s4lvl13()
        {
            InitializeComponent();
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Veloce! Schiaccia gli scarafaggi!";

            }
            else
            {
                Instr.Text = "Hurry up! Smash the beetles!";
            }
            tmr.Interval = TimeSpan.FromSeconds(4);
            tmr.Tick += new EventHandler(OnTimerTick);
            tmr.Start();
        }

        void OnTimerTick(object sender, EventArgs e)
        {
            tmr.Stop();
            NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
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
                tmr.Stop();
                while (NavigationService.CanGoBack)
                {
                    NavigationService.RemoveBackEntry();
                }

                NavigationService.Navigate(new Uri("/NewlvlMenu.xaml", UriKind.Relative));
            }
        }

        private void s1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            i++;
            s1.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl4/scarafaggiomorto.png") as ImageSource;
            if (i == 6)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet4/s4lvl14.xaml", UriKind.Relative));
                s1.Source = null;
                s2.Source = null;
                s3.Source = null;
                s4.Source = null;
                s5.Source = null;
                s6.Source = null;
            }
        }

        private void s2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            i++;
            s2.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl4/scarafaggiomorto.png") as ImageSource;
            if (i == 6)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet4/s4lvl14.xaml", UriKind.Relative));
                s1.Source = null;
                s2.Source = null;
                s3.Source = null;
                s4.Source = null;
                s5.Source = null;
                s6.Source = null;
            }
        }

        private void s3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            i++;
            s3.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl4/scarafaggiomorto.png") as ImageSource;
            if (i == 6)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet4/s4lvl14.xaml", UriKind.Relative));
                s1.Source = null;
                s2.Source = null;
                s3.Source = null;
                s4.Source = null;
                s5.Source = null;
                s6.Source = null;
            }
        }

        private void s4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            i++;
            s4.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl4/scarafaggiomorto.png") as ImageSource;
            if (i == 6)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet4/s4lvl14.xaml", UriKind.Relative));
                s1.Source = null;
                s2.Source = null;
                s3.Source = null;
                s4.Source = null;
                s5.Source = null;
                s6.Source = null;
            }
        }

        private void s5_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            i++;
            s5.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl4/scarafaggiomorto.png") as ImageSource;
            if (i == 6)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet4/s4lvl14.xaml", UriKind.Relative));
                s1.Source = null;
                s2.Source = null;
                s3.Source = null;
                s4.Source = null;
                s5.Source = null;
                s6.Source = null;
            }
        }

        private void s6_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            i++;
            s6.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl4/scarafaggiomorto.png") as ImageSource;
            if (i == 6)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet4/s4lvl14.xaml", UriKind.Relative));
                s1.Source = null;
                s2.Source = null;
                s3.Source = null;
                s4.Source = null;
                s5.Source = null;
                s6.Source = null;
            }
        }

           

           
    }
}
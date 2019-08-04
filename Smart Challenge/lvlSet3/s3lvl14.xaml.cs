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
    public partial class s3lvl14 : PhoneApplicationPage
    {
        DispatcherTimer tmr = new DispatcherTimer();
        public s3lvl14()
        {
            InitializeComponent();
            VarGlobal.count = 0;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            
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

                NavigationService.Navigate(new Uri("/lvlMenu.xaml", UriKind.Relative));
            }
        } 

            private void grid1_Loaded(object sender, RoutedEventArgs e)
            {
                string checkLang = (string)VarGlobal.settings["lingua"];
                if (checkLang == "Italia")
                {
                    Instr.Text = "Accendi il fuoco, ma non scottarti!";

                }
                else
                {
                    Instr.Text = "Light the Fire, but don't burn yourself!";
                }
            }


            private void sassi_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                if (VarGlobal.count < 5)
                    VarGlobal.count = VarGlobal.count + 1;

                if (VarGlobal.count == 5)
                {
                    fuoco.Visibility = Visibility;
                    tmr.Interval = TimeSpan.FromSeconds(2);
                    tmr.Tick += new EventHandler(OnTimerTick);
                    tmr.Start();
                }

            }

            void OnTimerTick(object sender, EventArgs e)
            {
                ((DispatcherTimer)sender).Stop();
                NavigationService.Navigate(new Uri("/lvlSet3/s3lvl15.xaml", UriKind.Relative));
            }

            private void fuoco_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }

          
        

           
    }
}
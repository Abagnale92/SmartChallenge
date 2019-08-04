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
    public partial class s3lvl16: PhoneApplicationPage
    {

        DispatcherTimer timer = new DispatcherTimer();
        public s3lvl16()
        {
            InitializeComponent();
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Fai mangiare il pinguino, ha fame!";

            }
            else
            {
                Instr.Text = "Get the penguin to eat, he's starving!";
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
                timer.Stop();
                while (NavigationService.CanGoBack)
                {
                    NavigationService.RemoveBackEntry();
                }

                NavigationService.Navigate(new Uri("/lvlMenu.xaml", UriKind.Relative));
            }
        } 

            private void PhoneApplicationPage_OrientationChanged(object sender, OrientationChangedEventArgs e)
            {
          
                    peng.Visibility = Visibility.Collapsed;
                    peng2.Visibility = Visibility.Visible;
                    timer.Interval = TimeSpan.FromSeconds(2);
                    timer.Tick += new EventHandler(OnTimerTick2);
                    timer.Start();
                    
            }

            void OnTimerTick2(object sender, EventArgs e)
            {
                timer.Stop();
                NavigationService.Navigate(new Uri("/lvlSet3/s3lvl17.xaml", UriKind.Relative));
            }
            

           
    }
}
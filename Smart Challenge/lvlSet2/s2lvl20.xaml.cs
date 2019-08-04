using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Threading;

namespace Smart_Challenge
{
    public partial class s2lvl20 : PhoneApplicationPage
    {     
       
        
            DispatcherTimer tmr = new DispatcherTimer();
    
        public s2lvl20()
        {InitializeComponent();
            // Richiama la funzione : cosa succede appena finisce il tempo?
            
            tmr.Interval = TimeSpan.FromSeconds(1);
            tmr.Tick += new EventHandler(OnTimerTick); 
        }
        
        void OnTimerTick(object sender, EventArgs e)
        {
            tmr.Stop();
            double lol = cube.Margin.Left;
            double lol2 = cube.Margin.Top;
            cube.Height -= 50;
            cube.Width -= 50;
            cube.Margin = new Thickness(lol + 20, lol - 50, 0, 0);

            pozza.Height += 50;
            pozza.Width += 50;
            
            if(cube.Height <= 0 )
                 NavigationService.Navigate(new Uri("/lvlSet2/s2lvl21.xaml", UriKind.Relative));
            else
                tmr.Start();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Sciogli il ghiaccio usando gli oggetti che hai intorno.";

            }
            else
            {
                Instr.Text = "Melt the ice using the things around.";
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
                tmr.Stop();
                while (NavigationService.CanGoBack)
                {
                    NavigationService.RemoveBackEntry();
                }

                NavigationService.Navigate(new Uri("/lvlMenu.xaml", UriKind.Relative));
            }
        } 

            private void sun_MouseLeave(object sender, MouseEventArgs e)
            {
                Point punto = e.GetPosition(sun);
                Point punto1 = new Point(458, 22);
                double X1;
                //   double X1 = Math.Abs(punto.X - punto1.X);
                if(punto.X < 0)
                     X1 = Math.Abs(punto.X + punto1.X);
                else
                     X1 = Math.Abs(punto.X - punto1.X);

                 if (X1 < 200)
                {
                    tmr.Start();

                }   
                
            }


            private void star_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                VarGlobal.star = true;
                sun.Source = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                star.Visibility = Visibility.Collapsed;
            }

          

           

     

            

           
    }
}
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
    public partial class s2lvl4 : PhoneApplicationPage
    {

        DispatcherTimer tmr = new DispatcherTimer();
        public s2lvl4()
        {
            InitializeComponent();
            tmr.Interval = TimeSpan.FromSeconds(2);
            tmr.Tick += new EventHandler(OnTimerTick);
            tmr.Start();
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Osserva attentamente.";

            }
            else
            {
                Instr.Text = "Observe carefully.";
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
            void OnTimerTick(object sender, EventArgs e)
            {
                tmr.Stop();
                puzzle.Source = null;
                piece.Source = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                NavigationService.Navigate(new Uri("/lvlSet2/s2lvl5.xaml", UriKind.Relative));
            }

            

           
    }
}
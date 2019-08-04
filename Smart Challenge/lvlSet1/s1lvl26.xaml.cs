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


namespace Smart_Challenge.lvlSet1
{
    public partial class s1lvl26 : PhoneApplicationPage
    {
        DispatcherTimer tmr = new DispatcherTimer();
        public s1lvl26()
        {
            InitializeComponent();
        }

        private void grid1_Loaded(object sender, RoutedEventArgs e)
        {       // Testo-Lingua
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Tieni a mente questo numero!";

            }
            else
            {
                Instr.Text = "Remember this number!";
            }
            // Per il timer
            tmr.Interval = TimeSpan.FromSeconds(3);
            tmr.Tick += new EventHandler(OnTimerTick); // Richiama la funzione : cosa succede appena finisce il tempo?
            tmr.Start();
        }
          
        void OnTimerTick(object sender, EventArgs e)
            {
            ((DispatcherTimer) sender).Stop();
               
                NavigationService.Navigate(new Uri("/lvlSet1/s1lvl27.xaml", UriKind.Relative));
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
    }
}
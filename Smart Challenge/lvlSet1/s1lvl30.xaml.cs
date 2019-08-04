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
    public partial class s1lvl30 : PhoneApplicationPage
    {

        DispatcherTimer timer = new DispatcherTimer();
        public s1lvl30()
        {
            InitializeComponent();
        }

        private void grid1_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];

            if (checkLang == "Italia")

                Instr.Text = "Ora seleziona il numero che hai imparato 5 livelli fa.";


            else

                Instr.Text = "Now select the number you have learned 5 levels ago.";

            timer.Interval = TimeSpan.FromSeconds(10);
            timer.Tick += new EventHandler(OnTimerTick1); // Richiama la funzione : cosa succede appena finisce il tempo?
            timer.Start();
        }

        void OnTimerTick1(object sender, EventArgs e)
        {
            timer.Stop();

            NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

        private void btn_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Button rispScelta = (Button)sender;
            string c = rispScelta.Content.ToString();
            if (c == "7483")
            {
                timer.Stop();

                if(!VarGlobal.flaglvl2.Contains("value"))
                 VarGlobal.flaglvl2["value"] = 1;
                VarGlobal.stopWatch.Stop();
                NavigationService.Navigate(new Uri("/end.xaml", UriKind.Relative));
                VarGlobal.check = 0;
            }
            else
            {
                timer.Stop();
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
                timer.Stop();
                while (NavigationService.CanGoBack)
                {
                    NavigationService.RemoveBackEntry();
                }

                NavigationService.Navigate(new Uri("/lvlMenu.xaml", UriKind.Relative));
            }
        } 
    }
}
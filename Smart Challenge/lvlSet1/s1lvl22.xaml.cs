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
    public partial class s1lvl22 : PhoneApplicationPage
    {

        DispatcherTimer tmr = new DispatcherTimer();
        public s1lvl22()
        {
            InitializeComponent();

        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];

            operation.Text = " 5 + 2 * 8 - 3 = ???";

            if (checkLang == "Italia")

                Instr.Text = "Dai il risultato corretto.";


            else

                Instr.Text = "Give the correct result.";

            tmr.Interval = TimeSpan.FromSeconds(10);
            tmr.Tick += new EventHandler(OnTimerTick);
            tmr.Start();


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
           NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));

        }
        private void correct_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Button rispScelta = (Button)sender;
            string c = rispScelta.Name.ToString();
            if (c == "correct")
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/lvlSet1/s1lvl23.xaml", UriKind.Relative)); }
            else
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative)); }
        }
    }
}
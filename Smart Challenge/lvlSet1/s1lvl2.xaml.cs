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
    public partial class s1lvl2 : PhoneApplicationPage
    {

        DispatcherTimer tmr = new DispatcherTimer();
        public s1lvl2()
        {
            InitializeComponent();
            VarGlobal.count = 0;
        }

    

        private void PhoneApplicationPage_Loaded_1(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Premi il pulsante 10 volte";

            }
            else
            {
                Instr.Text = "Press the button 10 times";
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
            if (VarGlobal.count == 10)
            {
                NavigationService.Navigate(new Uri("/lvlSet1/s1lvl3.xaml", UriKind.Relative));
            }
        }

        private void button_MouseEnter(object sender, MouseEventArgs e)
        {
            if (VarGlobal.count < 9 || VarGlobal.count != 10 || VarGlobal.count != 11)
            {
                VarGlobal.count = VarGlobal.count + 1;
                if (VarGlobal.count != 10)
                    tb.Text = VarGlobal.count.ToString();
                else
                    tb.Text = 9.ToString();
            }

            if (VarGlobal.count == 10)
            {
                tmr.Interval = TimeSpan.FromSeconds(2);
                tmr.Tick += new EventHandler(OnTimerTick);
                tmr.Start();
            }

            if (VarGlobal.count == 11)
            {
                tmr.Stop();
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }



    }


}
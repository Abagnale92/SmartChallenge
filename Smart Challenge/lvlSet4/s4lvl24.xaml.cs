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
    public partial class s4lvl24 : PhoneApplicationPage
    {
        DispatcherTimer timer = new DispatcherTimer();
        public s4lvl24()
        {
            InitializeComponent();
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Fai cadere gli oggetti che sono sul tavolo";

            }
            else
            {
                Instr.Text = "Drop the items that are on the table";
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

                NavigationService.Navigate(new Uri("/NewlvlMenu.xaml", UriKind.Relative));
            }
        }

        private void PhoneApplicationPage_OrientationChanged(object sender, OrientationChangedEventArgs e)
        {
            s1.Visibility = Visibility.Collapsed;
            s2.Visibility = Visibility.Collapsed;
            s3.Visibility = Visibility.Collapsed;
            s4.Visibility = Visibility.Collapsed;
            s5.Visibility = Visibility.Collapsed;
            t1.Visibility = Visibility.Visible;
            t2.Visibility = Visibility.Visible;
            t3.Visibility = Visibility.Visible;
            t4.Visibility = Visibility.Visible;
            t5.Visibility = Visibility.Visible;

            timer.Interval = TimeSpan.FromSeconds(2);
            timer.Tick += new EventHandler(OnTimerTick2);
            timer.Start();

        }

        void OnTimerTick2(object sender, EventArgs e)
        {
            timer.Stop();
            NavigationService.Navigate(new Uri("/lvlSet4/s4lvl25.xaml", UriKind.Relative));
        }
           
    }
}
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
using ShakeGestures;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Media;
using System.Windows.Threading;

namespace Smart_Challenge
{
    public partial class s9lvl8 : PhoneApplicationPage
    {
        DispatcherTimer tmr = new DispatcherTimer();
        public s9lvl8()
        {
            InitializeComponent();
        
            // register shake event
            ShakeGesturesHelper.Instance.ShakeGesture += new
                EventHandler<ShakeGestureEventArgs>(Instance_ShakeGesture);

            // optional, set parameters
            ShakeGesturesHelper.Instance.MinimumRequiredMovesForShake = 4;

            // start shake detection
            ShakeGesturesHelper.Instance.Active = true;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Fai cadere le uova";

            }
            else
            {
                Instr.Text = "Drop the eggs";
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
                ShakeGesturesHelper.Instance.Active = false;
                while (NavigationService.CanGoBack)
                {
                    NavigationService.RemoveBackEntry();
                }

                NavigationService.Navigate(new Uri("/UltimolvlMenu.xaml", UriKind.Relative));
            }
        }

        private void Instance_ShakeGesture(object sender, ShakeGestureEventArgs e)
        {
            uovo1.Dispatcher.BeginInvoke(
                () =>
                {
                    go1.Begin();
                    go2.Begin();
                    go3.Begin();
                    go4.Begin();

                    ShakeGesturesHelper.Instance.Active = false;
                    tmr.Interval = TimeSpan.FromSeconds(3);
                    tmr.Tick += new EventHandler(OnTimerTick);
                    tmr.Start();

                });

            ShakeGesturesHelper.Instance.Active = false;
        }

        void OnTimerTick(object sender, EventArgs e)
        {
            tmr.Stop();
            ShakeGesturesHelper.Instance.Active = false;
            NavigationService.Navigate(new Uri("/lvlSet9/s9lvl9.xaml", UriKind.Relative));    
        }
      
    }
}
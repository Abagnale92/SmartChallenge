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

namespace Smart_Challenge
{
    public partial class s9lvl13 : PhoneApplicationPage
    {
        public s9lvl13()
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
                Instr.Text = "Fai rimbalzare il pallone da calcio";

            }
            else
            {
                Instr.Text = "Bounce the soccer ball";
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
            p2.Dispatcher.BeginInvoke(
                () =>
                {
                    go.Begin();

                    ShakeGesturesHelper.Instance.Active = false;
                    go.Completed += go_Completed;
                });

        }

        void go_Completed(object sender, EventArgs e)
        {
            ShakeGesturesHelper.Instance.Active = false;
            NavigationService.Navigate(new Uri("/lvlSet9/s9lvl14.xaml", UriKind.Relative));
        }

      
    }
}
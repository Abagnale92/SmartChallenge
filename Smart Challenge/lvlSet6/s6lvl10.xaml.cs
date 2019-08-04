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
    public partial class s6lvl10 : PhoneApplicationPage
    {
        public s6lvl10()
        {
            InitializeComponent();
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
                Instr.Text = "Scrolla la neve dagli abeti";

            }
            else
            {
                Instr.Text = "Shaking the snow from the fir";
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
                while (NavigationService.CanGoBack)
                {
                    NavigationService.RemoveBackEntry();
                }

                NavigationService.Navigate(new Uri("/NewlvlMenu.xaml", UriKind.Relative));
            }
        }

        private void Instance_ShakeGesture(object sender, ShakeGestureEventArgs e)
        {
            n1.Dispatcher.BeginInvoke(
                () =>
                {
                    cade.Begin();
                    cade.Completed += cade_Completed;
                    
                });
            
            ShakeGesturesHelper.Instance.Active = false;
        }
        void cade_Completed(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/lvlSet6/s6lvl11.xaml", UriKind.Relative));
        }

           
    }
}
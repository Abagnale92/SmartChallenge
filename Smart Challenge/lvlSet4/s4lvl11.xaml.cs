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

namespace Smart_Challenge
{
    public partial class s4lvl11 : PhoneApplicationPage
    {
       
        public s4lvl11()
        {
            InitializeComponent();
            VarGlobal.check = 5;
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
                Instr.Text = "Rovescia il bicchiere d'aqua per continuare";

            }
            else
            {
                Instr.Text = "Overthrow the glass of water to continue";
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
            waterUp.Dispatcher.BeginInvoke(
                () =>
                {
                    waterUp.Visibility = Visibility.Collapsed;
                    waterDown.Visibility = Visibility.Visible;
                    NavigationService.Navigate(new Uri("/lvlSet4/s4lvl12.xaml", UriKind.Relative));
                });

            ShakeGesturesHelper.Instance.Active = false;
        }
           
    }
}
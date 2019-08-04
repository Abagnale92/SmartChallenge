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
    public partial class s8lvl12 : PhoneApplicationPage
    {
        DispatcherTimer timer = new DispatcherTimer();

        Boolean flagin1 = false;
        Boolean flagin2 = false;
        Boolean flagin3 = false;
        int i = 0;
        public s8lvl12()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Memorizza le carte!";

            }
            else
            {
                Instr.Text = "Memorize this cards!";
            }
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler(OnTimerTick2);
            timer.Start();

        }

        void OnTimerTick2(object sender, EventArgs e)
        {
            timer.Stop();
            Famiglia.Visibility = Visibility.Collapsed;
            Famiglia_Copy.Visibility = Visibility.Collapsed;
            Dino.Visibility = Visibility.Collapsed;
            Dino_Copy.Visibility = Visibility.Collapsed;
            Fred.Visibility = Visibility.Collapsed;
            Fred_Copy.Visibility = Visibility.Collapsed;
            Coperta.Visibility = Visibility.Visible;
            Coperta_Copy.Visibility = Visibility.Visible;
            Coperta_Copy1.Visibility = Visibility.Visible;
            Coperta_Copy2.Visibility = Visibility.Visible;
            Coperta_Copy3.Visibility = Visibility.Visible;
            Coperta_Copy4.Visibility = Visibility.Visible;

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

                NavigationService.Navigate(new Uri("/UltimolvlMenu.xaml", UriKind.Relative));
            }
        }

        private void Coperta_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Coperta.Visibility = Visibility.Collapsed;
            Fred.Visibility = Visibility.Visible;
            if (flagin1 == true)
            {
                i++;

                Fred_Copy.Visibility = Visibility.Collapsed;

                Fred.Visibility = Visibility.Collapsed;
                flagin1 = false;
            }
            else
                flagin1 = true;

            if (flagin2 == true || flagin3 == true)
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));

            if (i == 3)
            {
                Fred.Source = null;
                Fred_Copy.Source = null;
                Famiglia.Source = null;
                Famiglia_Copy.Source = null;
                Dino.Source = null;
                Dino_Copy.Source = null;
                Coperta.Source = null;
                Coperta_Copy.Source = null;
                Coperta_Copy1.Source = null;
                Coperta_Copy2.Source = null;
                Coperta_Copy3.Source = null;
                Coperta_Copy4.Source = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();

                NavigationService.Navigate(new Uri("/lvlSet8/s8lvl13.xaml", UriKind.Relative));
            }
        }

        private void Coperta_Copy_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Coperta_Copy.Visibility = Visibility.Collapsed;
            Famiglia.Visibility = Visibility.Visible;
            if (flagin2 == true)
            {
                i++;

                Famiglia_Copy.Visibility = Visibility.Collapsed;

                Famiglia.Visibility = Visibility.Collapsed;
                flagin2 = false;
            }
            else
                flagin2 = true;

            if (flagin1 == true || flagin3 == true)
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));

            if (i == 3)
            {
                Fred.Source = null;
                Fred_Copy.Source = null;
                Famiglia.Source = null;
                Famiglia_Copy.Source = null;
                Dino.Source = null;
                Dino_Copy.Source = null;
                Coperta.Source = null;
                Coperta_Copy.Source = null;
                Coperta_Copy1.Source = null;
                Coperta_Copy2.Source = null;
                Coperta_Copy3.Source = null;
                Coperta_Copy4.Source = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();

                NavigationService.Navigate(new Uri("/lvlSet8/s8lvl13.xaml", UriKind.Relative));
            }
        }

        private void Coperta_Copy1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Coperta_Copy1.Visibility = Visibility.Collapsed;
            Dino.Visibility = Visibility.Visible;
            if (flagin3 == true)
            {
                i++;

                Dino_Copy.Visibility = Visibility.Collapsed;

                Dino.Visibility = Visibility.Collapsed;
                flagin3 = false;
            }
            else
                flagin3 = true;

            if (flagin1 == true || flagin2 == true)
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));

            if (i == 3)
            {
                Fred.Source = null;
                Fred_Copy.Source = null;
                Famiglia.Source = null;
                Famiglia_Copy.Source = null;
                Dino.Source = null;
                Dino_Copy.Source = null;
                Coperta.Source = null;
                Coperta_Copy.Source = null;
                Coperta_Copy1.Source = null;
                Coperta_Copy2.Source = null;
                Coperta_Copy3.Source = null;
                Coperta_Copy4.Source = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();

                NavigationService.Navigate(new Uri("/lvlSet8/s8lvl13.xaml", UriKind.Relative));
            }
        }

        private void Coperta1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Coperta_Copy3.Visibility = Visibility.Collapsed;
            Fred_Copy.Visibility = Visibility.Visible;
            if (flagin1 == true)
            {
                i++;
                Fred_Copy.Visibility = Visibility.Collapsed;

                Fred.Visibility = Visibility.Collapsed;
                flagin1 = false;
            }
            else
                flagin1 = true;

            if (flagin2 == true || flagin3 == true)
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));

            if (i == 3)
            {
                Fred.Source = null;
                Fred_Copy.Source = null;
                Famiglia.Source = null;
                Famiglia_Copy.Source = null;
                Dino.Source = null;
                Dino_Copy.Source = null;
                Coperta.Source = null;
                Coperta_Copy.Source = null;
                Coperta_Copy1.Source = null;
                Coperta_Copy2.Source = null;
                Coperta_Copy3.Source = null;
                Coperta_Copy4.Source = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();

                NavigationService.Navigate(new Uri("/lvlSet8/s8lvl13.xaml", UriKind.Relative));
            }
        }

        private void Coperta_Copy2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Coperta_Copy4.Visibility = Visibility.Collapsed;
            Famiglia_Copy.Visibility = Visibility.Visible;
            if (flagin2 == true)
            {
                i++;

                Famiglia_Copy.Visibility = Visibility.Collapsed;

                Famiglia.Visibility = Visibility.Collapsed;
                flagin2 = false;
            }
            else
                flagin2 = true;

            if (flagin1 == true || flagin3 == true)
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));

            if (i == 3)
            {
                Fred.Source = null;
                Fred_Copy.Source = null;
                Famiglia.Source = null;
                Famiglia_Copy.Source = null;
                Dino.Source = null;
                Dino_Copy.Source = null;
                Coperta.Source = null;
                Coperta_Copy.Source = null;
                Coperta_Copy1.Source = null;
                Coperta_Copy2.Source = null;
                Coperta_Copy3.Source = null;
                Coperta_Copy4.Source = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();

                NavigationService.Navigate(new Uri("/lvlSet8/s8lvl13.xaml", UriKind.Relative));
            }
        }

        private void Coperta_Copy3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Coperta_Copy2.Visibility = Visibility.Collapsed;
            Dino.Visibility = Visibility.Visible;
            if (flagin3 == true)
            {
                i++;

                Dino_Copy.Visibility = Visibility.Collapsed;

                Dino.Visibility = Visibility.Collapsed;
                flagin3 = false;
            }
            else
                flagin3 = true;

            if (flagin1 == true || flagin2 == true)
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));

            if (i == 3)
            {
                Fred.Source = null;
                Fred_Copy.Source = null;
                Famiglia.Source = null;
                Famiglia_Copy.Source = null;
                Dino.Source = null;
                Dino_Copy.Source = null;
                Coperta.Source = null;
                Coperta_Copy.Source = null;
                Coperta_Copy1.Source = null;
                Coperta_Copy2.Source = null;
                Coperta_Copy3.Source = null;
                Coperta_Copy4.Source = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                NavigationService.Navigate(new Uri("/lvlSet8/s8lvl13.xaml", UriKind.Relative));
            }
        }






    }
}
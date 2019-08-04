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

namespace Smart_Challenge.lvlSet2
{
    public partial class s2lvl5 : PhoneApplicationPage
    {
        DispatcherTimer timer = new DispatcherTimer();
        public s2lvl5()
        {
            InitializeComponent();
            string checkLang = (string)VarGlobal.settings["lingua"];

            if (checkLang == "Italia")
            {
                Instr.Text = "Cosa vedi in questa immagine?";

            }
            else
            {
                Instr.Text = "What do you see in this image?";

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

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
         

        }

        void OnTimerTick2(object sender, EventArgs e)
        {
            timer.Stop();
            PokemonIm.Source = null;
               
            NavigationService.Navigate(new Uri("/lvlSet2/s2lvl6.xaml", UriKind.Relative));
        }

        private void btn_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Button rispScelta = (Button)sender;
            string c = rispScelta.Content.ToString();
            if (c == "Pokemon")
            {
                PokemonIm.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl2/pokemon2.jpg") as ImageSource;
                timer.Interval = TimeSpan.FromSeconds(1);
                timer.Tick += new EventHandler(OnTimerTick2);
                timer.Start();
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }


    }





}
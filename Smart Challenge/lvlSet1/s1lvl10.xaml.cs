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
    public partial class s1lvl10 : PhoneApplicationPage
    {
        public s1lvl10()
        {
            InitializeComponent();
            VarGlobal.check = 1;
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                checkT.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl1/caniniT.png") as ImageSource;
                checkF.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl1/caniniF.png") as ImageSource;
                txtCheckpoint.Text = "Complimenti!\nHai raggiunto il primo checkpoint, ma fa attenzione!\nD'ora in poi quando troverai una scritta in rosso,\ndovrai fare l'opposto!\n\nTocca i canini per continuare.";

            }
            else
            {
                txtCheckpoint.Text = "Congratulations!\nYou've reached the first checkpoint, but be careful!\nNow, when you find a red word,\nyou'll have to do the opposite!\n\nTouch the eight to continue.";
                checkT.Visibility = Visibility.Collapsed;
                txtCheckT.Visibility = Visibility;
                checkF.Width = 37;
                checkF.Height = 160;
                checkF.Source = new ImageSourceConverter().ConvertFromString("/Images/imgLvl1/eightF.png") as ImageSource;
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

                NavigationService.Navigate(new Uri("/lvlMenu.xaml", UriKind.Relative));
            }
        } 

        private void checkT_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            NavigationService.Navigate(new Uri("/lvlSet1/s1lvl11.xaml", UriKind.Relative));
            
            
        }

        private void checkF_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }


    }
}
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
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Media;


namespace Smart_Challenge
{
    public partial class MainPage : PhoneApplicationPage
    {

        int count = 0;
        public MainPage()
        {

            Song song = Song.FromUri("name", new Uri("Audio/Theme.mp3", UriKind.Relative));
            InitializeComponent();
            FrameworkDispatcher.Update();
            MediaPlayer.IsRepeating = true;
            MediaPlayer.Play(song);
        }
        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            while (NavigationService.CanGoBack)
            {
                NavigationService.RemoveBackEntry();
            }
           
        }
        public static string linguaTelefono()
        {
            return System.Globalization.RegionInfo.CurrentRegion.DisplayName;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            if(VarGlobal.settings.Contains("audio"))
            {
                bool checkAudio = (bool)VarGlobal.settings["audio"];
                if (checkAudio == false)
                MediaPlayer.Pause();
            }
            else
                VarGlobal.settings.Add("audio", true);
            
            string checkLang;

            if (VarGlobal.settings.Contains("lingua"))
            {
                checkLang = (string)VarGlobal.settings["lingua"];
            }
            else
            {
                checkLang = linguaTelefono();
                VarGlobal.settings.Add("lingua", checkLang);
            }
  
                if (checkLang == "Italia")
                {
                    TxtStart.Text = "  Premi\n per continuare";
                    Warn.Text = "Hey! Start è qui!"; 
                    VarGlobal.text1 = "Attenzione!";
                    VarGlobal.text2 = "Vuoi davvero terminare la partita?";
                    
                }
                else
                {
                    TxtStart.Text = "  Press\n to continue";
                    Warn.Text = "Hey! Start is here!";
                    VarGlobal.text1 = "Attention!";
                    VarGlobal.text2 = "Do you really want to end the game?";
                 
                }
             
        }

      

        private void txtLink_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/lvlMenu.xaml", UriKind.Relative));
        }

        private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count++;
            if (count == 2)
            {
                Warn.Visibility = Visibility.Visible;
                arr.Visibility = Visibility.Visible;
            }
        } 
    }
}
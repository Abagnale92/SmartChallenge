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
    public partial class setMenu : PhoneApplicationPage
    {
        public setMenu()
        {
            InitializeComponent();
            this.selezioneLingua.ItemsSource = GetItems();

            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
                this.selezioneLingua.SelectedIndex = 1;
            else
                this.selezioneLingua.SelectedIndex = 0; 

            bool checkAudio = (bool)VarGlobal.settings["audio"];
            if (checkAudio == true)
            {
                audioOnOff.IsChecked = true;
            }
            else
            {
                audioOnOff.IsChecked = false;
            }


        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                TxtSettings.Text = "Impostazioni";
                lang.Text = "Lingua";
            }
            else
            {
                TxtSettings.Text = "Settings";
                lang.Text = "Language";
            }
        }

        private IList<string> GetItems()
        {
            List<string> items = new List<string>();
            items.Add("English");
            items.Add("Italiano");

            return items;

        }

        private void audioOnOff_Unchecked(object sender, RoutedEventArgs e)
        {
            VarGlobal.settings["audio"] = false;
            MediaPlayer.Pause();
        }

        private void audioOnOff_Checked(object sender, RoutedEventArgs e)
        {
            VarGlobal.settings["audio"] = true;
            FrameworkDispatcher.Update();
            MediaPlayer.Resume();
        }

        private void selezioneLingua_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (selezioneLingua.SelectedIndex == 1)
            {
                VarGlobal.settings["lingua"] = "Italia";
                TxtSettings.Text = "Impostazioni";
                lang.Text = "Lingua";
                VarGlobal.text1 = "Attenzione!";
                VarGlobal.text2 = "Vuoi davvero terminare la partita?";
            }
            if (selezioneLingua.SelectedIndex == 0)
            {
                VarGlobal.settings["lingua"] = "English";
                TxtSettings.Text = "Settings";
                lang.Text = "Language";
                VarGlobal.text1 = "Attention!";
                VarGlobal.text2 = "Do you really want to end the game?";
            }
        }

        private void reset_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            VarGlobal.stelle.Remove("stelle1");
            VarGlobal.stelle.Remove("stelle2");
            VarGlobal.stelle.Remove("stelle3");
            VarGlobal.stelle.Remove("stelle4");
            VarGlobal.stelle.Remove("stelle5");
            VarGlobal.stelle.Remove("stelle6");
        }

    }
}
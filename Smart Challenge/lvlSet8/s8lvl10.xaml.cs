﻿using System;
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
    public partial class s8lvl10 : PhoneApplicationPage
    {
        int v = 0;
        DispatcherTimer tmr = new DispatcherTimer();
        public s8lvl10()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Indovina";

            }
            else
            {
                Instr.Text = "Guess";
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
                while (NavigationService.CanGoBack)
                {
                    NavigationService.RemoveBackEntry();
                }

                NavigationService.Navigate(new Uri("/NewlvlMenu.xaml", UriKind.Relative));
            }
        }

        private void letter_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            TextBlock asd = (TextBlock)sender;
            text.Text = text.Text + " " + asd.Text;
            v++;
        }

        private void but_Click(object sender, RoutedEventArgs e)
        {
            if (text.Text == " K A T Y P E R R Y")
            {
                kety2.Visibility = Visibility.Visible;
                tmr.Interval = TimeSpan.FromSeconds(2);
                tmr.Tick += new EventHandler(OnTimerTick);
                tmr.Start();
            }
            else
            {
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
            }
        }

        void OnTimerTick(object sender, EventArgs e)
        {
            tmr.Stop();
            NavigationService.Navigate(new Uri("/lvlSet8/s8lvl11.xaml", UriKind.Relative));
        }
    }
}
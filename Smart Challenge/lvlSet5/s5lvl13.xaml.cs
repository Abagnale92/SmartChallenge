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

namespace Smart_Challenge
{
    public partial class s5lvl13 : PhoneApplicationPage
    {
        public s5lvl13()
        {
            InitializeComponent();
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Trova l'intruso";

            }
            else
            {
                Instr.Text = "Find the intruder";
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

        private void p_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Image lol = (Image)sender;
            string asd = lol.Name;
            string asd2 = asd.Substring(1);
            if (asd2 == "2")
            {
                p1.Source = null;
                p2.Source = null;
                p3.Source = null;
                p4.Source = null;
                p5.Source = null;

                NavigationService.Navigate(new Uri("/lvlSet5/s5lvl14.xaml", UriKind.Relative));
            }
            else
                NavigationService.Navigate(new Uri("/sbagliato.xaml", UriKind.Relative));
        }

           
    }
}
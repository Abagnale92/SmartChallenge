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
using Microsoft.Phone.Tasks;

namespace Smart_Challenge
{
    public partial class Info : PhoneApplicationPage
    {
        public Info()
        {
            InitializeComponent();

        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

        }




        private void grid1_Loaded(object sender, RoutedEventArgs e)
        {
            string checkLang = (string)VarGlobal.settings["lingua"];

            if (checkLang == "Italia")
            {
                Instr.Text = "INFORMAZIONI";
                Inf.Text = "Chi siamo? Ares è un gruppo di studenti che hanno deciso di mettere in atto le proprie idee. Con piccoli passi cercheremo di migliorare e creare nuove applicazioni sempre più stimolanti e con il vostro sostegno e i vostri suggerimenti saremo in grado di crescere professionalmente e personalmente. ";
     

            }

            else
            {
                Instr.Text = "INFORMATION";
                Inf.Text = "Who are we? Ares is a group of students who decided to implement their own ideas. With small steps we will try to improve and create new applications more challenging and with your support and your suggestions we'll be able to grow professionally and personally. ";
                
            }
        }

        private void EMailLink_Click(object sender, RoutedEventArgs e)
        {
            EmailComposeTask emailComposeTask = new EmailComposeTask();
            emailComposeTask.Subject = "Hello!";
            emailComposeTask.Body = "message body";
            emailComposeTask.To = "aresdev@outlook.it";
            emailComposeTask.Show();
        }

        private void twitter_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            WebBrowserTask webBrowserTask = new WebBrowserTask();

            webBrowserTask.Uri = new Uri("https://twitter.com/aresdev", UriKind.Absolute);

            webBrowserTask.Show();
        }

        private void facebook_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            WebBrowserTask webBrowserTask = new WebBrowserTask();

            webBrowserTask.Uri = new Uri("https://www.facebook.com/pages/ARES/354148764721989", UriKind.Absolute);

            webBrowserTask.Show();
        }

        private void apps_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            WebBrowserTask webBrowserTask = new WebBrowserTask();

            webBrowserTask.Uri = new Uri("http://www.windowsphone.com/it-IT/store/publishers?publisherId=AresDevelop&appId", UriKind.Absolute);

            webBrowserTask.Show();
        }

    }
}
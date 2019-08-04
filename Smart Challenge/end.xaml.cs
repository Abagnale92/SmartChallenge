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
using System.Windows.Media.Imaging;

namespace Smart_Challenge
{
    public partial class end : PhoneApplicationPage
    {
        int i = 0;
        public end()
        {
            InitializeComponent();
            
           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string elapsedTime;
            VarGlobal.stopWatch.Stop();
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, 0);
            TimeSpan confronto1 = new TimeSpan(0, 0, 2, 30, 0);
            TimeSpan confronto2 = new TimeSpan(0, 0, 3, 0, 0);
            ts = VarGlobal.stopWatch.Elapsed;
            VarGlobal.stopWatch.Reset();
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            time.Text = elapsedTime;

            if (ts <= confronto1)
            {
               
                star1.Source = new ImageSourceConverter().ConvertFromString("/Images/starFull.png") as ImageSource;
                star2.Source = new ImageSourceConverter().ConvertFromString("/Images/starFull.png") as ImageSource;       
                
                i = 2;

                if (VarGlobal.star == true)
                {
                    star3.Source = new ImageSourceConverter().ConvertFromString("/Images/starFull.png") as ImageSource;  
                    i = 3;
                }

            }
            else
                if (ts <= confronto2)
                {
                    star1.Source = new ImageSourceConverter().ConvertFromString("/Images/starFull.png") as ImageSource;  
                    i=1;
                }


            string tempStar = "stelle" + VarGlobal.livello;

            if (!VarGlobal.stelle.Contains(tempStar))
                VarGlobal.stelle.Add(tempStar, i);
            else
                if ((int)VarGlobal.stelle[tempStar] < i)
                    VarGlobal.stelle[tempStar] = i;


         /*   switch (VarGlobal.livello)
            {
                case 1:
                    {
                        if (!VarGlobal.stelle.Contains("stelle1"))
                            VarGlobal.stelle.Add("stelle1", i);
                        else
                            if ((int)VarGlobal.stelle["stelle1"] < i)
                                VarGlobal.stelle["stelle1"] = i;

                        break;
                    }
                case 2:
                    {
                        if (!VarGlobal.stelle.Contains("stelle2"))
                            VarGlobal.stelle.Add("stelle2", i);
                        else
                            if ((int)VarGlobal.stelle["stelle2"] < i)
                                VarGlobal.stelle["stelle2"] = i;

                        break;
                    }
                case 3:
                    {
                        if (!VarGlobal.stelle.Contains("stelle3"))
                            VarGlobal.stelle.Add("stelle3", i);
                        else
                            if ((int)VarGlobal.stelle["stelle3"] < i)
                                VarGlobal.stelle["stelle3"] = i;

                        break;
                    }
            }*/

        }




        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {           
                while (NavigationService.CanGoBack)
                {
                    NavigationService.RemoveBackEntry();
                }

                switch (VarGlobal.livello)
                {
                    case 1: NavigationService.Navigate(new Uri("/lvlMenu.xaml", UriKind.Relative)); break;
                    case 2: NavigationService.Navigate(new Uri("/lvlMenu.xaml", UriKind.Relative)); break;
                    case 3: NavigationService.Navigate(new Uri("/lvlMenu.xaml", UriKind.Relative)); break;
                    case 4: NavigationService.Navigate(new Uri("/NewlvlMenu.xaml", UriKind.Relative)); break;
                    case 5: NavigationService.Navigate(new Uri("/NewlvlMenu.xaml", UriKind.Relative)); break;
                    case 6: NavigationService.Navigate(new Uri("/NewlvlMenu.xaml", UriKind.Relative)); break;
                    case 7: NavigationService.Navigate(new Uri("/UltimolvlMenu.xaml", UriKind.Relative)); break;
                    case 8: NavigationService.Navigate(new Uri("/UltimolvlMenu.xaml", UriKind.Relative)); break;
                    case 9: NavigationService.Navigate(new Uri("/UltimolvlMenu.xaml", UriKind.Relative)); break;
                }
            
        }

            private void OK_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                switch (VarGlobal.livello)
                {
                    case 1: NavigationService.Navigate(new Uri("/lvlMenu.xaml", UriKind.Relative)); break;
                    case 2: NavigationService.Navigate(new Uri("/lvlMenu.xaml", UriKind.Relative)); break;
                    case 3: NavigationService.Navigate(new Uri("/lvlMenu.xaml", UriKind.Relative)); break;
                    case 4: NavigationService.Navigate(new Uri("/NewlvlMenu.xaml", UriKind.Relative)); break;
                    case 5: NavigationService.Navigate(new Uri("/NewlvlMenu.xaml", UriKind.Relative)); break;
                    case 6: NavigationService.Navigate(new Uri("/NewlvlMenu.xaml", UriKind.Relative)); break;
                    case 7: NavigationService.Navigate(new Uri("/UltimolvlMenu.xaml", UriKind.Relative)); break;
                    case 8: NavigationService.Navigate(new Uri("/UltimolvlMenu.xaml", UriKind.Relative)); break;
                    case 9: NavigationService.Navigate(new Uri("/UltimolvlMenu.xaml", UriKind.Relative)); break;
                }
            } 

            

           
    }
}
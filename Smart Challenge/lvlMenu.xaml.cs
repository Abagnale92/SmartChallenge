using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.IO.IsolatedStorage;
using Microsoft.Phone.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Controls.Primitives;
using Microsoft.Phone.Controls;
using Tomers.Phone.Controls;
using System.Diagnostics;
using System.Threading;
using Microsoft.Advertising.Mobile.UI;



namespace Smart_Challenge
{
    public partial class lvlMenu : PhoneApplicationPage
    {
        public lvlMenu()
        {
            InitializeComponent();
           

            VarGlobal.count = 0;
            VarGlobal.stopWatch.Stop(); 
            if (!VarGlobal.stelle.Contains("stelle1"))
            {
                star1_1.Visibility = Visibility.Collapsed;
                star1_2.Visibility = Visibility.Collapsed;
                star1_3.Visibility = Visibility.Collapsed;
            }
            else
            {
                switch ((int)VarGlobal.stelle["stelle1"])
                {
                    case 1:
                        {
                            star1_1.Source = new ImageSourceConverter().ConvertFromString("/Images/starFull.png") as ImageSource;
                            star1_1.Visibility = Visibility.Visible;
                        } break;
                    case 2:
                        {
                            star1_1.Source = new ImageSourceConverter().ConvertFromString("/Images/starFull.png") as ImageSource;
                            star1_2.Source = new ImageSourceConverter().ConvertFromString("/Images/starFull.png") as ImageSource;
                            star1_1.Visibility = Visibility.Visible;
                            star1_2.Visibility = Visibility.Visible;
                        } break;
                    case 3:
                        {
                            star1_1.Source = new ImageSourceConverter().ConvertFromString("/Images/starFull.png") as ImageSource;
                            star1_2.Source = new ImageSourceConverter().ConvertFromString("/Images/starFull.png") as ImageSource;
                            star1_3.Source = new ImageSourceConverter().ConvertFromString("/Images/starFull.png") as ImageSource;
                            star1_1.Visibility = Visibility.Visible;
                            star1_2.Visibility = Visibility.Visible;
                            star1_3.Visibility = Visibility.Visible;
                        } break;
                }
            }
            if (!VarGlobal.stelle.Contains("stelle2"))
            {
                star2_1.Visibility = Visibility.Collapsed;
                star2_2.Visibility = Visibility.Collapsed;
                star2_3.Visibility = Visibility.Collapsed;
            }
            else
            {
                switch ((int)VarGlobal.stelle["stelle2"])
                {
                    case 1:
                        {
                            star2_1.Source = new ImageSourceConverter().ConvertFromString("/Images/starFull.png") as ImageSource;
                            star2_1.Visibility = Visibility.Visible;
                        } break;
                    case 2:
                        {
                            star2_1.Source = new ImageSourceConverter().ConvertFromString("/Images/starFull.png") as ImageSource;
                            star2_2.Source = new ImageSourceConverter().ConvertFromString("/Images/starFull.png") as ImageSource;
                            star2_1.Visibility = Visibility.Visible;
                            star2_2.Visibility = Visibility.Visible;
                        } break;
                    case 3:
                        {
                            star2_1.Source = new ImageSourceConverter().ConvertFromString("/Images/starFull.png") as ImageSource;
                            star2_2.Source = new ImageSourceConverter().ConvertFromString("/Images/starFull.png") as ImageSource;
                            star2_3.Source = new ImageSourceConverter().ConvertFromString("/Images/starFull.png") as ImageSource;
                            star2_1.Visibility = Visibility.Visible;
                            star2_2.Visibility = Visibility.Visible;
                            star2_3.Visibility = Visibility.Visible;
                        } break;
                }
            }
            if (!VarGlobal.stelle.Contains("stelle3"))
            {
                star3_1.Visibility = Visibility.Collapsed;
                star3_2.Visibility = Visibility.Collapsed;
                star3_3.Visibility = Visibility.Collapsed;
            }
            else
            {
                VarGlobal.livello = 3;

                switch ((int)VarGlobal.stelle["stelle3"])
                {
                    case 1:
                        {
                            star3_1.Source = new ImageSourceConverter().ConvertFromString("/Images/starFull.png") as ImageSource;
                            star3_1.Visibility = Visibility.Visible;
                        } break;
                    case 2:
                        {
                            star3_1.Source = new ImageSourceConverter().ConvertFromString("/Images/starFull.png") as ImageSource;
                            star3_2.Source = new ImageSourceConverter().ConvertFromString("/Images/starFull.png") as ImageSource;
                            star3_1.Visibility = Visibility.Visible;
                            star3_2.Visibility = Visibility.Visible;
                        } break;
                    case 3:
                        {
                            star3_1.Source = new ImageSourceConverter().ConvertFromString("/Images/starFull.png") as ImageSource;
                            star3_2.Source = new ImageSourceConverter().ConvertFromString("/Images/starFull.png") as ImageSource;
                            star3_3.Source = new ImageSourceConverter().ConvertFromString("/Images/starFull.png") as ImageSource;
                            star3_1.Visibility = Visibility.Visible;
                            star3_2.Visibility = Visibility.Visible;
                            star3_3.Visibility = Visibility.Visible;
                        } break;
                }
            }
            if (VarGlobal.flaglvl2.Contains("value"))
            {
                VarGlobal.valoreFlag2 = (int)VarGlobal.flaglvl2["value"];
                if (VarGlobal.valoreFlag2 == 1)
                {

                    lvl2.Source = new ImageSourceConverter().ConvertFromString("Images/lvl2.png") as ImageSource;
                    this.lvl2.Tap += lvl2_Tap;
                }
                else
                {
                    lvl2.Source = new ImageSourceConverter().ConvertFromString("Images/lvl2.png") as ImageSource;
                    lvl3.Source = new ImageSourceConverter().ConvertFromString("Images/lvl3.png") as ImageSource;
                    this.lvl2.Tap += lvl2_Tap;
                    this.lvl3.Tap += lvl3_Tap;
                    
                }
            }
          
           
        }
        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            while (NavigationService.CanGoBack)
            {
                NavigationService.RemoveBackEntry();
            }
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
        private static bool PerformedRatingPromptCheck = false;

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            if (!PerformedRatingPromptCheck)
            {
                PerformedRatingPromptCheck = true;

                int numAppLaunches = 0;
                IsolatedStorageSettings.ApplicationSettings.TryGetValue<int>("Rating_numAppLaunches", out numAppLaunches);

                int numNextRatingPrompt = 0;
                if (!IsolatedStorageSettings.ApplicationSettings.TryGetValue<int>("Rating_numNextRatingPrompt", out numNextRatingPrompt))
                {
                    numNextRatingPrompt = 3;
                }

                if (numAppLaunches >= numNextRatingPrompt)
                {
                    IsolatedStorageSettings.ApplicationSettings["Rating_numNextRatingPrompt"] = numNextRatingPrompt * 2;

                    if (MessageBox.Show("If you like it, would you rate this app?", "Thanks For Downloading", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                    {
                        var a = new MarketplaceReviewTask();
                        a.Show();
                    }
                }

                IsolatedStorageSettings.ApplicationSettings["Rating_numAppLaunches"] = numAppLaunches + 1;
            }

            VarGlobal.stopWatch.Reset();
            VarGlobal.check = 0;
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                TxtTitle.Text = "Scegli Il Livello";
              
            }
            else
            {
                TxtTitle.Text = "Choose The Level";
            
            }

           
        }

        private void lvl1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            VarGlobal.star = false;
            VarGlobal.livello = 1;
            NavigationService.Navigate(new Uri("/lvlSet1/s1lvl1.xaml", UriKind.Relative));
        }

        private void lvl2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            VarGlobal.star = false;
            VarGlobal.livello = 2;
           NavigationService.Navigate(new Uri("/lvlSet2/s2lvl1.xaml", UriKind.Relative));            
        }

        private void lvl3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            VarGlobal.star = false;
            VarGlobal.livello = 3;
            NavigationService.Navigate(new Uri("/lvlSet3/s3lvl1.xaml", UriKind.Relative));
        }

        private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/setMenu.xaml", UriKind.Relative));
        }

        private void b1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Istruzioni.xaml", UriKind.Relative));
        }

        private void b2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Info.xaml", UriKind.Relative));
        }

        private void b1_Copy1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Credits.xaml", UriKind.Relative));
        }

        private void avanti_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/NewlvlMenu.xaml", UriKind.Relative));
        }

    }
}
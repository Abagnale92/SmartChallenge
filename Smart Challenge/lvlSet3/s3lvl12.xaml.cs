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

namespace Smart_Challenge
{
    public partial class s3lvl12 : PhoneApplicationPage
    {
        public s3lvl12()
        {
            InitializeComponent();

           
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

            Instr.Text = "Checkpoint!";
            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instruction.Text = "Bene! Hai raggiunto il checkpoint! \n Ricorda, le scritte in verde ti daranno \n suggerimenti molto importanti! \n Forma le 6:15 per continuare.";
            }
            else
            {
                Instruction.Text = "Good! You reached the checkpoint! \n Now remember, the green writing is a very \n important hint! Now, make the 6:15 to continue.";
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

            private void PhoneApplicationPage_OrientationChanged(object sender, OrientationChangedEventArgs e)
            {

                VarGlobal.check = 4;
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                    NavigationService.Navigate(new Uri("/lvlSet3/s3lvl13.xaml", UriKind.Relative));
             
        
                    
            } 

            

           
    }
}
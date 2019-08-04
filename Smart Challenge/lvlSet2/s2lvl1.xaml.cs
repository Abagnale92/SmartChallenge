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
    public partial class s2lvl1 : PhoneApplicationPage
    {


        Point punto1 = new Point(458, 256);
        Point punto2 = new Point(613, 118);
        Point punto3 = new Point(566, 285);
        Point punto4 = new Point(698, 356);
        int i = 0;
        public s2lvl1()
        {
            InitializeComponent();
            VarGlobal.livello = 2;
            VarGlobal.check = 0;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

            string checkLang = (string)VarGlobal.settings["lingua"];
            if (checkLang == "Italia")
            {
                Instr.Text = "Trova le differenze!";

            }
            else
            {
                Instr.Text = "Find the differences!";
            }

            VarGlobal.stopWatch.Start();
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

            private void image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
            {
                //Ottengo il punto in cui viene effettuato il Tap, quindi lo metto in nuovo oggetto di tipo Point
                Point punto = e.GetPosition(this);
                //Calcolo le distanze geometriche tra il punto in cui viene fatto il tap
                // e i vari punti in cui ci sono le differenze
                // Distanza per l'asse delle X
                double X1 = Math.Abs(punto.X - punto1.X);
                double X2 = Math.Abs(punto.X - punto2.X);
                double X3 = Math.Abs(punto.X - punto3.X);
                double X4 = Math.Abs(punto.X - punto4.X);
                //Distanza per l'asse delle Y
                double Y1 = Math.Abs(punto.Y - punto1.Y);
                double Y2 = Math.Abs(punto.Y - punto2.Y);
                double Y3 = Math.Abs(punto.Y - punto3.Y);
                double Y4 = Math.Abs(punto.Y - punto4.Y);
                //Se la distanza tra il punto in cui si tocca e la differenza è <10, mostra l'immagine del cerchio
                // che indica che la differenza è stata trovata, e incremento il contatore delle differenze trovate
                if (X1 < 30 && Y1 < 30)
                {
                    circle1.Visibility = Visibility.Visible;
                    i++;
                }

                if (X2 < 30 && Y2 < 30)
                {
                    circle2.Visibility = Visibility.Visible;
                    i++;
                }
                if (X3 < 30 && Y3 < 30)
                {
                    circle3.Visibility = Visibility.Visible;
                    i++;
                }
                if (X4 < 30 && Y4 < 30)
                {  
                    circle4.Visibility = Visibility.Visible;
                    i++;
                }
                //Se sono state trovate tutte le differenze vado avanti
                if (i == 4)
                {
                    original.Source = null;
                    image.Source = null;
                    circle1.Source = null;
                    circle2.Source = null;
                    circle3.Source = null;
                    circle4.Source = null;
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    NavigationService.Navigate(new Uri("/lvlSet2/s2lvl2.xaml", UriKind.Relative));
                }


            }

 

        

         

            

           
    }
}
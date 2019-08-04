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
    public partial class Istruzioni : PhoneApplicationPage
    {
        public Istruzioni()
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
                Instr.Text = "ISTRUZIONI";
                Inf.Text = "Il gioco consiste nel superare i vari tranelli che vi poniamo. Alla fine di ogni set di livelli ti verrà attribuito un punteggio in stelle. Le prime due dipenderanno dal tempo che impieghi per completare il livello, la terza stella dovrai cercarla all'interno dei livelli, è nascosta ed ha questo aspetto : \n \n Buon divertimento!";
               
            }

            else
            {
                Instr.Text = "INSTRUCTIONS";
                Inf.Text = "The game consists in overcoming the various pitfalls that you ask. At the end of each set of levels you will be given a score in stars. The first two depend on the time it takes to complete the level, you will need to look for the third star within levels, it is hidden and looks like this: \n \n Enjoy!";
            }
        }




    }
}
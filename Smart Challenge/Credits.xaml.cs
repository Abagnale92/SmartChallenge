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
    public partial class Credits : PhoneApplicationPage
    {
        public Credits()
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
                Instr.Text = "CREDITS";
                Inf.Text = "Developers: \n Giuseppe Abagnale \n Gerardo Ragosta \n Amedeo Roberto Esposito \n Musica: \n http://freemusicarchive.org/ \n Immagine pinguini: \n BBShadowCat";
            }

            else
            {
                Instr.Text = "CREDITS";
                Inf.Text = "Developers: \n Giuseppe Abagnale /n Gerardo Ragosta \n Amedeo Roberto Esposito \n Music: \n http://freemusicarchive.org/ \n Penguin's images : \n BBShadowCat";
            }
        }




    }
}
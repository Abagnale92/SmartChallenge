using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.IO.IsolatedStorage;
using System.Threading;
using System.Diagnostics;



namespace Smart_Challenge
{
    public class VarGlobal
    {
        public static IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;
        public static bool flag1 = false;
        public static bool flag2 = false;
        public static bool flag3 = false;
        public static bool flag4 = false;
        public static bool flag5 = false;
        public static bool flag6 = false;
        public static bool flag7 = false;
        public static bool flag8 = false;
        public static IsolatedStorageSettings flaglvl2 = IsolatedStorageSettings.ApplicationSettings;
        public static int valoreFlag2 = 0;
        public static bool scelta = false;
        public static bool star = false;
        public static byte check = 0;
        public static int livello = 0;
        public static int count = 0;
        public static int count1 = 0;
        public static int count2 = 0;
        public static string text1, text2;
        public static IsolatedStorageSettings stelle = IsolatedStorageSettings.ApplicationSettings;
        public static Stopwatch stopWatch = new Stopwatch();


    }
}

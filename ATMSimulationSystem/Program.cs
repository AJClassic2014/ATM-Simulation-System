using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ATMManager
{
    static class Program
    {
        /// <summary>
        /// start point of program
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
    
        }
 
    }
}
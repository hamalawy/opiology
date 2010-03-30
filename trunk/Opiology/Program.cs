using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Opiometrics
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //if (Opiometrics.Properties.Settings.Default.TermsAgreed == false)
            //{
            //    Application.Run(new TermsForm());
            //}
            Application.Run(new Form1());
        }
    }
}

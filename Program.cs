using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FruitIshido
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

            //display spalsh form
            SplashForm aSplashForm = new SplashForm();
            aSplashForm.ShowDialog();

            Application.Run(new Ishido());
        }
    }
}

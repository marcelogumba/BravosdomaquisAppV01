using BravosdomaquisApp.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BravosdomaquisApp
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
            //Application.Run(new Principal(true));
            if (Properties.Settings.Default.IsAnyOne)
            {
                Application.Run(new Principal(SystemTheme.GetWindowsDarkTheme()));
            }
            else
            {
                Application.Run(new Login(SystemTheme.GetWindowsDarkTheme(), true));
            }

        }
    }
}

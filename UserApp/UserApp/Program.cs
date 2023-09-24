using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UserApp
{
    static class Program
    {
        public static string sessionkey = string.Empty;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new CheckStatus());
            //Application.Run(new ControlRequest());
            //Application.Run(new ControlIOT());
            Application.Run(new MainScreen());
            //Application.Run(new Splash());
        }
    }
}

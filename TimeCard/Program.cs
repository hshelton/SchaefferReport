using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TimeCard
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
            InitForm view = new InitForm();

            //imediately terminate on an exception
            try
            {
                Application.Run(view);
            }
            catch
            {
                System.Environment.Exit(20);
            }
        }

        private static void ConnectionEstablished(object e, object[] args)
        {
                      
        }
    }
}

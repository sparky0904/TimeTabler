using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Set up the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //TODO: set the connection string to use the database in the project folder if running in debug mode

            // Load the inital Parent
            Application.Run(new MDIParent1());
        }
    }
}

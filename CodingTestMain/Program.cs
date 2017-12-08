using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;
using Model;
using Controller;

namespace CodingTestMain
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
            View.View1 view = new View.View1();
            string databasePath = "C:/Users/huanx/Desktop/Sqlite/Sample_Database.s3db"; // please change the path 
            Controller.Controller controller = new Controller.Controller(view,databasePath);
            Application.Run(view);
        }
    }
}

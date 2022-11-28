using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tekla.Structures.Model;

namespace Core
{
    static class Program
    {
        static Model MyModel;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (MyModel == null)
            {
                MyModel = new Model();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fStartup(MyModel));
            
        }
    }
}

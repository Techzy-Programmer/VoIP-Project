using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoltCall
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
            //if (Helper.Wire.SetupModules(out string[] Modules))
            //    foreach (var SDll in Modules) Assembly.LoadFrom(SDll);
            Application.Run(new Interactives.Test());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZaitsevMS.Sprint6.Task4.V14.Lib;

namespace Tyuiu.ZaitsevMS.Sprint6.Task4.V14
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary> 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
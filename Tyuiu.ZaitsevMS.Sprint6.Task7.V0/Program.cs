using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZaitsevMS.Sprint6.Task7.V3.Lib;

namespace Tyuiu.ZaitsevMS.Sprint6.Task7.V3
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
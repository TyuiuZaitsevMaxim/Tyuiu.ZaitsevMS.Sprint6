using System;
using System.Windows.Forms;

namespace Tyuiu.ZaitsevMS.Sprint6.Task3.V19
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
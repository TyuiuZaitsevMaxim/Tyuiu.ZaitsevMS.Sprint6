using System;
using System.Windows.Forms;

namespace Tyuiu.ZaitsevMS.Sprint6.Task1.V20
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
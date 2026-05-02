using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace ZaitsevMS.Tyuiu.Sprint6.Task0.V0.Lib
{
    public class DataService : ISprint6Task0V0
    {
        public double Calculate(int x)
        {
            double res = (double)x - 1.5;
            return Math.Round(res, 3);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZaitsevMS.Sprint6.Task1.V20.Lib
{
    public class DataService : ISprint6Task1V20
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denom = Math.Cos(x) - 2 * x;
                double y;

                if (denom == 0)
                {
                    y = 0.0;
                }
                else
                {
                    y = (2 * x - 3.0) / denom + 5 * x - Math.Sin(x);
                }

                valueArray[count] = Math.Round(y, 2);
                count++;
            }

            return valueArray;
        }
    }
}
using System;

namespace Tyuiu.ZaitsevMS.Sprint6.Task4.V0.Lib
{
    public class DataService
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];

            for (int x = startValue, i = 0; x <= stopValue; x++, i++)
            {
                valueArray[i] = Math.Round(Math.Sin(x), 2);
            }

            return valueArray;
        }
    }
}

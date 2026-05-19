using System;

namespace Tyuiu.ZaitsevMS.Sprint6.Task4.V14.Lib
{
    public class DataService
    {
        public double[] GetMassFunction(int startValue, int stopValue) 
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];

            for (int x = startValue, i = 0; x <= stopValue; x++, i++)
            {
                double denominator = Math.Sin(x) + 1;

                if (denominator == 0)
                {
                    valueArray[i] = 0;
                }
                else
                {
                    double result = 2 * x - 4 + (2 * x - 1) / denominator;
                    valueArray[i] = Math.Round(result, 2);
                }
            }

            return valueArray;
        }
    }
}
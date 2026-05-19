using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint6.Task1.V20.Lib;

namespace Tyuiu.ZaitsevMS.Sprint6.Task1.V20.Test
{
    [TestClass] 
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            double[] wait =
            {
                -27.22,
                -22.25,
                -16.66,
                -11.04,
                  -6.13,
                  -3.0,
                   4.84,
                   8.86,
                  14.43,
                  20.18,
                  25.24
            };

            CollectionAssert.AreEqual(wait, result);
        }
    }
}
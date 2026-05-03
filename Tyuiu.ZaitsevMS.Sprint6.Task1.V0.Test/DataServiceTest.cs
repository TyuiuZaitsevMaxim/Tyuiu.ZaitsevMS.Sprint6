using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaitsevMS.Sprint6.Task1.V0.Lib;

namespace Tyuiu.ZaitsevMS.Sprint6.Task1.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1() 
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(1, 3);
            double[] wait = { 0.84, 0.91, 0.14 };

            CollectionAssert.AreEqual(wait, result);
        }
    }
}

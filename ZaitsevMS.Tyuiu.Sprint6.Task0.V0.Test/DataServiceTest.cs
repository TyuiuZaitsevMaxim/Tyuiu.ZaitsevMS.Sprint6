using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ZaitsevMS.Tyuiu.Sprint6.Task0.V0.Lib;

namespace ZaitsevMS.Tyuiu.Sprint6.Task0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(7);
            double wait = 5.5;
            Assert.AreEqual(wait, res); 
        }
    }
}

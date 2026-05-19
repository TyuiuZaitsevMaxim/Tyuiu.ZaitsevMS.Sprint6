using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZaitsevMS.Sprint6.Task4.V14.Lib;

namespace Tyuiu.ZaitsevMS.Sprint6.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMassFunctionLength() 
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(-5, 5);
            Assert.AreEqual(11, result.Length);
        }

        [TestMethod]
        public void TestGetMassFunctionZeroX()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(0, 0);
            Assert.AreEqual(-5.0, result[0]);
        }

        [TestMethod]
        public void TestGetMassFunctionPositiveX()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(1, 1);
            Assert.AreEqual(-1.46, result[0]);
        }

        [TestMethod]
        public void TestGetMassFunctionNegativeX()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(-1, -1);
            Assert.AreEqual(-24.92, result[0]);
        }

        [TestMethod]
        public void TestGetMassFunctionRange()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(0, 2);
            double[] expected = { -5.0, -1.46, 1.57 };
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
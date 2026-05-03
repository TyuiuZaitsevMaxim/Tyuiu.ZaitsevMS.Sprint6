using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZaitsevMS.Sprint6.Task2.V0.Lib;

namespace Tyuiu.ZaitsevMS.Sprint6.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMassFunction()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(1, 3);
            double[] wait = { 0.84, 0.91, 0.14 };

            CollectionAssert.AreEqual(wait, result);
        }
    }
}

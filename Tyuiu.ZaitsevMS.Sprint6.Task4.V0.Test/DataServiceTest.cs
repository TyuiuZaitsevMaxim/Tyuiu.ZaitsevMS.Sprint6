using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZaitsevMS.Sprint6.Task4.V0.Lib;

namespace Tyuiu.ZaitsevMS.Sprint6.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMassFunction()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(-1, 1);
            double[] wait = { -0.84, 0, 0.84 };

            CollectionAssert.AreEqual(wait, result);
        }
    }
}

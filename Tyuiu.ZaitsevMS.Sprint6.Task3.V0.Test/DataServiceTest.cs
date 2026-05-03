using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZaitsevMS.Sprint6.Task3.V0.Lib;

namespace Tyuiu.ZaitsevMS.Sprint6.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetCountZero()
        {
            DataService ds = new DataService();
            int[,] matrix = { { 0, 1, 2 }, { 3, 0, 5 }, { 3, 4, 5 } };

            int result = ds.GetCountZero(matrix);
            int wait = 2;

            Assert.AreEqual(wait, result);
        }
    }
}

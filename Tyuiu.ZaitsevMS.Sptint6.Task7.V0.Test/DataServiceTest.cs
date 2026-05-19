using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.ZaitsevMS.Sprint6.Task7.V3.Lib;

namespace Tyuiu.ZaitsevMS.Sprint6.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMatrix_ReplacesEvenInColumn0()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName();

            File.WriteAllLines(path, new[] { "2,5,7", "3,6,8", "4,1,9" });

            int[,] result = ds.GetMatrix(path);

            Assert.AreEqual(-1, result[0, 0]);
            Assert.AreEqual(3, result[1, 0]);
            Assert.AreEqual(-1, result[2, 0]);

            Assert.AreEqual(5, result[0, 1]);
            Assert.AreEqual(6, result[1, 1]);

            File.Delete(path);
        }

        [TestMethod]
        public void TestGetMatrix_OddValuesUnchanged()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName();

            File.WriteAllLines(path, new[] { "1,2", "3,4" });

            int[,] result = ds.GetMatrix(path);

            Assert.AreEqual(1, result[0, 0]);
            Assert.AreEqual(3, result[1, 0]);

            Assert.AreEqual(2, result[0, 1]);
            Assert.AreEqual(4, result[1, 1]);

            File.Delete(path);
        }

        [TestMethod]
        public void TestGetMatrix_ZeroIsEven()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName();

            File.WriteAllLines(path, new[] { "0,1" });

            int[,] result = ds.GetMatrix(path);

            Assert.AreEqual(-1, result[0, 0]);

            File.Delete(path);
        }
    }
}
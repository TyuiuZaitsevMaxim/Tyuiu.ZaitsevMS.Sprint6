using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.ZaitsevMS.Sprint6.Task5.V29.Lib;

namespace Tyuiu.ZaitsevMS.Sprint6.Task5.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestLoadFromDataFile() 
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName();

            File.WriteAllLines(path, new[] { "10", "9.999", "-5", "25,5", "15.1234" });

            double[] result = ds.LoadFromDataFile(path);
            double[] expected = { 10.0, 25.5, 15.123 };

            CollectionAssert.AreEqual(expected, result);
            File.Delete(path);
        }

        [TestMethod]
        public void TestLoadFromDataFileRounding()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName();

            File.WriteAllLines(path, new[] { "12.56789" });

            double[] result = ds.LoadFromDataFile(path);

            Assert.AreEqual(12.568, result[0]);
            File.Delete(path);
        }

        [TestMethod]
        public void TestLoadFromDataFileEmpty()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName();

            File.WriteAllLines(path, new[] { "1", "5", "-100" });

            double[] result = ds.LoadFromDataFile(path);

            Assert.AreEqual(0, result.Length);
            File.Delete(path);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.ZaitsevMS.Sprint6.Task5.V0.Lib;

namespace Tyuiu.ZaitsevMS.Sprint6.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName();

            // Проверяем: запятая как десятичный разделитель, точка, ноль, отрицательное
            File.WriteAllLines(path, new[] { "1,5", "-2", "0", "3.25" });

            double[] result = ds.LoadFromDataFile(path);
            double[] expected = { 1.5, 3.25 };

            CollectionAssert.AreEqual(expected, result);
            File.Delete(path);
        }
    }
}
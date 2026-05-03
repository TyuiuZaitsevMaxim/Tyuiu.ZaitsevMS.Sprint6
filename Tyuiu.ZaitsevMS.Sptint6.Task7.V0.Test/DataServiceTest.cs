using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZaitsevMS.Sptint6.Task7.V0.Lib;

namespace Tyuiu.ZaitsevMS.Sptint6.Task7.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMatrix_ReplacesZeroInColumn2()
        {
            DataService ds = new DataService();

            int[,] input = {
                { 1, 2, 0, 4 },
                { 5, 6, 3, 8 },
                { 9, 0, 0, 2 }
            };

            int[,] result = ds.GetMatrix(input);

            // Столбец 2: 0 → 1, остальные не трогаем
            Assert.AreEqual(1, result[0, 2]);
            Assert.AreEqual(3, result[1, 2]);
            Assert.AreEqual(1, result[2, 2]);

            // Другие столбцы не изменились
            Assert.AreEqual(1, result[0, 0]);
            Assert.AreEqual(0, result[2, 1]);
        }

        [TestMethod]
        public void TestGetMatrix_DoesNotModifyOtherColumns()
        {
            DataService ds = new DataService();

            int[,] input = {
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            };

            int[,] result = ds.GetMatrix(input);

            // Только столбец 2 меняется
            Assert.AreEqual(0, result[0, 0]);
            Assert.AreEqual(0, result[0, 1]);
            Assert.AreEqual(1, result[0, 2]);
            Assert.AreEqual(0, result[0, 3]);
        }
    }
}
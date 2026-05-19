using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZaitsevMS.Sprint6.Task3.V19.Lib;

namespace Tyuiu.ZaitsevMS.Sprint6.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix =
            {
                {  4, 32, -20, 27, 21 },
                { 17, 15,  -1, -2, -1 },
                { -3, 18,  12,-10, 29 },
                {  7,-15,   2, -8, 12 },
                {-10, 25,   5, 27, 21 }
            };

            int[,] result = ds.Calculate(matrix);

            int[,] wait =
            {
                { 17, 15,  -1, -2, -1 },
                {  7,-15,   2, -8, 12 },
                {  4, 32, -20, 27, 21 },
                {-10, 25,   5, 27, 21 },
                { -3, 18,  12,-10, 29 }
            };

            CollectionAssert.AreEqual(wait, result);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZaitsevMS.Sprint6.Task6.V27.Lib;

namespace Tyuiu.ZaitsevMS.Sprint6.Task6.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCollectTextFromFile_ReturnsWordsWithH()
        {
            DataService ds = new DataService();
            string input = "Hello World\nHouse cat\nno match here";
            string result = ds.CollectTextFromFile(input);
            Assert.AreEqual("Hello House", result);
        }

        [TestMethod]
        public void TestCollectTextFromFile_NoMatches_ReturnsEmpty()
        {
            DataService ds = new DataService();
            string input = "hello world\nno match here";
            string result = ds.CollectTextFromFile(input);
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void TestCollectTextFromFile_MultipleWordsPerLine()
        {
            DataService ds = new DataService();
            string input = "HTTP HTTPS test Hello";
            string result = ds.CollectTextFromFile(input);
            Assert.AreEqual("HTTP HTTPS Hello", result);
        }
    }
}
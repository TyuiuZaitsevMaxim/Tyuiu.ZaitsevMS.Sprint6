using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZaitsevMS.Sprint6.Task6.V0.Lib;

namespace Tyuiu.ZaitsevMS.Sprint6.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCollectTextFromFile_ReturnsMatchingLines()
        {
            DataService ds = new DataService();
            string input = "hello world\ntest ** line\nno match here\nanother ** entry";
            string result = ds.CollectTextFromFile(input);
            string expected = "test ** line\r\nanother ** entry";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCollectTextFromFile_NoMatches_ReturnsEmpty()
        {
            DataService ds = new DataService();
            string input = "line one\nline two\nline three";
            string result = ds.CollectTextFromFile(input);
            Assert.AreEqual(string.Empty, result);
        }
    }
}
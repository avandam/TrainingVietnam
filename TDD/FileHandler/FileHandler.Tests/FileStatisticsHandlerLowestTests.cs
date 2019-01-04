using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

// ReSharper disable UnusedVariable

namespace FileHandler.Tests
{
    [TestClass]
    public class FileStatisticsHandlerLowestTests
    {
        [TestMethod]
        public void GetLowestNumberTest()
        {
            FileStatisticsHandler statistics = new FileStatisticsHandler();

            int number = statistics.GetLowestNumber(@"inputFiles\simple.txt", out List<int> lines);

            Assert.AreEqual(1, number, "The number is incorrect");
            Assert.AreEqual(2, lines[0], "The line number is incorrect");
        }

        [TestMethod]
        public void GetLowestNumberDuplicateTest()
        {
            FileStatisticsHandler statistics = new FileStatisticsHandler();

            int number = statistics.GetLowestNumber(@"inputFiles\duplicate.txt", out List<int> lines);

            Assert.AreEqual(1, number, "The number is incorrect");
            Assert.AreEqual(2, lines[0], "The first line number is incorrect");
            Assert.AreEqual(3, lines[1], "The second line number is incorrect");
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

// ReSharper disable UnusedVariable

namespace FileHandler.Tests
{
    [TestClass]
    public class FileStatisticsHandlerHighestTests
    {
        [TestMethod]
        public void GetHighestNumberTest()
        {
            FileStatisticsHandler statistics = new FileStatisticsHandler();

            int number = statistics.GetHighestNumber(@"inputFiles\simple.txt", out List<int> lines);

            Assert.AreEqual(10, number, "The number is incorrect");
            Assert.AreEqual(1, lines[0], "The line number is incorrect");
        }

        [TestMethod]
        public void GetHighestNumberDuplicateTest()
        {
            FileStatisticsHandler statistics = new FileStatisticsHandler();

            int number = statistics.GetHighestNumber(@"inputFiles\duplicate.txt", out List<int> lines);

            Assert.AreEqual(10, number, "The number is incorrect");
            Assert.AreEqual(1, lines[0], "The first line number is incorrect");
            Assert.AreEqual(3, lines[1], "The second line number is incorrect");
        }
    }
}
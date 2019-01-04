using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

// ReSharper disable UnusedVariable

namespace FileHandler.Tests
{
    [TestClass]
    public class FileStatisticsHandlerReadFileTests
    {
        [TestMethod]
        [ExpectedException(typeof(EmptyFileException), "EmptyFileException should have been thrown")]
        public void GetHighestNumberEmptyFileTest()
        {
            FileStatisticsHandler.ReadFile(@"inputFiles\emptyfile.txt");
        }

        [TestMethod]
        [ExpectedException(typeof(IncorrectFormatException), "IncorrectFormatException should have been thrown")]
        public void ReadFileDecimalTest()
        {
            FileStatisticsHandler.ReadFile(@"inputFiles\decimalNumber.txt");
        }

        [TestMethod]
        [ExpectedException(typeof(IncorrectFormatException), "IncorrectFormatException should have been thrown")]
        public void ReadFileStringTest()
        {
            FileStatisticsHandler.ReadFile(@"inputFiles\string.txt");
        }

        [TestMethod]
        [ExpectedException(typeof(IncorrectFormatException), "IncorrectFormatException should have been thrown")]
        public void ReadFileIncorrectSeparatorTest()
        {
            FileStatisticsHandler.ReadFile(@"inputFiles\incorrectSeparator.txt");
        }

        [TestMethod]
        [ExpectedException(typeof(IncorrectFormatException), "IncorrectFormatException should have been thrown")]
        public void ReadFileEmptyLineTest()
        {
            FileStatisticsHandler.ReadFile(@"inputFiles\emptyLine.txt");
        }

        [TestMethod]
        [ExpectedException(typeof(NoFilenameException), "NoFilenameException should have been thrown")]
        public void ReadFileNoFilenameTest()
        {
            FileStatisticsHandler.ReadFile(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException), "FileNotFoundException should have been thrown")]
        public void ReadFileFileNotFoundTest()
        {
            FileStatisticsHandler.ReadFile(@"inputFiles\fileNotFound.txt");
        }


        [TestMethod]
        [ExpectedException(typeof(NumberTooBigException), "NumberTooBigException should have been thrown")]
        public void ReadFileOverflowTest()
        {
            FileStatisticsHandler.ReadFile(@"inputFiles\numberTooBig.txt");
        }

        [TestMethod]
        [ExpectedException(typeof(NegativeNumberException), "NegativeNumberException should have been thrown")]
        public void ReadFileNegativeTest()
        {
            FileStatisticsHandler.ReadFile(@"inputFiles\negativeNumber.txt");
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandler
{
    public class FileStatisticsHandler
    {
        public int GetLowestNumber(string path, out List<int> lineNumbers)
        {
            lineNumbers = new List<int>();
            int lowestNumber = int.MaxValue;

            List<List<int>> allNumbers = ReadFile(path);

            for (int i =0; i < allNumbers.Count; i++)
            {
                int lowestOnLine = allNumbers[i].Min();
                if (lowestNumber > lowestOnLine)
                {
                    lowestNumber = lowestOnLine;
                    lineNumbers.Clear();
                    lineNumbers.Add(i+1);
                }
                else if (lowestNumber == lowestOnLine)
                {
                    lineNumbers.Add(i+1);
                }
            }

            return lowestNumber;
        }


        public int GetHighestNumber(string path, out List<int> lineNumbers)
        {
            lineNumbers = new List<int>();
            int highestNumber = int.MinValue;

            List<List<int>> allNumbers = ReadFile(path);

            for (int i = 0; i < allNumbers.Count; i++)
            {
                int highestOnLine = allNumbers[i].Max();
                if (highestNumber < highestOnLine)
                {
                    highestNumber = highestOnLine;
                    lineNumbers.Clear();
                    lineNumbers.Add(i + 1);
                }
                else if (highestNumber == highestOnLine)
                {
                    lineNumbers.Add(i + 1);
                }
            }

            return highestNumber;
        }

        internal static List<List<int>> ReadFile(string path)
        {
            if (String.IsNullOrEmpty(path))
            {
                throw new NoFilenameException();
            }

            if (!File.Exists(path))
            {
                throw new FileNotFoundException();
            }

            if (new FileInfo(path).Length == 0)
            {
                throw new EmptyFileException();
            }

            List<List<int>> allNumbers = new List<List<int>>();

            try
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    if (String.IsNullOrEmpty(line) || String.IsNullOrWhiteSpace(line))
                    {
                        throw new IncorrectFormatException();
                    }

                    string[] numbers = line.Split(' ');
                    List<int> numbersForCurrentLine = new List<int>();
                    foreach (string number in numbers)
                    {
                        if (number.Length > 8)
                        {
                            throw new NumberTooBigException();
                        }

                        int currentNumber = Convert.ToInt32(number);
                        if (currentNumber < 0)
                        {
                            throw new NegativeNumberException();
                        }

                        numbersForCurrentLine.Add(currentNumber);
                    }

                    allNumbers.Add(numbersForCurrentLine);
                }
            }
            catch (IncorrectFormatException)
            {
                throw;
            }
            catch (NumberTooBigException)
            {
                throw;
            }
            catch (NegativeNumberException)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new IncorrectFormatException();
            }

            return allNumbers;
        }

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberPrinter.Program
{
    public class ReadFile
    {
        private OutputPrinter printer;

        public ReadFile()
        {
            this.printer = new OutputPrinter();
        }

        public List<int> ParseFile(string fileName)
        {
            var integerList = new List<int>();

            if (File.Exists(fileName))
            {
                using (var reader = new StreamReader(fileName))
                {
                    string line;
                    while (!string.IsNullOrEmpty(line = reader.ReadLine()))
                    {
                        int integerToAdd;
                        if (int.TryParse(line, out integerToAdd))
                        {
                            integerList.Add(integerToAdd);
                        }
                        else // Assume that we want to exit the program if the file contains invalid information
                        {
                            throw new FormatException("Invalid contents in the entered file");
                        }
                    }
                }
            }
            else
            {
                throw new FileNotFoundException("The file was not found.");
            }

            return integerList;
        }
    }
}

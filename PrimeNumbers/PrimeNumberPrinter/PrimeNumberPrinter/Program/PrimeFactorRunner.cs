using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrimeNumberPrinter.Program
{
    public class PrimeFactorRunner
    {
        /// <summary>
        /// Main runner for the program
        /// </summary>
        /// <param name="args"><param>
        public static void Main(string[] args)
        {
            var printer = new OutputPrinter();
            var calculator = new PrimeFactorCalculator();

            var inputList = GetValidFileContentsFromUser(printer);

            printer.PrintLines("Prime factors for each number are:");
            foreach (var input in inputList)
                printer.PrintLines($"{input}: " + string.Join(",", calculator.GetPrimeFactors(input)));

            ExitProgram(printer);
        }

        /// <summary>
        /// Gets a valid file with valid contents from the user
        /// </summary>
        /// <param name="outputPrinter">Instance of the printer class</param>
        /// <returns>List of integers from entered file</returns>
        private static List<int> GetValidFileContentsFromUser(OutputPrinter outputPrinter)
        {
            var inputReader = new InputReader();
            var fileReader = new ReadFile();

            var validFile = false;
            var inputList = new List<int>();

            while(!validFile)
            {
                try
                {
                    var file = inputReader.GetUserInput("Please input a file to parse. Type exit to exit program");
                    if (file.ToLower().Equals("exit"))
                        ExitProgram(outputPrinter);
                    inputList = fileReader.ParseFile(file);
                    validFile = true;
                }
                catch (FileNotFoundException)
                {
                    outputPrinter.PrintLines("The file does not exist.  Please try again");
                }
                catch (FormatException)
                {
                    outputPrinter.PrintLines("The file contains contents that are not integers.");
                }
            }

            return inputList;
        }

        /// <summary>
        /// Exits the program when the user is done
        /// </summary>
        /// <param name="printer">Instance of the printer clas</param>
        private static void ExitProgram(OutputPrinter printer)
        {
            printer.PrintLines("Program is done. Press Enter to exit");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeNumberPrinter.Program.Interfaces;

namespace PrimeNumberPrinter.Program
{
    public class InputReader : IUserInput
    {
        private OutputPrinter print;

        public InputReader()
        {
            print = new OutputPrinter();
        }

        /// <summary>
        /// Print a prompt out and read user's input
        /// </summary>
        /// <param name="prompt">String to print out to user</param>
        /// <returns>User's entered input</returns>
        public string GetUserInput(string prompt)
        {
            print.PrintLines(prompt);
            return Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberPrinter.Program
{
    public class OutputPrinter
    {
        // Splitting printing into own method so the mode of printing can change
        /// <summary>
        /// Prints the entered string out to user
        /// </summary>
        /// <param name="text">String to print out</param>
        public void PrintLines(string text)
        {
            Console.WriteLine(text);
        }
    }
}

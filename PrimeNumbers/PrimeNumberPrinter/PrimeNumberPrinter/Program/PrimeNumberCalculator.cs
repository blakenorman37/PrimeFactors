using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberPrinter.Program
{
    public class PrimeNumberCalculator
    {
        /// <summary>
        /// Calculate the prime factors for a number
        /// </summary>
        /// <param name="inputNumber">Number to find the prime factors for</param>
        /// <returns>List of prime factors</returns>
        public List<int> GetPrimeFactors(int inputNumber)
        {
            var results = new List<int>();

            // Divide by 2 mulitple times until an odd number is returned
            while (inputNumber % 2 == 0)
            {
                results.Add(2);
                inputNumber /= 2;
            }

            // Check for all odd numbers with squares less than the entered number
            var baseFactor = 3;
            while (inputNumber >= baseFactor * baseFactor)
            {
                if (inputNumber % baseFactor == 0)
                {
                    results.Add(baseFactor);
                    inputNumber /= baseFactor;
                }
                else
                {
                    baseFactor += 2;
                }
            }

            // If the left over number is greater than 1 then it is prime so add it to the list
            if (inputNumber > 1)
            {
                results.Add(inputNumber);
            }

            return results;
        }
    }
}

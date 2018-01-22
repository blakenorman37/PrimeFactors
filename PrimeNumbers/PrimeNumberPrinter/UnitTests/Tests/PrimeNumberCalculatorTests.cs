using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PrimeNumberPrinter.Program;

namespace UnitTests.Tests
{
    [TestFixture]
    public class PrimeNumberCalculatorTests
    {
        private PrimeNumberCalculator calculator;

        [OneTimeSetUp]
        public void Init()
        {
            calculator = new PrimeNumberCalculator();
        }

        // Output should be empty because 1 is neither prime nor composite
        [Test]
        public void TestCalculatorWith1()
        {
            var output = calculator.GetPrimeFactors(1);
            CollectionAssert.IsEmpty(output);
        }

        // Verify the output with a prime number, the output should only return itself
        [Test]
        public void TestCalculatorWithPrimeNumber()
        {
            var output = calculator.GetPrimeFactors(17);
            CollectionAssert.AreEquivalent(output, new List<int> { 17 });
        }

        // Verify the correct primes are returned with a composite number
        [Test]
        public void TestCalculatorWithCompositeNumber()
        {
            var output = calculator.GetPrimeFactors(10);
            CollectionAssert.AreEquivalent(output, new List<int> { 2, 5 });
        }
    }
}

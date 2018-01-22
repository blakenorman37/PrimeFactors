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
    public class OutputPrinterTests
    {
        private OutputPrinter outputPrinter;

        [OneTimeSetUp]
        public void Init()
        {
            outputPrinter = new OutputPrinter();
        }

        // Not much to do here with these requirements, but could be useful in the future
        [Test]
        public void TestOutput()
        {
            outputPrinter.PrintLines("Testing");
        }
    }
}

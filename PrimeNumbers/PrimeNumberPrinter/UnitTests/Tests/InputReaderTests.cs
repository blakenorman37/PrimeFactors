using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PrimeNumberPrinter.Program;
using UnitTests.MockClasses;

namespace UnitTests.Tests
{
    [TestFixture]
    public class InputReaderTests
    {
        private FakeInputReader inputReader;

        [OneTimeSetUp]
        public void Init()
        {
            inputReader = new FakeInputReader();
        }

        // Not much to do here with these requirements, but could be useful in the future
        [Test]
        public void TestUserInput()
        {
            var input = inputReader.GetUserInput(string.Empty);
            Assert.That(!string.IsNullOrEmpty(input));
        }
    }
}

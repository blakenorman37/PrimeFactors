using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeNumberPrinter.Program.Interfaces;

namespace UnitTests.MockClasses
{
    public class FakeInputReader : IUserInput
    {
        public string GetUserInput(string prompt)
        {
            return "This is working";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberPrinter.Program.Interfaces
{
    public interface IUserInput
    {
        // Created for mocking in Unit Tests, not very valuable now, but could be if requirements change
        string GetUserInput(string prompt);
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PrimeNumberPrinter.Program;

namespace UnitTests.Tests
{
    [TestFixture]
    public class ReadFileTests
    {
        private ReadFile readFile;

        [OneTimeSetUp]
        public void Init()
        {
            readFile = new ReadFile();
        }


        // Verify that the correct execption is thrown and handled for invalid file
        [Test]
        public void TestForInvalidFile()
        {
            try
            {
                readFile.ParseFile("C:/FakeFile");
                Assert.Fail("File not found exception should have been thrown");
            }
            catch (FileNotFoundException)
            {
                Assert.Pass("File did not exist");
            }
        }

        // Verify that the correct execption is thrown and handled for a file with invalid contents
        [Test]
        public void TestFileWithInvalidContents()
        {
            try
            {
                var file = Path.GetFullPath(Path.Combine((new Uri(Assembly.GetExecutingAssembly().CodeBase)).AbsolutePath, @"..\..\..\TestFiles\InvalidContentFile.txt"));
                readFile.ParseFile(file);
                Assert.Fail("Format exception should have been thrown");
            }
            catch (FormatException)
            {
                Assert.Pass("Format exception handled");
            }
        }

        // Verify that a valid file is parsed and returns a list of integers
        [Test]
        public void TestFileWithValidContents()
        {
            var file = Path.GetFullPath(Path.Combine((new Uri(Assembly.GetExecutingAssembly().CodeBase)).AbsolutePath, @"..\..\..\TestFiles\ValidFile.txt"));
            var inputList = readFile.ParseFile(file);
            CollectionAssert.IsNotEmpty(inputList);
        }
    }
}

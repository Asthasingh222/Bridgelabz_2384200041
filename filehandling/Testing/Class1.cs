using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using filehandling;
using NUnit.Framework;

namespace Testing
{
    [TestFixture]
    public class FileProcessorTests
    {
        private FileProcessor _fileProcessor;
        private string _testFile = "testfile.txt";

        [SetUp]
        public void SetUp()
        {
            _fileProcessor = new FileProcessor();
        }

        [TearDown]
        public void TearDown()
        {
            if (File.Exists(_testFile))
                File.Delete(_testFile);
        }

        [Test]
        public void WriteToFile_And_ReadFromFile_Returns_Correct_Content()
        {
            string content = "Hello, NUnit!";
            _fileProcessor.WriteToFile(_testFile, content);
            string result = _fileProcessor.ReadFromFile(_testFile);

            Assert.That(result, Is.EqualTo(content));
        }

        [Test]
        public void ReadFromFile_NonExistentFile_Throws_Exception()
        {
            Assert.That(() => _fileProcessor.ReadFromFile("nonexistent.txt"), Throws.Exception.TypeOf<FileNotFoundException>());
        }
    }
}

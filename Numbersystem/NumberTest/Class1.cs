using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Numbersystem;
using System.Threading.Tasks;

namespace NumberTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Even()
        {
            string expected = "Even";
            Number n1 = new Number(16);
            string actual = n1.EvenOdd();
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Odd() {
            string expected = "Odd";
            Number n1 = new Number(3);
            string actual = n1.EvenOdd();
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }
    }
}

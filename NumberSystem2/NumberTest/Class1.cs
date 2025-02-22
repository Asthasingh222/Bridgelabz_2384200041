using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberSystem2;
using NUnit.Framework;
namespace NumberTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Even()
        {
            string expected = "Even";
            Number n1 = new Number(10);
            string actual = n1.EvenOdd();
            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void Odd()
        {
            string expected = "Even";
            Number n1 = new Number(3);
            string actual = n1.EvenOdd();
            Assert.That(expected, Is.EqualTo(actual));
        }



    }
}

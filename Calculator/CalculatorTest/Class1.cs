using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using NUnit.Framework;
namespace CalculatorTest
{
    [TestFixture]
    public class Class1
    {
        private Calculatorcl ct;
        [SetUp]
        public void Setup()
        {
            ct = new Calculatorcl();
        }

        [Test]
        public void Add_TwoNumbers_ReturnsCorrectSum()
        {
            Assert.That(ct.Add(5, 3), Is.EqualTo(8));
        }

        [Test]
        public void Subtract_TwoNumbers_ReturnsCorrectDifference()
        {
            Assert.That(ct.Subtract(10, 4), Is.EqualTo(6));
        }

        [Test]
        public void Multiply_TwoNumbers_ReturnsCorrectProduct()
        {
            Assert.That(ct.Multiply(6, 7), Is.EqualTo(42));
        }

        [Test]
        public void Divide_TwoNumbers_ReturnsCorrectQuotient()
        {
            Assert.That(ct.Divide(10, 2), Is.EqualTo(5));
        }

        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.That(() => ct.Divide(10, 0), Throws.Exception.TypeOf<DivideByZeroException>());
        }

    }
}

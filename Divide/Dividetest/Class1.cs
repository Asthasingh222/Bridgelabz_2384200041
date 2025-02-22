using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Divide;
using System.Reflection.Emit;

namespace Dividetest
{
    [TestFixture]
    public class TestDivision
    {
        private DivideClass d;
        [SetUp]
        public void SetUp()
        {
            d= new DivideClass();
        }
        [Test]
        public void Divide_ByZero_ThrowsArithmeticException()
        {
            Assert.That(() => d.Divide(10, 0), Throws.Exception.TypeOf<DivideByZeroException>());
        }
    }
}

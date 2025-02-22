using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Parametrerized;

namespace parameterizedtest
{
    [TestFixture]
    public class NumberUtilsTests
    {
        private NumberUtils _numberUtils;

        [SetUp]
        public void SetUp()
        {
            _numberUtils = new NumberUtils();
        }

        [TestCase(2, ExpectedResult = true)]
        [TestCase(4, ExpectedResult = true)]
        [TestCase(6, ExpectedResult = true)]
        [TestCase(7, ExpectedResult = false)]
        [TestCase(9, ExpectedResult = false)]
        public bool IsEven_Returns_Correct_Result(int number)
        {
            return _numberUtils.IsEven(number);
        }
    }
}

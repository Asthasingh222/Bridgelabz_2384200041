using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Date;

namespace Testing
{
    [TestFixture]
    public class DateFormatterTests
    {
        private DateFormatter _formatter;

        [SetUp]
        public void SetUp()
        {
            _formatter = new DateFormatter();
        }

        [TestCase("2025-02-22", "22-02-2025")]
        [TestCase("1999-12-31", "31-12-1999")]
        public void FormatDate_ValidInput_ShouldConvertFormat(string input, string expected)
        {
            Assert.That(_formatter.FormatDate(input), Is.EqualTo(expected));
        }

        [Test]
        public void FormatDate_InvalidInput_ShouldThrowException()
        {
            Assert.That(() => _formatter.FormatDate("22-02-2025"), Throws.TypeOf<ArgumentException>());
        }
    }
}

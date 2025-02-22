using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Stringut;

namespace Stringtest
{
    [TestFixture]
    public class StringUtilsTests
    {
        private StringUtils _stringUtils;

        [SetUp]
        public void Setup()
        {
            _stringUtils = new StringUtils();
        }

        [Test]
        public void Reverse_String_ReturnsReversedString()
        {
            Assert.That(_stringUtils.Reverse("hello"), Is.EqualTo("olleh"));
        }

        [Test]
        public void IsPalindrome_PalindromeString_ReturnsTrue()
        {
            Assert.That(_stringUtils.IsPalindrome("madam"), Is.True);
        }

        [Test]
        public void IsPalindrome_NonPalindromeString_ReturnsFalse()
        {
            Assert.That(_stringUtils.IsPalindrome("hello"), Is.False);
        }

        [Test]
        public void ToUpperCase_String_ReturnsUpperCaseString()
        {
            Assert.That(_stringUtils.ToUpperCase("hello"), Is.EqualTo("HELLO"));
        }
    }
}

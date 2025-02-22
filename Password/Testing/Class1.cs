using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Password;

namespace Testing
{
    [TestFixture]
    public class PasswordValidatorTests
    {
        private PasswordValidator _validator;

        [SetUp]
        public void SetUp()
        {
            _validator = new PasswordValidator();
        }

        [TestCase("Password1", true)]
        [TestCase("pass", false)]
        [TestCase("password", false)]
        [TestCase("PASSWORD1", true)]
        [TestCase("Pass123", false)]
        public void IsValid_ShouldValidatePasswords(string password, bool expected)
        {
            Assert.That(_validator.IsValid(password), Is.EqualTo(expected));
        }
    }
}

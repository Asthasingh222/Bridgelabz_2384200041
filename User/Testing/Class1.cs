using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using User;

namespace Testing
{
    [TestFixture]
    public class UserRegistrationTests
    {
        private UserRegistration _registration;

        [SetUp]
        public void SetUp()
        {
            _registration = new UserRegistration();
        }

        [Test]
        public void RegisterUser_ValidInput_ShouldNotThrowException()
        {
            Assert.That(() => _registration.RegisterUser("JohnDoe", "john@example.com", "Password123"), Throws.Nothing);
        }

        [Test]
        public void RegisterUser_EmptyUsername_ShouldThrowException()
        {
            Assert.That(() => _registration.RegisterUser("", "john@example.com", "Password123"), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void RegisterUser_InvalidEmail_ShouldThrowException()
        {
            Assert.That(() => _registration.RegisterUser("JohnDoe", "invalid-email", "Password123"), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void RegisterUser_ShortPassword_ShouldThrowException()
        {
            Assert.That(() => _registration.RegisterUser("JohnDoe", "john@example.com", "12345"), Throws.TypeOf<ArgumentException>());
        }
    }
}

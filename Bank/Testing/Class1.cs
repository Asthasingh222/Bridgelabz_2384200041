using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Bank;

namespace Testing
{
    [TestFixture]
    public class BankAccountTests
    {
        private BankAccount _account;

        [SetUp]
        public void SetUp()
        {
            _account = new BankAccount();
        }

        [Test]
        public void Deposit_ValidAmount_IncreasesBalance()
        {
            _account.Deposit(100);
            Assert.That(_account.GetBalance(), Is.EqualTo(100));
        }

        [Test]
        public void Withdraw_ValidAmount_DecreasesBalance()
        {
            _account.Deposit(200);
            _account.Withdraw(50);
            Assert.That(_account.GetBalance(), Is.EqualTo(150));
        }

        [Test]
        public void Withdraw_InsufficientFunds_ThrowsException()
        {
            Assert.That(() => _account.Withdraw(50), Throws.TypeOf<InvalidOperationException>());
        }
    }
}

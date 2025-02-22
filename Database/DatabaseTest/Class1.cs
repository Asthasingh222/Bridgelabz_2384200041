using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Database;

namespace DatabaseTest
{
    [TestFixture]
    public class DatabaseConnectionTests
    {
        private DatabaseCon _db;

        [SetUp]
        public void SetUp()
        {
            _db = new DatabaseCon();
            _db.Connect();
        }

        [TearDown]
        public void TearDown()
        {
            _db.Disconnect();
        }

        [Test]
        public void Connection_Is_Established()
        {
            Assert.That(_db.IsConnected, Is.True);
        }

        [Test]
        public void Connection_Is_Closed_After_Test()
        {
            _db.Disconnect();
            Assert.That(_db.IsConnected, Is.False);
        }
    }
}

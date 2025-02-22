using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Performance;

namespace Testing
{
    [TestFixture]
    public class PerformanceTesterTests
    {
        private PerformanceTester _tester;

        [SetUp]
        public void SetUp()
        {
            _tester = new PerformanceTester();
        }

        [Test, Timeout(2000)]
        public void LongRunningTask_Should_Timeout()
        {
            _tester.LongRunningTask(); // This should fail due to timeout
        }
    }
}

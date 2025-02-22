using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Performance
{
    public class PerformanceTester
    {
        public void LongRunningTask()
        {
            Thread.Sleep(1500); // Simulating delay
        }
    }
}

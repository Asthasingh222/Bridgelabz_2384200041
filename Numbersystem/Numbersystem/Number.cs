using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbersystem
{
    public class Number
    {
        int num;
        public Number(int x)
        {
            num = x;
        }
        public string EvenOdd()
        {
            if (num % 2 == 0) return "Even";
            else return "Odd";
        }
    }
}

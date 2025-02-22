using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NumberSystem2;
using System.Threading.Tasks;

namespace NumberSystem2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Number n1 =new Number(10);
            Console.WriteLine(n1.EvenOdd());
        }
    }
}

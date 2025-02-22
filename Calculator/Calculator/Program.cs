using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculatorcl c = new Calculatorcl();
            Console.WriteLine(c.Add(10, 20));
        }
    }
}

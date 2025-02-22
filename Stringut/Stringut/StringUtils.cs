using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringut
{
    public class StringUtils
    {
        public string Reverse(string str) => new string(str.Reverse().ToArray());

        public bool IsPalindrome(string str)
        {
            string reversed = Reverse(str);
            return string.Equals(str, reversed, StringComparison.OrdinalIgnoreCase);
        }

        public string ToUpperCase(string str) => str.ToUpper();
    }
}

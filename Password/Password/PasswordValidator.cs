using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Password
{
    public class PasswordValidator
    {
        public bool IsValid(string password)
        {
            if (password.Length < 8) return false;
            if (!Regex.IsMatch(password, "[A-Z]")) return false;
            if (!Regex.IsMatch(password, @"\d")) return false;
            return true;
        }
    }
}

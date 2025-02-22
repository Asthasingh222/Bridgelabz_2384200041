using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User
{
    public class UserRegistration
    {
        public void RegisterUser(string username, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(username)) throw new ArgumentException("Username cannot be empty");
            if (!Regex.IsMatch(email, @"^\S+@\S+\.\S+$")) throw new ArgumentException("Invalid email format");
            if (password.Length < 8) throw new ArgumentException("Password must be at least 8 characters long");
        }
    }
}

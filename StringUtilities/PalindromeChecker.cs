using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringUtilities
{
    public class PalindromeChecker
    {
        public static bool IsPalindrome(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return false;

            string backwordValue = new string(value.ToCharArray().Reverse().ToArray());

            return value.ToLower() == backwordValue.ToLower();
        }
    }
}

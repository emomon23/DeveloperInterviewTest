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
            string backwordValue = "";

            for (int i = 0; i < value.Length; i++)
            {
                backwordValue += value.Substring(i, 1);
            }

            return value == backwordValue;
        }
    }
}

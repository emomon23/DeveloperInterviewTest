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
            if (value.IsNotEmpty()) 
            {
                value = value.Trim();

                string backwordValue = "";

                for (int i = value.Length - 1; i >= 0; i--)
                {
                    backwordValue += value.Substring(i, 1).ToLower();
                }

                return value.ToLower() == backwordValue;
            }
            return false;
        }
    }
}

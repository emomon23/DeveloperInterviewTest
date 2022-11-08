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

			//if value null return false
			if (string.IsNullOrEmpty(value))
			{
				return false;
			}
			//use regex to remove all non alpha chars, spaces, etc.
			var rgx = new System.Text.RegularExpressions.Regex("[^a-zA-Z0-9 -]");
			string stripped = rgx.Replace(value, "").Trim().Replace(" ", "");

			//reverse the contents of 'value' and create char array to store
			var revArr = stripped.Reverse().ToArray();
			string deppirts = new string(revArr);

			//check if forward equals backward, if true then palindrome.
			return stripped.ToLower().Equals(deppirts.ToLower());
		}
    }
}

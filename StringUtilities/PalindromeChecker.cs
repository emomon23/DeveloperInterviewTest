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
            string noPunctuation = "";

            //output is the original string
            //for (int i = 0; i < value.Length; i++)
            //{
            //    backwordValue += value.Substring(i, 1);
            //}

            //Now returns the string in reverse
            if (value != null)
            {
                foreach (char letter in value)
                {
                    //Palindromes generally ignore spacing and punctuation
                    //Re-builds original string without spacing and punctuation while building the reversed string in the same way
                    if (letter == ',' || letter == '.' || letter == ' ' || letter == '\'' || letter == '\"' || letter == '?' || letter == '!' || letter == '\\') { }
                    else
                    {
                        noPunctuation = noPunctuation + letter;
                        backwordValue = letter + backwordValue;
                    }
                }
            }
            //Returns false if there is a null value. There needs to be a word to be a palindrome
            else
                return false;

            //Was case-sensitive, when design is not case-sensitive
            //return value == backwordValue;

            //No longer case sensitive
            //Accounts for null values, sets them as false
            return noPunctuation.ToUpper() == backwordValue.ToUpper();
        }
    }
}

using System;

namespace StringUtilities
{
    internal class Valid
    {
        internal static Boolean Word(string word)
        {
            if (!string.IsNullOrEmpty(word) && !string.IsNullOrWhiteSpace(word))
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
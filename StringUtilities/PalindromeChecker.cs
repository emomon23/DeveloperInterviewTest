namespace StringUtilities
{
    /// <summary>
    /// Abstract class that contains palindrome checker methods.
    /// </summary>
    public abstract class PalindromeChecker
    {
        /// <summary>
        /// Check if a given string is a palindrome. Upper and lower case letters are treated the same.
        /// Strings can contain whitespace, numbers, and special characters.
        /// If string is empty or null valued this function will return false.
        /// </summary>
        /// <param name="value">The string to check if it's a palindrome.</param>
        /// <returns>A value indicating if it's a palindrome.</returns>
        public static bool IsPalindrome(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }

            bool isPalindrome = true;
            for (int i = 0; i < value.Length / 2; i++)
            {
                // Check characters one at a time so if a mismatch occurs can break out of loop.
                // This improves efficiently.
                if (char.ToLower(value[i]) != char.ToLower(value[value.Length - 1 - i]))
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }
    }
}

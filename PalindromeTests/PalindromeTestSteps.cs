using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringUtilities;

namespace PalindromeTests
{
    /// <summary>
    /// Helper class for testing IsPalindrome()
    /// </summary>
    public class PalindromeTestSteps
    {
        private string wordToCheck;
        private bool isPalindrome;

        /// <summary>
        /// Sets the word to check.
        /// </summary>
        /// <param name="value">Sets the word to value.</param>
        public void GivenAValueOf(string value)
        {
            wordToCheck = value;
        }

        /// <summary>
        /// Calls IsPalindrome() on the stored word.
        /// </summary>
        public void WhenPalidromeCheckIsCalled()
        {
            isPalindrome = PalindromeChecker.IsPalindrome(wordToCheck);
        }

        /// <summary>
        /// Asserts that the result of IsPalindrome() is true.
        /// </summary>
        public void ThenItShouldBeAPalindrome()
        {
            Assert.IsTrue(isPalindrome, wordToCheck + " was not regarded as a palindrome as was expected");
        }

        /// <summary>
        /// Asserts that the result of IsPalindrome() is false.
        /// </summary>
        public void ThenItShouldNOTBeAPalindrome()
        {
            Assert.IsFalse(isPalindrome, wordToCheck + " was regarded as a palindrome, and it should not be");
        }
    }
}

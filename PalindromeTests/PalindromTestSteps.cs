using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringUtilities;

namespace PalindromeTests
{
    public class PalindromTestSteps
    {
        private string wordToCheck;
        private bool isPalindrome;

        public void GivenAValueOf(string value)
        {
            wordToCheck = value;
        }

        public void WhenPalidromeCheckIsCalled()
        {
            isPalindrome = PalindromeChecker.IsPalindrome(wordToCheck);
        }

        public void ThenItShouldBeAPalindrome()
        {
            Assert.IsTrue(isPalindrome, wordToCheck + " was not regarded as a palindrome as was expected");
        }

        public void ThenItShouldNOTBeAPalindrom()
        {
            Assert.IsFalse(isPalindrome, wordToCheck + " was is regarded as a palindrome, and it should not be");
        }
    }
}

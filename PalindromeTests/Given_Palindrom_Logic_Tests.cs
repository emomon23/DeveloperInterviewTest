using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PalindromeTests
{
    /* On the menu bar above:  Select TEST -> Run -> All Tests
     * If the Test Explorer doesn't display, select TEST -> Windows -> TestExplorer
     * 
     * Two of these tests pass and two of them fail.
     * Get all of the tests passing in this code
     * Write additional tests based on what you learned fixing this code
     * Write any additional tests you can think of to increase code coverage
     */

    [TestClass]
    public class Given_Palindrom_Logic_Tests
    {
        private PalindromTestSteps steps;

        [TestInitialize]
        public void Initialize()
        {
            steps = new PalindromTestSteps();
        }

        [TestMethod]
        public void When_Word_Is_MOM_Result_Should_Be_True()
        {
            steps.GivenAValueOf("MOM");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldBeAPalindrome();
        }

        [TestMethod]
        public void When_Word_Is_Something_Result_Should_Be_False()
        {
            steps.GivenAValueOf("Something");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldNOTBeAPalindrom();
        }

        [TestMethod]
        public void When_Word_Is_Dad_Result_Should_Be_True()
        {
            steps.GivenAValueOf("Dad");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldBeAPalindrome();
        }

        [TestMethod]
        public void When_Word_Is_SOME_REALLY_LONG_STRING_Not_A_Palindrome_Result_Should_Be_False()
        {
            //Added really long string instead of null string
            string someReallyLongString = "Once upon a time, there was a gigantic dragon";

            steps.GivenAValueOf(someReallyLongString);
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldNOTBeAPalindrom();
        }

        //Added to cover for null strings
        [TestMethod]
        public void When_Word_Is_Null_Result_Should_Be_False()
        {
            string nullString = null;
            steps.GivenAValueOf(nullString);
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldNOTBeAPalindrom();
        }

        [TestMethod]
        public void When_Word_Is_Palindrome_With_Spacing_And_Punctuation_Result_Should_Be_False()
        {
            string punctuationPalindrome = "\"Slang is not suet, is it?\" Euston signals.";
            steps.GivenAValueOf(punctuationPalindrome);
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldBeAPalindrome();
        }
    }
}

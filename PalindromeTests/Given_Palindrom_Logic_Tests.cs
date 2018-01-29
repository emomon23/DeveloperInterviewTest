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
            string someReallyLongString = "This is deffinatly not a plaindrome: so there :-p";

            steps.GivenAValueOf(someReallyLongString);
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldNOTBeAPalindrom();
        }

        [TestMethod]
        public void When_Word_Has_Leading_White_Space_But_Is_A_Palindrome_Result_Should_Be_True()
        {
            steps.GivenAValueOf("    RACECAR");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldBeAPalindrome();
        }

        [TestMethod]
        public void When_Word_Has_Trailing_White_Space_But_Is_A_Palindrome_Result_Should_Be_True()
        {
            steps.GivenAValueOf("RACECAR      ");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldBeAPalindrome();
        }

        [TestMethod]
        public void When_Word_Has_Leading_White_Space_But_Is_Not_A_Palindrome_Result_Should_Be_False()
        {
            steps.GivenAValueOf("    RACER");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldNOTBeAPalindrom();
        }

        [TestMethod]
        public void When_Word_Has_Trailing_White_Space_But_Is_Not_A_Palindrome_Result_Should_Be_False()
        {
            steps.GivenAValueOf("RACER      ");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldNOTBeAPalindrom();
        }

        [TestMethod]
        public void When_Word_Is_Empyty_It_Is_Not_A_Palindrome_Result_Should_Be_False()
        {
            steps.GivenAValueOf("");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldNOTBeAPalindrom();
        }

        [TestMethod]
        public void When_Word_Is_Whitespace_It_Is_Not_A_Palindrome_Result_Should_Be_False()
        {
            steps.GivenAValueOf(" ");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldNOTBeAPalindrom();
        }

        [TestMethod]
        public void A_Palindrome_Can_Be_Multiple_Words_Result_Should_Be_True()
        {
            steps.GivenAValueOf("Able was I ere I saw Elba");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldBeAPalindrome();
        }

        [TestMethod]
        public void Multi_Word_Palindromes_Are_Not_Affected_By_Trailing_or_Leading_Whitespace_Result_Should_Be_True()
        {
            steps.GivenAValueOf("     Able was I ere I saw Elba   ");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldBeAPalindrome();
        }

        [TestMethod]
        public void A_Single_Letter_Word_Is_A_Palindrome_For_This_test_Result_Should_Be_True()
        {
            steps.GivenAValueOf("a");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldBeAPalindrome();
        }
    }
}

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
            string someReallyLongString = "ThisIsSomeReallyLongStringThatNobodyWouldEverUse";

            steps.GivenAValueOf(someReallyLongString);
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldNOTBeAPalindrom();
        }

        [TestMethod]
        public void When_Word_Is_RaCeCaR_Result_Should_Be_True()
        {
            steps.GivenAValueOf("RaCeCaR");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldBeAPalindrome();
        }

        [TestMethod]
        public void When_Word_Is_Random_Characters_Result_Should_Be_False()
        {
            steps.GivenAValueOf("$%&*#$&%");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldNOTBeAPalindrom();
        }

        [TestMethod]
        public void When_Word_Is_Empty_String_Result_Should_Be_True()
        {
            steps.GivenAValueOf(string.Empty);
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldBeAPalindrome();
        }

        [TestMethod]
        public void When_Word_Is_Single_Character_Result_Should_Be_True()
        {
            steps.GivenAValueOf("R");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldBeAPalindrome();
        }

        [TestMethod]
        public void When_Word_Is_Null_Result_Should_Be_False()
        {
            steps.GivenAValueOf(null);
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldNOTBeAPalindrom();
        }

        [TestMethod]
        public void When_Word_Is_Palindrome_With_Special_Characters_Result_Should_Be_True()
        {
            steps.GivenAValueOf("**PaaP**");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldBeAPalindrome();
        }

        [TestMethod]
        public void When_Word_Is_Palindrome_In_Number_Form_Result_Should_Be_True()
        {
            steps.GivenAValueOf("1117777111");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldBeAPalindrome();
        }

        [TestMethod]
        public void When_Word_Is_Palindrome_With_Whitespace_Result_Should_Be_True()
        {
            steps.GivenAValueOf("KooK KOOK kook");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldBeAPalindrome();
        }
    }
}

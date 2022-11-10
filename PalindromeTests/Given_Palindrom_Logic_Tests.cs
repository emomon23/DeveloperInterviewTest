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


        // Test: short palindrome.
        [TestMethod]
        public void When_Word_Is_MOM_Result_Should_Be_True()
        {
            steps.GivenAValueOf("MOM");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldBeAPalindrome();
        }

        // Test: non palindrome.
        [TestMethod]
        public void When_Word_Is_Something_Result_Should_Be_False()
        {
            steps.GivenAValueOf("Something");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldNOTBeAPalindrome();
        }

        // Test: palindrome with uppercase and lowercase.
        [TestMethod]
        public void When_Word_Is_Dad_Result_Should_Be_True()
        {
            steps.GivenAValueOf("Dad");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldBeAPalindrome();
        }

        // Test: a long string.
        [TestMethod]
        public void When_Word_Is_SOME_REALLY_LONG_STRING_Not_A_Palindrome_Result_Should_Be_False()
        {
            string someReallyLongString = "SOMEREALLYLONGSTRINGNotAPalindrome";

            steps.GivenAValueOf(someReallyLongString);
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldNOTBeAPalindrome();
        }

        // Test:  a null value shoud return false.
        [TestMethod]
        public void When_Word_Is_NULL_Result_Should_Be_False()
        {
            steps.GivenAValueOf(null);
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldNOTBeAPalindrome();
        }

        //Test: an empty string should return false.
        [TestMethod]
        public void When_Word_Is_EMPTY_Result_Should_Be_False()
        {
            steps.GivenAValueOf(string.Empty);
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldNOTBeAPalindrome();
        }

        //Test: a one letter word should return true.
        [TestMethod]
        public void When_Word_Is_One_Character_Palindrome_Result_Should_Be_True()
        {
            steps.GivenAValueOf("A");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldBeAPalindrome();
        }

        // Test: palindrome with spaces return true.
        [TestMethod]
        public void When_Word_Is_Palindrome_With_Spaces_Result_Should_Be_True()
        {
            steps.GivenAValueOf("Hedi Essid disse ideh");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldBeAPalindrome();
        }

        // Test: palindrome with Special Charcateres.
        [TestMethod]
        public void When_Word_Is_Palindrome_OF_Special_Characteres_Result_Should_Be_True()
        {
            steps.GivenAValueOf("!*@*!");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldBeAPalindrome();
        }


    }
}

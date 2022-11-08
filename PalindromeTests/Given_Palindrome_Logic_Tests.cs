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
    public class Given_Palindrome_Logic_Tests
    {
        private PalindromeTestSteps steps;

        /// <summary>
        /// Setup for Given_Palindrome_Logic_Tests
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            steps = new PalindromeTestSteps();
        }
        
        /// <summary>
        /// Test that a short palindrome is checked properly.
        /// </summary>
        [TestMethod]
        public void When_Word_Is_MOM_Result_Should_Be_True()
        {
            steps.GivenAValueOf("MOM");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldBeAPalindrome();
        }

        /// <summary>
        /// Test that a non palindrome is checked properly.
        /// </summary>
        [TestMethod]
        public void When_Word_Is_Something_Result_Should_Be_False()
        {
            steps.GivenAValueOf("Something");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldNOTBeAPalindrome();
        }

        /// <summary>
        /// Test that a palindrome with upper and lower case is checked properly.
        /// </summary>
        [TestMethod]
        public void When_Word_Is_Dad_Result_Should_Be_True()
        {
            steps.GivenAValueOf("Dad");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldBeAPalindrome();
        }

        /// <summary>
        /// Test that a long word is checked properly.
        /// </summary>
        [TestMethod]
        public void When_Word_Is_SOME_REALLY_LONG_STRING_Not_A_Palindrome_Result_Should_Be_False()
        {
            string someReallyLongString = "someReallyLongString";

            steps.GivenAValueOf(someReallyLongString);
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldNOTBeAPalindrome();
        }

        /// <summary>
        /// Test that a null valued string returns false.
        /// </summary>
        [TestMethod]
        public void When_Word_Is_NULL_Result_Should_Be_False()
        {
            steps.GivenAValueOf(null);
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldNOTBeAPalindrome();
        }

        /// <summary>
        /// Test that an empty string returns false.
        /// </summary>
        [TestMethod]
        public void When_Word_Is_EMPTY_Result_Should_Be_False()
        {
            steps.GivenAValueOf(string.Empty);
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldNOTBeAPalindrome();
        }

        /// <summary>
        /// Test that a single lettered word returns true.
        /// </summary>
        [TestMethod]
        public void When_Word_Is_Single_Character_Palindrome_Result_Should_Be_True()
        {
            steps.GivenAValueOf("A");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldBeAPalindrome();
        }
        
        /// <summary>
        /// Test that a long palindrome is checked properly.
        /// </summary>
        [TestMethod]
        public void When_Word_Is_LONG_Palindrome_Result_Should_Be_True()
        {
            steps.GivenAValueOf("SaipPuakivIkaUppiAs");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldBeAPalindrome();
        }

        /// <summary>
        /// Test that a palindrome with spaces is checked properly.
        /// </summary>
        [TestMethod]
        public void When_Word_Is_Palindrome_With_Spaces_Result_Should_Be_True()
        {
            steps.GivenAValueOf("sa ippua kivik auppi as");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldBeAPalindrome();
        }

        /// <summary>
        /// Test that a palindrome of numbers is checked properly.
        /// </summary>
        [TestMethod]
        public void When_Word_Is_Palindrome_Of_Numbers_Result_Should_Be_True()
        {
            steps.GivenAValueOf("123454321");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldBeAPalindrome();
        }

        /// <summary>
        /// Test that a word of numbers is checked properly.
        /// </summary>
        [TestMethod]
        public void When_Word_Is_Made_Of_Numbers_Result_Should_Be_False()
        {
            steps.GivenAValueOf("123456789");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldNOTBeAPalindrome();
        }

        /// <summary>
        /// Test that a palindrome of special characters is checked properly.
        /// </summary>
        [TestMethod]
        public void When_Word_Is_Palindrome_Of_Special_Characters_Result_Should_Be_True()
        {
            steps.GivenAValueOf("!@#$%%$#@!");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldBeAPalindrome();
        }

        /// <summary>
        /// Test that a word of special characters is checked properly.
        /// </summary>
        [TestMethod]
        public void When_Word_Is_Made_Of_Special_Characters_Result_Should_Be_False()
        {
            steps.GivenAValueOf("!@#$%^&*()");
            steps.WhenPalidromeCheckIsCalled();
            steps.ThenItShouldNOTBeAPalindrome();
        }
    }
}

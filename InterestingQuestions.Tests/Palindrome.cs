using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palimdrome;

namespace InterestingQuestions.Tests
{
    [TestClass]
    public class PalindromeTest
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), noExceptionMessage: "A null value for the array to be tested was allowed.")]
        [DataRow(data1: null)]
        public void IsAPalindrome_NullArgument_Exception(char[] value)
        {
            // Arrange
            var v = value;

            // Action
            Palindrome.IsAPalindrome(v);

            // Assert
        }

        [DataTestMethod]
        [DataRow(data1: new char[] { 'm', 'o', 'm' })]
        [DataRow(data1: new char[] { 'Y', 'a', 'n', 'a', 'y' })]
        public void IsAPalindrome_EvenAndOddArraysLength_True(char[] value)
        {
            // Arrange
            var v = value;

            // Action
            var result = Palindrome.IsAPalindrome(v);

            // Assert
            Assert.IsTrue(result);
        }

        [DataTestMethod]
        [DataRow(data1: new char[] { 'O', 'n', 'e' })]
        [DataRow(data1: new char[] { 'M', 'o', 'm', 'm', 'y' })]
        public void IsAPalindrome_EventAndOddArrays_False(char[] value)
        {
            // Arrange
            var v = value;

            // Action
            var result = Palindrome.IsAPalindrome(v);
            
            // Assert
            Assert.IsFalse(result);
        }
    }
}

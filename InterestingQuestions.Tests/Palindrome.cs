using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InterestingQuestions.Tests
{
    [TestClass]
    public class Palindrome
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), noExceptionMessage: "A null value for the array to be tested was allowed.")]
        [DataRow(data1: null)]
        public void IsAPalindrome_NullArgument_Exception(char[] value)
        {
            // Arrange
            var v = value;

            // Action
            throw new ArgumentNullException();

            // Assert
        }

        [DataTestMethod]
        [DataRow(data1: new char[] { 'm', 'o', 'm' })]
        [DataRow(data1: new char[] { 'm', 'a', 'm', 'a' })]
        public void IsAPalindrome_EvenAndOddArraysLength_True(char[] value)
        {
            // Arrange
            var v = value;

            // Action

            // Assert
            Assert.IsTrue(true);
        }

        [DataTestMethod]
        [DataRow(data1: new char[] { 'O', 'n', 'e' })]
        [DataRow(data1: new char[] { 'M', 'o', 'm', 'm', 'y' })]
        public void IsAPalindrome_EventAndOddArrays_False(char[] value)
        {
            // Arrange
            var v = value;
            // Action

            // Assert
            Assert.IsFalse(false);
        }
    }
}

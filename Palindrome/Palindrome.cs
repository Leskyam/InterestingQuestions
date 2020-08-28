using System;
using System.Collections.Generic;
using System.Text;

namespace InterestingQuestions
{
    public static class Palindrome
    {
        /// <summary>
        /// Asses if the array of values passed as argument of <paramref name="sequence"/> is a "palindrome", 
        /// a sequence of characters that are read, forward and backward, in the same way.
        /// </summary>
        /// <param name="sequence"></param>
        /// <returns></returns>
        public static bool IsAPalindrome(char[] sequence)
        {
            if (object.Equals(sequence, null)) { throw new ArgumentNullException($"The argument \"{nameof(sequence)}\" cannot be null."); }

            // We only need to iterate through the first half, or half + "1", if the length is an odd number.
            var limit = (int)Math.Round((double)sequence.Length / 2, 0, MidpointRounding.AwayFromZero);
            for (int i = sequence.GetLowerBound(0); i < limit; i++)
            {
                if (string.Compare(sequence[i].ToString(), sequence[sequence.GetUpperBound(0) - i].ToString(), true) != 0) return false;
            }
            return true;
        }
    }
}

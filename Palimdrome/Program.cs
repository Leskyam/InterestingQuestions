using System;

namespace Palimdrome
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Palindrome.IsAPalindrome(null);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
            }

            var msgTemp = "Is the word \"{0}\" a palindrome? {1}";

            var sequence = new char[] { 'y', 'a', 'n', 'a', 'y' };
            Console.WriteLine(string.Format(msgTemp, string.Join("", sequence), Palindrome.IsAPalindrome(sequence)));

            sequence = new char[] { 'D', 'y', 'l', 'a', 'n' };
            Console.WriteLine(string.Format(msgTemp, string.Join("", sequence), Palindrome.IsAPalindrome(sequence)));

            var words = new string[] { "Dad", "nose", "eye", "hair", "Madam" };
            foreach (var word in words)
            {
                Console.WriteLine(string.Format(msgTemp, word, Palindrome.IsAPalindrome(word.ToCharArray())));
            }

        }
    }
}

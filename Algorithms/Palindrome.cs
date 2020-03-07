using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmCodingChallenge.Algorithms
{
    class Palindrome
    {
        public void fourteen()
        {
            string testWord = "";
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            int n = word.Length;
            char[] t = word.ToCharArray();
            for(var i=n-1; i>=0; i--)
            {
                testWord += t[i];
            }
            if (testWord == word)
                Console.WriteLine("{0} is a palindrome", word);
            else
                Console.WriteLine("{0} is not a palindrome", word);
            Console.WriteLine("\n");
        }
    }
}

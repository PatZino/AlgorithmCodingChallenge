using System;
using AlgorithmCodingChallenge;

namespace AlgorithmCodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method Selection\n" +
                "1 - Basic (Hello World and Greeting)\n" +
                "2 - Summation\n" +
                "3 - Multiplication table\n" +
                "4 - Prime numbers\n" +
                "5 - Maximum Number in a list\n" +
                "6 - Reverse a list\n" +
                "7 - Check if an element exists in a list\n" +
                "8 - return items at odd indexes in a list\n" +
                "9 - Running total\n" +
                "10- Palindrome\n" +
                "11- Sum in a list using different method\n" +
                "12- Concatenate two list");

            Console.WriteLine("\n");

            for (int j=1; j<=5; j++)
            {
                Console.Write("Select a method to run: ");
                int num;
                if (int.TryParse(Console.ReadLine(), out num)){
                    Selection display = new Selection();
                    display.select(num);
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("Invalid Input - Enter a number");
                    Console.WriteLine("\n");
                }
                                              
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmCodingChallenge.Algorithms
{
    class summation
    {
      public void four()
      {
            int sum = 0;
            Console.WriteLine("This alogorithm gives you the sum of numbers from 1 to n");
            Console.Write("Enter a value for n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(var i=1; i<=n; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum of 1 to n: " + sum);
            Console.WriteLine("\n");
      }

        public void five()
        {
            int sum = 0;
            Console.WriteLine("This alogorithm gives you the sum of the multiples of 3 and 5 from 1 to n");
            Console.Write("Enter a value for n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (var i = 1; i <= n; i++)
            {
                if ((i%3==0) || (i%5==0))
                {
                    sum += i;
                }
               
            }
            Console.WriteLine("Sum of multiples of 3 and 5 from 1 to n: " + sum);
            Console.WriteLine("\n");
        }

        public void six()
        {
            int sum = 0;
            Console.WriteLine("Select an option: \n" +
                "1 - Summation of 1 - n \n" +
                "2 - product of 1 - n");
            Console.WriteLine("\n");
            Console.Write("Your option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a value for n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    for (var i = 1; i <= n; i++)
                    {                       
                        sum += i;                     
                    }
                    Console.WriteLine("Sum of numbers from 1 to n: " + sum);
                    Console.WriteLine("\n");
                    break;
                case 2:
                    sum = 1;
                    for (var i = 1; i <= n; i++)
                    {
                        sum *= i;
                    }
                    Console.WriteLine("Product of numbers from 1 to n: " + sum);
                    Console.WriteLine("\n");
                    break;
                default:
                    Console.WriteLine("Choose a valid option");
                    break;
            }
            
        }
    }
}

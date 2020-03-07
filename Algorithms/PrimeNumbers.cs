using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmCodingChallenge.Algorithms
{
    class PrimeNumbers
    {
       
        public void eight()
        {
            Console.WriteLine("B: Print all prime numbers up to a desired number\n");
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (n <= 1)
            {
                Console.WriteLine("Enter a number greater than 1");
                eight();
            }
            else if (n == 2)
                Console.Write("Prime number of 2: " + (2).ToString());
            else
            {
                Console.WriteLine("prime numbers up to {0}", n);
                List<int> list = new List<int>();
                Console.Write((2).ToString() + "\t");
                for (var i = 3; i <= n; i+=2)
                {
                    for (var j = 2; j < (i/2); j++)
                    {
                        int num = i % j;
                        list.Add(num);
                    }
                    if (!list.Contains(0))
                        Console.Write((i).ToString() + "\t");

                    list = new List<int>();
                }
            }
            Console.WriteLine("\n");
        }


    }
}

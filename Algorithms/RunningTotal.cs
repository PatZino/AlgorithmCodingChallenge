using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmCodingChallenge.Algorithms
{
    class RunningTotal
    {
        public void thirteen()
        {
            int sum = 0;
            List<int> aList = new List<int> { 1, 2, 3, 4, 5, 6 };
            Console.Write("List: ");
            foreach (var j in aList)
                Console.Write((j) + " ");
            Console.WriteLine("\n");
            Console.WriteLine("Running Total\n");
            foreach (var a in aList)
            {
                sum += a;
                Console.Write(sum + "\t");
            }
            Console.WriteLine("\n");
        }
    }
}

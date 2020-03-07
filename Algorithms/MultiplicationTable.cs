using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmCodingChallenge.Algorithms
{
    class MultiplicationTable
    {
        public void seven()
        {
            Console.WriteLine("Multiplication table");
            Console.WriteLine("\n");
            for(var i=1; i<=12; i++)
            {
                for (var j = 1; j <= 12; j++)
                {
                    Console.Write((i * j).ToString() + "\t");                   
                }
                Console.WriteLine();
            }
        
        }
    }
}

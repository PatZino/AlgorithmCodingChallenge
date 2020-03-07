using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmCodingChallenge.Algorithms
{
    class ReturnItemsOddPos
    {
        public void twelve()
        {
            Console.Write("Enter the number of items in the list: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<string> aList = new List<string>();
            for (var i = 1; i <= n; i++)
            {
                Console.Write("Enter element: ");
                string element = Console.ReadLine();
                aList.Add(element);
            }
            Console.Write("List: ");
            foreach (var j in aList)
                Console.Write((j) + " ");
            Console.WriteLine();
            Console.Write("Print items in odd indexes in the list: ");
            for (var i = 0; i < n; i++)
                if (i % 2 == 0)
                    Console.Write(aList[i] + "\t");
            Console.WriteLine("\n");
        }
    }
}

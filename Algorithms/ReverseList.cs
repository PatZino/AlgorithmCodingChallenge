using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmCodingChallenge.Algorithms
{
    class ReverseList
    {
        public void ten()
        {
            Console.Write("Enter the number of items in the list: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<string> aList = new List<string>();
            List<string> bList = new List<string>();
            for (var i = 1; i <= n; i++)
            {
                Console.Write("Enter elements: ");
                string nums = Console.ReadLine();
                aList.Add(nums);
            }
            Console.Write("List: ");
            foreach (var j in aList)
                Console.Write((j) + " ");
            Console.WriteLine();
            for (var j = n-1; j >= 0; j--)                           
                bList.Add(aList[j]);
            Console.Write("Reversed List: ");
            foreach (var k in bList)
                Console.Write((k) + " ");
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmCodingChallenge.Algorithms
{
    class ContainsElement
    {
        public void eleven()
        {
            int count = 0;
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
            Console.Write("Enter item to see if it\'s exist in the list: ");
            string item = Console.ReadLine();
            foreach (var a in aList)
                if (a == item)
                    count += 1;
            if (count != 0)
                Console.WriteLine("{0} exist in the list", item);
            else
                Console.WriteLine("{0} does not exist in the list", item);
            Console.WriteLine();
        }
    }
}

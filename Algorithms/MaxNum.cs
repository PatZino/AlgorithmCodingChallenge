using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmCodingChallenge.Algorithms
{
    class MaxNum
    {
        public void nine()
        {
           
            Console.Write("Enter the number of items in the list: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> aList = new List<int> ();
            for (var i = 1; i <= n; i++)
            {
                Console.Write("Enter number: ");
                int nums = Convert.ToInt32(Console.ReadLine());
                aList.Add(nums);
            }
            Console.Write("List: ");
            foreach (var j in aList)
                Console.Write((j).ToString() + ",");
            if (aList.Count == 0) { 
                Console.WriteLine("This is an empty list\n");                
            }
            else
            {
                int maxi = aList[0];
                Console.WriteLine();
                foreach (var num in aList)
                    if (num > maxi)
                        maxi = num;
                Console.WriteLine("The maximum number is: " + maxi);
            }
            
            Console.WriteLine();
        }
    }
}

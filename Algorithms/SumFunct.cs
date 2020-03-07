using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmCodingChallenge.Algorithms
{
    class SumFunct
    {
        public List<int> aList = new List<int> { 1, 2, 3, 4, 5, 6 };
        public int sum = 0;
        public void fifteenA()
        {
            int sum = 0;
            int n = aList.Count;
            Console.Write("\nList: ");
            foreach (var j in aList)
                Console.Write((j) + " ");
            Console.WriteLine("\n");
            Console.WriteLine("Sum using For loop");
            for (var i = 0; i<n; i++)
            {
                sum += aList[i];
            }
            Console.WriteLine("Sum = {0}\n", sum);
        }

        public void fifteenB()
        {
            int sum = 0;
            int i = 0;
            int n = aList.Count;
            Console.WriteLine("Sum using while loop");
            while (i < n)
            {
                sum += aList[i];
                i++;
            }
            Console.WriteLine("Sum = {0}\n", sum);
        }

        public void fifteenC()
        {
            int n = aList.Count;
            Console.WriteLine("Sum using recursion");
            foreach (var i in aList)
                addNum(i);
            Console.WriteLine("Sum = {0}\n", sum);
        }

        public int addNum(int num)
        {
            sum += num;
            return sum;
        }
    }
}

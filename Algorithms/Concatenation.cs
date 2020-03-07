using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmCodingChallenge.Algorithms
{
    class Concatenation
    {
        
        
        public void display()
        {
            List<string> aList = new List<string> { "a", "b", "c" };
            List<string> bList = new List<string> { "1", "2", "3" };
            Console.Write("\nFirst List: ");
            foreach (var i in aList)
            {
                Console.Write(i);
            }
            Console.Write("\nSecond list: ");
            foreach (var i in bList)
            {
                Console.Write(i);
            }
        }

        public void seventeen()
        {
            List<string> aList = new List<string> { "a", "b", "c" };
            List<string> bList = new List<string> { "1", "2", "3" };
            foreach (var i in bList)
            {
                aList.Add(i);
            }
            Console.Write("\nConcatenated list: ");
            foreach (var i in aList)
            {
                Console.Write(i);
            }
        }

        public void nineteen()
        {
            List<string> aList = new List<string> { "a", "b", "c" };
            List<string> bList = new List<string> { "1", "2", "3"};
            List<string> result = new List<string>();
            if(aList.Count == bList.Count)
            {          
                int n = aList.Count;
                Console.Write("\nAlternate Concatenated list: ");
                for(var i=0; i<n; i++)
                {
                    result.Add(aList[i]);
                    result.Add(bList[i]);
                }
                foreach (var i in result)
                {
                    Console.Write(i);
                }
            }
            else
                Console.Write("\nList length doesn't match");
        }


    }
}

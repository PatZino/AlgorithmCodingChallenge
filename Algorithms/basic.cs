using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmCodingChallenge.Algorithms
{

    public class basic
    {
        public void one()
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("\n");
        }

        public void two()
        {
            // Type your name
            Console.Write("Enter username: ");
            // Accepts userName
            string userName = Console.ReadLine();
            // Greets the user
            Console.WriteLine("Hello " + userName);
            Console.WriteLine("\n");
        }

        public void three()
        {
            string name1 = "Alice";
            string name2 = "Bob";
            Console.Write("Enter a name, only Alice and Bob will be greeted: ");
            string userName = Console.ReadLine();
            if (userName == name1 || userName == name2)
            {
                Console.WriteLine("Hello " + userName);
            }
            else
            {
                Console.WriteLine("Sorry "+ userName +", Only Alice and Bob will be greeted");
            }
            Console.WriteLine("\n");
        }

    }

}

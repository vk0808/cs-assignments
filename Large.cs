using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Problems
{
    class Large
    {
        public static void FindLarge()
        {
            Console.WriteLine("Finding large of 3 numbers");
            Console.WriteLine("Enter number a");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number b");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number c");
            int c = int.Parse(Console.ReadLine());

            if (a >= b && a >= c)
            {
                Console.WriteLine(a + " is greater");
            }
            else if (b >= c && b >= a)
            {
                Console.WriteLine(b + " is greater");
            }
            else
            {
                Console.WriteLine(c + " is greater");
            }
        }
    }
}

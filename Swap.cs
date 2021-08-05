using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Problems
{
    class Swap
    {
        public static void SwapNumbers()
        {
            int a, b, temp;

            Console.WriteLine("Swapping 2 numbers\n");
            Console.WriteLine("Enter number 1");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 2");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("a = " + a + " b = " + b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a = " + a + " b = " + b);
        }
    }
}

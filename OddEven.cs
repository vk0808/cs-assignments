using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Problems
{
    class OddEven
    {
        public static void FindOddEven()
        {
            Console.WriteLine("Check number is odd or even\n");
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }
}

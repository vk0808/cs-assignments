using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Problems
{
    class Quotient
    {
        static void FindQuotientRemainder(int a, int b)
        {
            Console.WriteLine("Quotient: " + (a / b));
            Console.WriteLine("Remainder: " + (a % b));
        }

        public static void FindQuoRem()
        {
            Console.WriteLine("Finding Quotient and Remainder\n");
            Console.WriteLine("Enter divisor");
            int divisor = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter dividend");
            int dividend = int.Parse(Console.ReadLine());

            FindQuotientRemainder(divisor, dividend);
        }
    }
}

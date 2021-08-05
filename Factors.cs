using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Problems
{
    class Factors
    {
        public static void FindPrimeFactors()
        {
            Console.WriteLine("Finding prime factors\n");
            int num = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Prime factors of " + num);
            for (int i = 2; i*i <= num; i++)
            {
                while (num % i == 0)
                {
                    num /= i;
                    Console.WriteLine(i);
                }
            }

            if (num >= 2)
            {
                Console.WriteLine(num);
            }
        }
    }
}

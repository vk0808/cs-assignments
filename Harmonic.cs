using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Problems
{
    class Harmonic
    {
        public static void FindHarmonic()
        {
            Console.WriteLine("Finding Harmonic Mean\n");
            int num = 0;
            double harmonic = 1;

            while (num <= 0)
            {
                Console.WriteLine("Enter number greater than 0");
                num = int.Parse(Console.ReadLine());
            }

            for (double i = 2; i <= num; i++)
            {
                harmonic += (1 / i);
            }
            Console.WriteLine("\nHarmonic Mean of " + num + " : " + harmonic);
        }
    }
}

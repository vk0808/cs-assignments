using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Problems
{
    class Power
    {
        public static void FindPower()
        {
            Console.WriteLine("Finding power of 2\n");
            int num = -1;
            int power = 1;

            while (num < 0 || num > 30)
            {
                Console.WriteLine("Enter number between 0-30");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nPowers of 2 from 2^0 till 2^" + num);
            Console.WriteLine(1);
            
            for (int x = 1; x <= num; x++)
            {
                power *= 2;
                Console.WriteLine(power);
            }
        }

    }
}

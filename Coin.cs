using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Problems
{
    class Coin
    {
        static double FindPercent(int n)
        {
            Random rand = new Random();
            double headCount = 0;
            int HEAD = 1;

            for (int flip = 0; flip < n; flip++)
            {
                int face = rand.Next(0, 2);
                if (face == HEAD)
                {
                    Console.WriteLine("head");
                    headCount++;
                }
                else
                {
                    Console.WriteLine("tails");
                }
            }

            return (headCount / n) * 100;
        }
        public static void Flip()
        {
            Console.WriteLine("Flip Coin and print percentages\n");
            int num = 0;

            // Check if number is 
            while (num <= 0)
            {
                Console.WriteLine("Enter a positive number to flip a coin");
                num = int.Parse(Console.ReadLine());
            }

            double percent = FindPercent(num);
            Console.WriteLine("\nHead percentage: " + percent);
            Console.WriteLine("Tail percentage: " + (100 - percent));
        }
    }
}

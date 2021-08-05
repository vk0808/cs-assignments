using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Problems
{
    class Year
    {
        public static void FindLeapYear()
        {
            Console.WriteLine("Finding leap year\n");
            int year = 1;

            while (year < 1000 || year > 10000)
            {
                Console.WriteLine("Enter year in 4 digits");
                year = int.Parse(Console.ReadLine());
            }

            int a = year % 4;
            int b = year % 100;
            int c = year % 400;

            if ( a == 0 && b != 0 || c == 0 )
            {
                Console.WriteLine(year + " is a leap year");
            }
            else
            {
                Console.WriteLine(year + " is a not leap year");
            }
        }
    }
}

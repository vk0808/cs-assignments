using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Problems
{
    class Vowels
    {
        public static void FindVowels()
        {
            Console.WriteLine("Program to check vowel or consonant\n");
            Console.WriteLine("Enter an alphabet");
            string str = Console.ReadLine().ToLower();

            if (str == "a" || str == "e" || str == "i" || str == "o" || str == "u")
            {
                Console.WriteLine("It's an Vowel");
            }
            else
            {
                Console.WriteLine("It's a Consonant");
            }
        }
    }
}

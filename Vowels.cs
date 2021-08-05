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
            char ch = char.Parse(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
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

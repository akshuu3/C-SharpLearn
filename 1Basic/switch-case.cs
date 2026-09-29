using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.Basic
{
    internal class switch_case
    {
        static void Main()
        {
            //Program: 1 Example of switch-case statement in C#
            int num = 5;
            switch (num % 2)
            {
                case 0:
                    Console.WriteLine("Even");
                    break;
                default:
                    Console.WriteLine("Odd");
                    break;
            }

            //Program: 2 Example of switch-case statement in C#
            char ch = 'a';
            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Consonant");
                    break;
            }

            //Program: 3 Example of switch-case statement in C#

            int a = 5, b = 10;
            switch(a > b)
            {
                case true:
                    Console.WriteLine("a is greater than b");
                    break;
                case false:
                    Console.WriteLine("a is less than or equal to b");
                    break;
            }
        }
    }
}

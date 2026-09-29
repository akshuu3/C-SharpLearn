using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.Basic
{
    internal class forLoop
    {
        static void Main()
        {
            //program 1 : Write a program to move from step 1 to step 10 and step 10 to step 1?
            Console.WriteLine("For Loop Step Increment");
            for(int step=1; step<=10; step++)
            {
                Console.WriteLine("Step Is " + step);
            }
            Console.WriteLine("For Loop Step Decrement");
            for (int step = 10; step >= 1; step--)
            {
                Console.WriteLine("Step Is " + step);
            }

            //program 2 : Write a program to print table of any entered number?
            int num = 23;
            for(int step1=1; step1<=10; step1++)
            {
                Console.WriteLine(num * step1);
            }

            //Program 3: Write a Program to Calculate Factorial ?
            int num1 = 7;
            int r = 1;
            for (int step1 = num1; step1 >= 1; step1--)
            {
                r = r * step1;
            }
            Console.WriteLine("Factorial of " + num1 + " is: " + r);


            //While Lopp 
            //Program 1: Reverse Number 

            int num2 = 1236781;
            string str2 = "";
            while(num2 != 0)
            {
                str2 = str2 + num2 % 10;
                num2 = num2 / 10;
            }
            Console.WriteLine("Reverse Is:" + str2);


            //Do While 
            //Program 1 

            int i1 = 100;
            do
            {
                Console.WriteLine(i1);
                i1++;
            } while (i1 > 200);


            //New

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 6 - i; j++)
                {
                    if (i % 2 != 0)
                        Console.Write(j);
                    else
                        Console.Write(6 - j);
                }

                Console.WriteLine();
            }

            //New

            for (int i = 1; i <= 5; i++)
            {
                char ch = 'A';

                for (int j = 1; j <= 6 - i; j++)
                {
                    Console.Write(ch++);
                }

                Console.WriteLine();
            }

            //Continue Break 

            //Program1: Skip Number

            for (int i = 1; i <= 10; i++)
            {
                if (i == 5 || i == 7)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}

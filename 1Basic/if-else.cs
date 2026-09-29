using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.Basic
{
    internal class if_else
    {
        static void Main()
        {
            //Program 1 If -Else Statement
            //Write a program to check whether the number is even or odd.
            int num1 = 10;
            string result1 = "Odd";
            if (num1 % 2 == 0)
            {
                result1 = "Even";
            }
            Console.WriteLine(result1);

            //Program 2 If -Else Statement
            //Write a program to find the square of a number if it is even, and the cube of a number if it is odd.
            int num2 = 4;
            int result2 = 0;
            if (num2 % 2 == 0)
            {
                result2 = num2 * num2;
                Console.WriteLine("Square: " + result2);
            }
            else
            {
                result2 = num2 * num2 * num2;
                Console.WriteLine("Cube: " + result2);
            }

            //Program 3 Nested If -Else Statement
            int a = 10, b = 34, c = 25;
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("a is the greatest");
                }
                else
                {
                    Console.WriteLine("c is the greatest");
                }

            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("b is the greatest");
                }
                else
                {
                    Console.WriteLine("c is the greatest");
                }

            }

            //Program 4 Nested If -Else Statement

            int year = 1000;
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine("Leap Year");
                    }
                    else
                    {
                        Console.WriteLine("Not a Leap Year");
                    }
                }
                else
                {
                    Console.WriteLine("Leap Year");
                }
            }
            else
            {
                Console.WriteLine("Not a Leap Year");
            }

            // program 5 Ladder or else-if Statement

            int marks = 85;
            if (marks >= 90)
            {
                Console.WriteLine("A");
            }
            else if (marks >= 80)
            {
                Console.WriteLine("B");
            }
            else if (marks >= 70)
            {
                Console.WriteLine("C");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }

            //Program 6 Ladder or else-if Statement - Marksheet Example

            int physics = 45, chemistry = 67, mathematics = 78, hindi = 80, english = 85;
            int failedCount = 0;
            int failedMark = 0;
            string failedSubjects = "";
            float per;
            int sum = physics + chemistry + mathematics + hindi + english;

            if ((physics >= 0 && physics <= 100) && (chemistry >= 0 && chemistry <= 100) && (mathematics >= 0 && mathematics <= 100) && (hindi >= 0 && hindi <= 100) && (english >= 0 && english <= 100))
            {
                if (physics < 33)
                {
                    failedCount++;
                    failedMark = physics;
                    failedSubjects += "Physics, ";
                }
                if (chemistry < 33)
                {
                    failedCount++;
                    failedMark = chemistry;
                    failedSubjects += "Chemistry, ";
                }
                if (mathematics < 33)
                {
                    failedCount++;
                    failedMark = mathematics;
                    failedSubjects += "Mathematics, ";
                }
                if (hindi < 33)
                {
                    failedCount++;
                    failedMark = hindi;
                    failedSubjects += "Hindi, ";
                }
                if (english < 33)
                {
                    failedCount++;
                    failedMark = english;
                    failedSubjects += "English, ";
                }

                failedSubjects = failedSubjects.Trim().TrimEnd(',');

                if (failedCount == 0 || (failedCount == 1 && failedMark >= 28))
                {
                    if (failedCount == 0)
                    {
                        per = sum / 5f;
                    }
                    else
                    {
                        per = (sum + (33 - failedMark)) / 5f; // apply grace to the single failed subject
                    }

                    if (per >= 33 && per < 45)
                    {
                        Console.WriteLine("Pass With Third Division And Percentage IS " + per + "%");
                    }
                    else if (per < 60)
                    {
                        Console.WriteLine("Pass With Second Division And Percentage IS " + per + "%");
                    }
                    else
                    {
                        Console.WriteLine("Pass With First Division And Percentage IS " + per + "%");
                    }

                    if (failedCount == 1)
                    {
                        Console.WriteLine("Pass By Grace and Grace Subject Is: " + failedSubjects);
                    }
                }
                else if (failedCount == 1)
                {
                    Console.WriteLine("Suppl");
                    Console.WriteLine("Suppl Subject Is: " + failedSubjects);
                }
                else
                {
                    Console.WriteLine("Fail");
                    Console.WriteLine("Fail Subjects Are: " + failedSubjects);
                }
            }
            else
            {
                Console.WriteLine("Invalid Marks, It Should be between 0 to 100");
            }
        }
    }
}

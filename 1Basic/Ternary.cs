using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.Basic
{
    internal class Ternary
    {
        static void Main()
        {
            //Program 1 Ternary Operator
            int a = 100;
            int b = 20;
            int c = 300;
            string result = (a > b && a > c) ? "a is greater than both b and c" : (b > a && b > c) ? "b is greater than both a and c" : "c is greater than both a and b";
            Console.WriteLine(result);

            //Program 2 Ternary Operator
            int num = 5;
            string output = (num % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(output);

            //Program 3 Ternary Operator
            int year = 1000;
            string lipYear = (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) ? "Leap Year" : "Not a Leap Year";
            Console.WriteLine(lipYear);

            //Program 4 Ternary Operator
            int marks = 85;
            string grade = (marks >= 90) ? "A" : (marks >= 80) ? "B" : (marks >= 70) ? "C" : (marks >= 60) ? "D" : "F";
            Console.WriteLine(grade);

            //Program 5 Ternary Operator
            int number = 45;
            string output2 = (number % 3 == 0 && number % 5 == 0) ? "Divisible by both" : (number % 3 == 0) ? "Divisible by 3" : (number % 5 == 0) ? "Divisible by 5" : "Not divisible by either";
            Console.WriteLine(output2);
        }
    }
}

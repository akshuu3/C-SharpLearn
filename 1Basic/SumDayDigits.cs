using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.Basic
{
    internal class SumDayDigits
    {
        static void Main()
        {
            String date1 = "12052016";
            int d1 = Convert.ToInt32(date1);

            int sum = 0;
            while (d1 != 0)
            {
                int first = d1 % 10;
                Console.WriteLine(first);
                sum += first;
                d1 = d1 / 10;
            }

            Console.WriteLine(sum);

            //int first = d1 % 10;
            //d1 = d1 / 10;

            //int second = d1 % 10;
            //d1 = d1 / 10;

            //int third = d1 % 10;
            //d1 = d1 / 10;

            //int fourth = d1 % 10;
            //d1 = d1 / 10;

            //int fifth = d1 % 10;
            //d1 = d1 / 10;

            //int sixth = d1 % 10;
            //d1 = d1 / 10;

            //int seventh = d1 % 10;
            //d1 = d1 / 10;

            //int eightth = d1 % 10;
            //d1 = d1 / 10;

            //Console.WriteLine(first + second + third + fourth + fifth + sixth + seventh + eightth);
        }
    }
}

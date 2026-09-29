using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.Basic
{
    internal class DateDiff
    {
        static void Main()
        {
            String date1 = "12052016";
            String date2 = "13062019";
            int d1 = Convert.ToInt32(date1);
            int d2 = Convert.ToInt32(date2);
            int y1 = d1 % 10000;
            int y2 = d2 % 10000;
            Console.WriteLine(y2 - y1);
        }
    }
}

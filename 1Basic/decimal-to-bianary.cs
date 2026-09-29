using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.Basic
{
    internal class decimal_to_bianary
    {
        static void Main(string[] args)
        {
            int num = 9;
            string data = "";
            while (num != 0)
            {
                data = num % 2 + data;
                num = (int)(num / 2);
            }
            Console.WriteLine(data);
        } 
    }
}

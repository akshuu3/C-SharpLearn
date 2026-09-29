using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.Basic
{
    internal class IncDecrement
    {
        static void Main()
        {
            int a = 10;

            //int b = a++ + a++ + a++;
            //10 + 11 + 12 =33
            //Console.WriteLine("a={0} and b={1}", a, b);

                        //OR

            int b = ++a + ++a + ++a;
            //11 + 12 + 13 = 36
            Console.WriteLine("a={0} and b={1}", a, b); // a=13 and b=36
            //Console.WriteLine("a={0} and b={1}", a++, ++b);
            //Console.WriteLine("a={0} and b={1}", -a++, ++b);

        }
    }
}


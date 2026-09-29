using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice._2Advance
{
    internal class Employee
    {
        private int empid;
        private string? empname;
        private int age;
        internal void Accept(int empid, string empname, int age) {
            this.empid  = empid;
            this.empname = empname;
            this.age = age;
        }
        internal void Display()
        {
            Console.WriteLine("Id {0}, Name: {1}, and Age: {2}", empid, empname, age);
        }
    }
}

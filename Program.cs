using ProjectPractice._2Advance;
using ProjectPractice.Basic;

namespace ProjectPractice
{
    internal class Program
    {
        readonly int a = 10;
        static readonly int y = 20;

        static void Main(string[] args)
        {   
            Console.WriteLine("Y is the Static Variable: " + y); // Accessing the static variable directly within the static method
            Console.WriteLine("Y is the Static Variable: " + Program.y); // Accessing the static variable using the class name
            Program obj = new(); // Creating an instance of the Program class
            Console.WriteLine("A is the Instance Variable: " + obj.a); // Accessing the instance variable using the object reference
            
            A obj1 = new A(); // Creating an instance of the A class
            obj1.Fun1(new string[0]); // Calling the instance method Fun1 of class A using the object reference
            A.Fun(new string[0]); // Calling the static method Fun of class A directly using the class name
            const string companyName = "Hello, World!"; // Declaring a constant variable
            Console.WriteLine("Company Name is the Constant: " + companyName);
            // companyName = "Changed"; // This will cause a compile-time error because companyName is a constant and cannot be reassigned.
            
            swapProgram obj2 = new swapProgram(); // Creating an instance of the swapProgram class
            obj2.Swap(5, 10); // Calling the Swap method of the swapProgram class using the object reference


            //Boxing and Unboxing
            BoxingExample example = new BoxingExample();
            example.Boxing(); // Calling the Boxing method of the BoxingExample class
            example.Unboxing();

            //Data Types 
            dataType dType = new dataType();
            dType.PDataType(); // Calling the PDataType method of the dataType class
            dType.DDataType2(); // Calling the DDataType2 method of the dataType class

            //Advance

            //Employee.cs

            Employee empObj1 = new Employee();
            empObj1.Accept(1, "Emp1", 22);
            empObj1.Display();

            Employee empObj2 = new Employee();
            empObj2.Accept(2, "Emp2", 23);
            empObj2.Display();

            //StaticExample.cs
            Console.WriteLine(StaticExample.x);
            StaticExample.fun();

        }
    }
}
namespace ProjectPractice.Basic // Namespace for the project
{
    internal class Operation // Class to perform basic arithmetic operations
    {
        int a, b, c; // Instance variables to hold the values of a, b, and c
        //void Accept() // Method to accept input values for a and b
        internal void Accept() // Method to accept input values for a and b
        {
            Console.WriteLine("Enter the value of a: ");
            a = Convert.ToInt32(Console.ReadLine()); // Accepting input for a and converting it to integer

            Console.WriteLine("Enter the value of b: ");
            b = Convert.ToInt32(Console.ReadLine()); // Accepting input for b and converting it to integer
        }
        internal void Add() // Method to perform addition of a and b
        {
            c = a + b;
            Console.WriteLine("The sum of a and b is: " + c);
        }
        internal void Subtract() // Method to perform subtraction of a and b
        {
            c = a - b;
            Console.WriteLine("The difference of a and b is: " + c);
        }
        internal void Multiply() // Method to perform multiplication of a and b
        {
            c = a * b;
            Console.WriteLine("The product of a and b is: " + c);
        }
        internal void Divide() // Method to perform division of a and b
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by zero"); // a / 0 would crash with DivideByZeroException
                return;
            }
            c = a / b;
            Console.WriteLine("The quotient of a and b is: " + c);
        }
    }
}

// The Operation class provides methods to accept two integer inputs and perform basic arithmetic operations (addition, subtraction, multiplication, and division) on them. The results of these operations are printed to the console.
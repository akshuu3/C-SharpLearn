namespace ProjectPractice.Basic
{
    internal class A
    {
        internal static void Fun(string[] args)
        {
            int a = 10; //Local variable inside a static method (a static variable is declared at class level with the static keyword)
            Console.WriteLine("The value of a is: " + a);
        }
        internal void Fun1(string[] args)
        {   
            int b = 100; //Local variable inside an instance method (an instance variable is declared at class level without static)
            Console.WriteLine("The value of b is: " + b); 
        }
    }
}

namespace ProjectPractice.Basic
{
    internal class BoxingExample
    {
        internal void Boxing()
        {
            int a = 10;
            object o;
            o = a; // Boxing: convert int (value type) to object (reference type)
            Console.WriteLine(o);
        }

        internal void Unboxing()
        {
            object o = 10; // Boxing
            int a = (int)o; // Unboxing: convert object (reference type) back to int (value type)
            Console.WriteLine(a);
        }
    }
}

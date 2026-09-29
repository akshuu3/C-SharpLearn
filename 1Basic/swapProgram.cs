namespace ProjectPractice.Basic
{
    internal class swapProgram
    {
       internal void Swap(int a, int b)
        {
            Console.WriteLine("Before swapping: a = " + a + ", b = " + b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swapping: a = " + a + ", b = " + b);
        }
    }
}

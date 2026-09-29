namespace ProjectPractice.Basic
{
    internal class SI
    {
        internal float principal;
        internal float rate;
        internal float time;
        internal float simpleInterest;

        internal void CalculateSimpleInterest()
        {
            principal = 12000f;
            rate = 2.2f;
            time = 4.5f;
            simpleInterest = (principal * rate * time) / 100f;
            Console.WriteLine("The simple interest is: " + simpleInterest);
        }
    }
}

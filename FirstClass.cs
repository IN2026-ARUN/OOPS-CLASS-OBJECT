partial class Program
{
    public class FirstClass
    {
        public int a, b;
        public SecondClass second;

        public FirstClass(int a, int b, SecondClass second)
        {
            this.a = a;
            this.b = b;
            this.second = second;

        }

        public void Print()
        {
            Console.WriteLine($"From FirstClass: a = {a}, b = {b}");
            second?.Print();
        }
    }
}
partial class Program
{
    public class SecondClass
    {
        public int c, d;

        public SecondClass(int c, int d)
        {
            this.c = c;
            this.d = d;
        }

        public void Print()
        {
            Console.WriteLine($"From SecondClass: c = {c}, d = {d}");
        }
    }
}

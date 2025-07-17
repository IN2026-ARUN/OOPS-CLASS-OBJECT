partial class Program
{
    public class FifthClass
    {
        public int i, j;

        public FifthClass(int i, int j)
        {
            this.i = i;
            this.j = j;
        }

        public void Print()
        {
            Console.WriteLine($"From FifthClass: i = {i}, j = {j}");
        }
    }
}

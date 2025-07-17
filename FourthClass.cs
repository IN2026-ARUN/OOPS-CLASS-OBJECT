partial class Program
{
    public class FourthClass
    {
        public int g, h;
        public FirstClass first;

        public FourthClass(int g, int h, FirstClass first)
        {
            this.g = g;
            this.h = h;
            this.first = first;
        }

        public void Print()
        {
            Console.WriteLine($"From FourthClass: g = {g}, h = {h}");
            first?.Print();
        }
    }
}

partial class Program
{
    public class ThirdClass
    {
        public int e, f;
        public FourthClass four;

        public ThirdClass(int e, int f, FourthClass four)
        {
            this.e = e;
            this.f = f;
            this.four = four;
        }

        public void Print()
        {
            Console.WriteLine($"From ThirdClass: e = {e}, f = {f}");
            four?.Print();
        }
    }
}

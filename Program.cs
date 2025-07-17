using System;

partial class Program
{
    static void Main()
    {
        SecondClass sharedSecond = new SecondClass(100, 200);
        FourthClass sharedFourth = new FourthClass(7, 8, null);
        FirstClass first = new FirstClass(1, 2, sharedSecond);
        SecondClass second = new SecondClass(3, 4);              
        ThirdClass third = new ThirdClass(5, 6, sharedFourth);
        FourthClass fourth = new FourthClass(9, 10, first);      
        FifthClass fifth = new FifthClass(11, 12);

        FirstClass anotherFirst = new FirstClass(13, 14, second);
        ThirdClass anotherThird = new ThirdClass(15, 16, fourth); 

        sharedFourth.first = anotherFirst;

        Console.WriteLine("\n-- First Object --");
        first.Print();

        Console.WriteLine("\n-- Second Object --");
        second.Print();

        Console.WriteLine("\n-- Third Object --");
        third.Print();

        Console.WriteLine("\n-- Fourth Object --");
        fourth.Print();

        Console.WriteLine("\n-- Fifth Object --");
        fifth.Print();

        Console.WriteLine("\n-- Six Object --");
        anotherFirst.Print();

        Console.WriteLine("\n-- Seventh Object --");
        anotherThird.Print();

        Console.ReadKey();
    }
}
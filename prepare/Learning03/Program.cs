using System;
namespace Learning03;

class Program
{
    static void Main(string[] args)
    {
        Fraction first = new Fraction();

        Fraction second = new Fraction(12);

        Fraction third = new Fraction(5, 8);
        
        Console.WriteLine(first.GetFractionString());
        Console.WriteLine(first.GetDecimalValue());

        Console.WriteLine(second.GetFractionString());
        Console.WriteLine(second.GetDecimalValue());
        
        Console.WriteLine(third.GetFractionString());
        Console.WriteLine(third.GetDecimalValue());
    }
}
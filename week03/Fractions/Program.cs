using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction three = new Fraction(1, 3);
        Console.WriteLine(three.GetFractionString());
        Console.WriteLine(three.GetDecimalValue());
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        // Fraction fraction1 = new Fraction(2);
        // Fraction fraction2 = new Fraction(1, 3);
        TestItOut(fraction);
        // TestItOut(fraction1);
        // TestItOut(fraction2);
        fraction.SetTop(7);
        fraction.GetTop();
        fraction.SetBottom(8);
        fraction.GetBottom();
        TestItOut(fraction);

        void TestItOut(Fraction fraction)
        {
        Console.WriteLine($"{fraction.GetFractionString()}");
        Console.WriteLine($"{fraction.GetDecimalValue()}");
        }
    }

    
}
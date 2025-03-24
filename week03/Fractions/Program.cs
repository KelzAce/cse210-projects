using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating fraction instances using different constructors
        Fraction frac1 = new Fraction();       // 1/1
        Fraction frac2 = new Fraction(5);      // 5/1
        Fraction frac3 = new Fraction(3, 4);   // 3/4
        Fraction frac4 = new Fraction(1, 3);   // 1/3

        // Display the fraction as a string and as a decimal
        Console.WriteLine($"Fraction 1: {frac1.GetFractionString()} = {frac1.GetDecimalValue()}");
        Console.WriteLine($"Fraction 2: {frac2.GetFractionString()} = {frac2.GetDecimalValue()}");
        Console.WriteLine($"Fraction 3: {frac3.GetFractionString()} = {frac3.GetDecimalValue()}");
        Console.WriteLine($"Fraction 4: {frac4.GetFractionString()} = {frac4.GetDecimalValue()}");

        // Modify fraction using setters
        frac3.SetNumerator(7);
        frac3.SetDenominator(2);

        Console.WriteLine($"Updated Fraction 3: {frac3.GetFractionString()} = {frac3.GetDecimalValue()}");
    }
}
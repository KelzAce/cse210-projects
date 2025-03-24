using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    // Constructor for 1/1
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // Constructor for n/1
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    // Constructor for n/d
    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Denominator cannot be zero.");

        _numerator = numerator;
        _denominator = denominator;
    }

    // Getters and Setters
    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Denominator cannot be zero.");
        
        _denominator = denominator;
    }

    // Method to return fraction as a string (e.g., "3/4")
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // Method to return the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}

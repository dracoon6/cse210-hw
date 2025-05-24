using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

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
        {
            Console.WriteLine("Error: Denominator cannot be zero. Value not changed.");
        }
        else
        {
            _denominator = denominator;
        }
    }

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }

    public Fraction(int top, int bottom)
    {
        if (bottom == 0)
        {
            Console.WriteLine("Error: Denominator cannot be zero. Setting to 1.");
            _denominator = 1;
        }
        else
        {
            _denominator = bottom;
        }
        _numerator = top;
    }

    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}
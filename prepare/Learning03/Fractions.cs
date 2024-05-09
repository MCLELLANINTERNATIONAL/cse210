using System;

public class Fraction
{
    private int numerator;
    private int denominator;

    // Constructor that initializes the fraction to 1/1
    public Fraction() : this(1, 1) { }

    // Constructor that initializes the numerator and sets denominator to 1
    public Fraction(int numerator) : this(numerator, 1) { }

    // Constructor that takes both numerator and denominator
    public Fraction(int numerator, int denominator)
    {
        this.Numerator = numerator;
        this.Denominator = denominator;
    }

    // Getters and setters
    public int Numerator
    {
        get { return numerator; }
        set { numerator = value; }
        }

        public int Denominator
        {
        get { return denominator; }
        set
        {
            if (value == 0)
                throw new ArgumentException("Denominator cannot be zero.");
            denominator = value;
        }
    }

    // Method to return the fraction as a string
    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    // Method to return the decimal value of the fraction
    public double GetDecimalValue()
    {
            return (double)numerator / denominator;
    }
}


    




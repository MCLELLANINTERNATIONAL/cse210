using System;

class Program
{
    static void Main(string[] args)
    {
         // Testing various constructors
            var fraction1 = new Fraction();
            var fraction2 = new Fraction(6);
            var fraction3 = new Fraction(6, 7);

            // Displaying the fraction and its decimal form
            Console.WriteLine(fraction1.GetFractionString() + " = " + fraction1.GetDecimalValue());
            Console.WriteLine(fraction2.GetFractionString() + " = " + fraction2.GetDecimalValue());
            Console.WriteLine(fraction3.GetFractionString() + " = " + fraction3.GetDecimalValue());

            // Testing getters and setters
            fraction1.Numerator = 3;
            fraction1.Denominator = 4;
            Console.WriteLine(fraction1.GetFractionString() + " = " + fraction1.GetDecimalValue());

            fraction2.Numerator = 1;
            fraction2.Denominator = 3;
            Console.WriteLine(fraction2.GetFractionString() + " = " + fraction2.GetDecimalValue());

    }
}
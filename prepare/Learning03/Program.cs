using System;
namespace Learning03
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction();
            Fraction fraction2 = new Fraction(5);
            Fraction fraction3 = new Fraction(3,4);
            Fraction fraction4 = new Fraction(1,3);

            Console.WriteLine(fraction1.GetString());
            Console.WriteLine(fraction1.GetDecimalValue());

            Console.WriteLine(fraction2.GetString());
            Console.WriteLine(fraction2.GetDecimalValue());

            Console.WriteLine(fraction3.GetString());
            Console.WriteLine(fraction3.GetDecimalValue());

            Console.WriteLine(fraction4.GetString());
            Console.WriteLine(fraction4.GetDecimalValue());


        }
    }
}
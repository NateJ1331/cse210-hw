using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program! ");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    } 
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string sNumber = Console.ReadLine();
        int number = Int32.Parse(sNumber);
        return number;
    }

    static double SquareNumber(double number)
    {
        double squaredNumber = number*number;
    
        return squaredNumber;
    }
    static void DisplayResult(string name, double square)
    {
        
        Console.WriteLine($"{name}, the square of your number is {square}");
    
    }    
    static void Main(string[] args)
    {
        string name;
        double number;
        double square;
    
        DisplayWelcome();
        name = PromptUserName();
        number = PromptUserNumber();
        square = SquareNumber(number); 
        DisplayResult(name,square);

        
    }
}
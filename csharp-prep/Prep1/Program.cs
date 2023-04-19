using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string name_f = Console.ReadLine();

        
        Console.Write("What is your last name? ");
        string name_l = Console.ReadLine();

        Console.WriteLine($"Your Name is {name_l}, {name_f} {name_l}");

    }
}
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); 
        int input = -1;
        double sum = 0;
        Console.WriteLine("Enter a list of numbers type 0 when finished.");

        while (input != 0)
        {   
            Console.Write("Enter a number: ");
            string SInput = Console.ReadLine();
            input = Int32.Parse(SInput);

            numbers.Add(input);
        }

        for (int i = 0; i < numbers.Count; i++)
        {
            sum = numbers[i] + sum;
        }
        
        double average = sum/(numbers.Count - 1);
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
    }
}
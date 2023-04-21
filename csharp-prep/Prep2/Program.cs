using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What grade precentage did you get? ");
        string Grade = Console.ReadLine();
        int IntGrade = int.Parse(Grade);
        string LetterGrade = "";
 
        if (IntGrade >= 90)
        {
            LetterGrade = "A";
        }
        
        else if (IntGrade >= 80)
        {
            LetterGrade = "B";
        }
        
        else if (IntGrade >= 70)
        {
            LetterGrade = "C";
        }

        else if (IntGrade >= 60)
        {
            LetterGrade = "D";
        }

        else if (IntGrade < 60)
        {
            LetterGrade = "F";
        }


        Console.WriteLine($"Your Grade is {LetterGrade}");

    }
}
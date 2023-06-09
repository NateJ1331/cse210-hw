using System;
namespace Learning04
{
    class Program
    {
        static void Main(string[] args)
        {
            MathAssignment assignment1 = new MathAssignment("Nate","Calculus","7.5","14-35");

            Console.WriteLine(assignment1.GetSummanry());
            Console.WriteLine(assignment1.GetHomeworkList());

            MathAssignment assignment2 = new MathAssignment("Nate","Communism","Communist Manifesto","Carl Marx");
            Console.WriteLine($"\n{assignment2.GetSummanry()}");
            Console.WriteLine(assignment2.GetHomeworkList());

        }
    }
}
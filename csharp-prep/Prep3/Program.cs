using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();

        int answer = rnd.Next(10);
        int guess = -1;
        


        while (guess != answer)
        {   
            Console.WriteLine("Whats the Magic number? ");
            string SGuess = guess.ToString();
            SGuess = Console.ReadLine();
            guess = Int32.Parse(SGuess);
            
            if (guess > answer)
            {
                Console.WriteLine("Lower");
            }

            else if (guess < answer)
            {
                Console.WriteLine("Higher");
            }
            
            else if (guess == answer)
            {
                Console.WriteLine("You guessed it!");
            }


        }        
    }
}
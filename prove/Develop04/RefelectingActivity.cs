using System.Collections.Generic;
namespace Develop04
{
    
    class ReflectingActivity: Activity
    {
        private List<string> _questions = new List<string>();
        void FillQuestions()
        {
            _questions.Add("Why was this experience meaningful to you?");
            _questions.Add("Have you ever done anything like this before?");
            _questions.Add("How did you get started?");
            _questions.Add("How did you feel when it was complete?");
            _questions.Add("What made this time different than other times when you were not as successful?");
            _questions.Add("What is your favorite thing about this experience?");
            _questions.Add("What could you learn from this experience that applies to other situations?");
            _questions.Add("What did you learn about yourself through this experience?");
            _questions.Add("How can you keep this experience in mind in the future?");

        }
        void FillPrompts()
        {
            this.SetPrompts("Think of a time when you stood up for someone else.");
            this.SetPrompts("Think of a time when you did something really difficult.");
            this.SetPrompts("Think of a time when you helped someone in need.");
            this.SetPrompts("Think of a time when you did something truly selfless.");
        }

        public void DisplayQuestions(float duration)
        {
            UserInterface display = new UserInterface();
            
            for (float i = duration/5; i > 0; i--)
            {
              Console.Write($"{_questions[this.GetRandomNumber(_questions)]} ");
              display.Wait();
            }
            Console.Clear();

        }
        public void DisplayPrompt()
        {
            this.FillPrompts();
            this.FillQuestions();
            Console.WriteLine("Consider the following prompt:\n");
            Console.WriteLine($"--- {this.GetPrompt()} ---\n");
            Console.Write("When you have something in mind, press enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
using System.Collections.Generic;
namespace Develop04
{
    
    class ReflectingActivity: Activity
    {
        private string[] _prompts = {"Think of a time when you stood up for someone else.",
                                    "Think of a time when you did something really difficult.",
                                    "Think of a time when you helped someone in need.",
                                    "Think of a time when you did something truly selfless."};
        private string[] _questions = { "Why was this experience meaningful to you?",
                                        "Have you ever done anything like this before?",
                                        "How did you get started?",
                                        "How did you feel when it was complete?",
                                        "What made this time different than other times when you were not as successful?",
                                        "What is your favorite thing about this experience?",
                                        "What could you learn from this experience that applies to other situations?",
                                        "What did you learn about yourself through this experience?",
                                        "How can you keep this experience in mind in the future?"};
        private List<int> _randomNumbers = new List<int>(); 
        
        public int GetRandomNumber()
        {
            Random random = new Random();
            int number = random.Next(_questions.Length);
            do 
            {
                number = random.Next(_questions.Length);
            }
            while (_randomNumbers.Contains(number));
            _randomNumbers.Add(number);
            
            if( _randomNumbers.Count() == _questions.Length)
            {_randomNumbers.Clear();}
            
            return number;
        }
        
        public string Prompt()
        {
            string prompt;
            Random random = new Random(_prompts.Length);

            prompt = _prompts[random.Next(_prompts.Length)];

            return prompt;
        }

        public void DisplayQuestions(float duration)
        {
            UserInterface display = new UserInterface();
            
            for (float i = duration/5; i > 0; i--)
            {
              Console.Write($"{_questions[GetRandomNumber()]} ");
              display.Wait();
            }
            Console.Clear();

        }
        public void DisplayPrompt()
        {
            Console.WriteLine("Consider the following prompt:\n");
            Console.WriteLine($"--- {this.Prompt()} ---\n");
            Console.Write("When you have something in mind, press enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
namespace Develop04
{
    public class Activity
    {
        private List<string> _prompts = new List<string>(); 
        private float _duration;
        private string _endMessage;

        private List<int> _randomNumbers = new List<int>(); 
       
         public int GetRandomNumber(List<string> prompts)
        {
            Random random = new Random();
            int number = random.Next(prompts.Count);
            do 
            {
                number = random.Next(prompts.Count);
            }
            while (_randomNumbers.Contains(number));
            _randomNumbers.Add(number);
            
            if( _randomNumbers.Count() == prompts.Count)
            {_randomNumbers.Clear();}
            
            return number;
        }
        

        public void SetPrompts(string prompt)
        {

            _prompts.Add(prompt);

        }
        public string GetPrompt()
        {
            string prompt;
            Random random = new Random(_prompts.Count);

            prompt = _prompts[random.Next(_prompts.Count)];

            return prompt;
        }

        public void StartMessage(string activity)
        {
            Console.Clear();

            Console.WriteLine($"Welcome to the {activity} Activity\n");
            
            switch(activity)
            {
                case "Breathing":
                    Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n");
                    break;

                case "Reflecting":
                    Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience." + 
                    "This will help you recognize the power you have and how you can use it in other aspects of your life.\n");
                    break;
                case "Listing":
                    Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");
                    break;

                default:
                    break;
            }
        }

        public void ActivityStart()
        {
            Console.Write("Avtivity Starting ");

            for(int i = 3 ; i > 0; i--)
            {
                Console.Write(". ");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    
         public void Wait()
        {
            List<string> spinner = new List<string>();

            spinner.Add("|");
            spinner.Add("/");
            spinner.Add("-");
            spinner.Add("\\");
            spinner.Add("|");

            foreach(string spin in spinner)
            {
                Console.Write(spin);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();

        }
        public void SetDuration()
        {   
            Console.Write("How long in seconds, would you like for your session? ");
            string durationString = Console.ReadLine();

            float duration = Int32.Parse(durationString);

            _duration = duration;

            Console.Clear();

        }

        
        public void SetEndMessage(float duration, string activity)
        {
            _endMessage = $"Well Done!!\n\nYou have completed {duration} seconds of the {activity} Activity";
        }

        public float GetDuration()
        {
            return _duration;
        }

        public string GetEndMessage()
        {
            return _endMessage;
        }




    }
}
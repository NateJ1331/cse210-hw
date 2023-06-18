namespace Develop04
{
    public class Activity
    {
        private float _duration;
        private string _endMessage;

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
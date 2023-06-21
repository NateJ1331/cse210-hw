namespace Develop04
{
    class ListingActivity : Activity
    {
        List<string> _responses = new List<string>();

        void FillPrompts()
        {
            this.SetPrompts("Who are people that you appreciate?");
            this.SetPrompts("What are personal strengths of yours?");
            this.SetPrompts("Who are people that you have helped this week?");
            this.SetPrompts("When have you felt the Holy Ghost this month?");
            this.SetPrompts("Who are some of your personal heroes?");
        }
        
        public void List(float duration)
        {
            this.FillPrompts();
            Console.WriteLine("List as many responses you can to the following prompt:\n");
            Console.WriteLine($"--- {GetPrompt()} ---");
            Console.Write("\nYou may begin in: ");
            
            for(int i = 5 ; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(duration);

            while(DateTime.Now < endTime)
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                _responses.Add(input);
            }

            Console.WriteLine($"\n\nYou have listed {_responses.Count} items!");


        }



    }
}
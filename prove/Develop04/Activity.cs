namespace Develop04
{
    public class Activity
    {
        private float _duration;
        private string _endMessage;

       
        public void Start()
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
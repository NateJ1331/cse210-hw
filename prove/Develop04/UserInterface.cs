namespace Develop04
{
    class UserInterface
    {
        public void Display()
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("     1. Breathing Activity");
            Console.WriteLine("     2. Reflection Activity");
            Console.WriteLine("     3.");
            Console.WriteLine("     4. Quit");

        }

        public void Wait()
        {
            List<string> spinner = new List<string>();

            spinner.Add("|");
            spinner.Add("/");
            spinner.Add("-");
            spinner.Add("\\");
            spinner.Add("|");

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(5);
            int i =0;

            while(DateTime.Now < endTime)
            {
                Console.Write(spinner[i]);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                i++;

                if(i >= spinner.Count){ i=0; }
            }
            Console.WriteLine();

        }


        public void Menu()
        {
            string quit = "no";
            while(quit != "yes")
            {
                string activity; 

                this.Display();

                Console.Write("Select a choice from the menu: ");
                string input = Console.ReadLine();
                float duration;
            
                int num = Int32.Parse(input);
            
            
                switch(num)
                {
                    case 1: 
                        activity ="Breathing";
                        BreathingActivity breathingActivity = new BreathingActivity();
                        breathingActivity.StartMessage(activity);
                        breathingActivity.SetDuration();
                        duration = breathingActivity.GetDuration();
                        breathingActivity.SetEndMessage(duration,activity);
                        breathingActivity.Breathing(duration);
                        Console.WriteLine(breathingActivity.GetEndMessage());
                        this.Wait();
                        Console.Clear();
                        break;

                    case 2:
                        activity ="Reflecting";
                        ReflectingActivity reflectingActivity = new ReflectingActivity();
                        reflectingActivity.StartMessage(activity);
                        reflectingActivity.SetDuration();
                        duration = reflectingActivity.GetDuration();
                        reflectingActivity.SetEndMessage(duration,activity);
                        reflectingActivity.DisplayPrompt();
                        reflectingActivity.DisplayQuestions(duration);
                        Console.WriteLine(reflectingActivity.GetEndMessage());
                        this.Wait();
                        Console.Clear();
                        
                        break;

                    case 4:
                        quit = "yes";
                        break;

                    default:
                        break;
                }
            }
             

        }
    }
}
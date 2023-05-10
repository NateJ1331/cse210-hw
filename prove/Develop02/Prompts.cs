using System.Collections.Generic;
using System;

namespace Develop02
{
    class Prompt
    {
        public List<string> prompts;

         public Prompt ()
        {
            prompts = new List<string>();
        }

        public string GetPrompt()
        {

            prompts.Add("Who was the most interesting person I interacted with today?");
            prompts.Add("What was the best part of my day?");
            prompts.Add("How did I see the hand of the Lord in my life today?");
            prompts.Add("What was the strongest emotion I felt today?");
            prompts.Add("If I had one thing I could do over today, what would it be?");

            Random rnd = new Random();
            int randNum = rnd.Next(prompts.Count);
            string randomPrompt = prompts[randNum];


            return randomPrompt;
        }
    }

}
using System;
using System.Collections.Generic;

namespace Develop02
{
    class Menu
    {
        public void Display()
        {
            Console.WriteLine("Please select one of the following");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

        }

        public void Options()
        {
            Prompt prompts = new Prompt();
            User user = new User();
            Entry myEntry = new Entry();
            Journal journal = new Journal();

            string prompt;
            string response;
            int choice = 0;
            List<String> message = new List<String>();
            List<Entry> entries = new List<Entry>();
            
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();


            while(choice !=5)
            {       
                this.Display();

                Console.Write("What would you Like to do? ");
                string strChoice = Console.ReadLine();
                choice = Convert.ToInt32(strChoice);
            
                
                switch(choice)
                {
                    case 1:
                        prompt = prompts.GetPrompt();
                        response = user.GetResponse(prompt);
                        myEntry.Store(prompt ,response, dateText);
                        journal.StoreEntry(myEntry);
                        entries = journal.GetAllEntries();
                        message.Add(myEntry.GetAsString());

                    break;

                    case 2:
                        
                        for(int i = 0; i < entries.Count; i++)
                        {
                            Console.WriteLine(message[i]);
                        }
                    break;
                }
            }
                
        

        }
    
    }
}

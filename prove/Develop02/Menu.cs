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
            File file = new File();

            string prompt;
            string response;
            string fileName;
            int choice = 0;
            List<String> messages = new List<String>();
            List<String> formatMessages = new List<String>();
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
                        messages.Add(myEntry.GetAsString());
                        formatMessages.Add(myEntry.FormatString());
                       
                    break;

                    case 2:
                        
                        foreach(string message in messages)
                        {
                            
                            Console.WriteLine(message);
                        }

                    break;

                    case 3:
                        
                        Console.WriteLine("What is the filename? ");
                        fileName = Console.ReadLine();
                        file.Save(fileName,formatMessages);

                    break;

                    case 4:

                        Console.WriteLine("What is the filename? ");
                        fileName = Console.ReadLine();
                        file.Load(fileName, messages);

                    break;
                    
                }
            }
                
        

        }
    
    }
}

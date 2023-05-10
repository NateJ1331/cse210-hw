using System;
using System.Collections.Generic;
//classes//
        //1 and 2//
            //Entry
                //record the promt, response, and date
                    //question
                    //resonse
                    //date
                //Fuctions
                    //Store(question/prompt,response,date)
                    //FetchAString():string 
            //Journal(has Entry)
                    //to store entries
                    //List: Entry  
                //Functions 
                    //StorEntry(entry): void
                    //FetchAllEntries(): List<Entry>
            //Prompts
                //Produce a predefined question (or prompt)
                //GetRandomProompt(): string
namespace Develop02{    
    class Program
    {
        static void Main(string[] args)
        {
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();

            Entry myEntry = new Entry();
            Prompt prompts = new Prompt();
            User user = new User();

            string prompt = prompts.GetPrompt();
            string response;

            response = user.getResponse(prompt);
            Console.WriteLine("\n");

            myEntry.Store(prompt ,response, dateText);

            Journal journal = new Journal();
            journal.StoreEntry(myEntry);

            List<Entry> entries = journal.GetAllEntries();
            foreach(Entry entry in entries)
            {
                string message = myEntry.GetAsString();
                Console.WriteLine(message);
            }


        }
    }
}
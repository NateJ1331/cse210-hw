using System.Collections.Generic;
using System.IO;
using System;

namespace Develop02
{
    class File
    {
        public void Save(string fileName, List<string> formatMessages)
        {   
            using (StreamWriter outputfile = new StreamWriter(fileName))
            {
                for(int i = 0; i < formatMessages.Count; i++)
                {
                    outputfile.WriteLine(formatMessages[i]);
                }
            }
        }   

        public void Load(string fileName, List<string> messages)
        {
            Entry myEntry = new Entry();
            Journal journal = new Journal();
            string lines = "";

            char [] seperators = new char []{':'}; 
            string[] fileInfo = System.IO.File.ReadAllLines(fileName);

            foreach(string info in fileInfo)
            {
                lines += info;

                string[] seperate = lines.Split(seperators);

                string prompt = seperate[0];
                string response = seperate[1];
                string date = seperate [2];
                
                myEntry.Store(prompt ,response, date);
                messages.Add(myEntry.GetAsString());
                journal.StoreEntry(myEntry);
                
                lines = "";
            }
            
            

        }
    }

}
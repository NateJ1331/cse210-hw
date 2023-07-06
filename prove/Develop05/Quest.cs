using System.Collections.Generic;
using System;
namespace Develop05
{
    abstract class Quest
    {
        private string _quest;
        private string _type;
        private string _description;
        private bool _completion = false;
        int _completions;
        int _total;

        public abstract int Record();
        
        public virtual void Create(string type)
        {
            string quest;
            string description;

            Console.Write($"What is your {type} Quest?: ");
            quest = Console.ReadLine();

            Console.WriteLine("Please add a breif description:");
            description = Console.ReadLine();

            this.SetQuestsAndType(quest,description,type); 
            Console.Clear();
        }
        
        public void SetQuestsAndType(string quest, string description,string type)
        {
            _quest = quest;

            _type = type;

            _description = description;
        }
        

        public void SetCompletion()
        {
            _completion = true;
        }

        public void SetTotal(int total)
        {
            _total = total;
        }

        public void SetCompletions(int completions)
        {
            _completions += completions;
        }

         public int GetTotal()
        {
            return _total;
        }

        public int GetCompletions()
        {
            return _completions;
        }

        public bool GetCompletion()
        {
            return _completion;
        }

        public string GetQuestType()
        {
            return _type;
        }

        public string GetQuest()
        {
            return _quest;
        }

        public string GetDescription()
        {
            return _description;
        }

        


       


    }
}
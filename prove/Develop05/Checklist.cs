namespace Develop05
{
    class Checklist:Quest
    {
        

        public override void Create(string type)
        {
            string quest;
            string description;

            Console.Write($"What is your {type} Quest?: ");
            quest = Console.ReadLine();

            Console.WriteLine("Please add a breif description: ");
            description = Console.ReadLine();

            Console.Write("How many times does this need to be completed: ");
            string total = Console.ReadLine();

            int inttotal= Convert.ToInt32(total);

            this.SetCompletions(0);
            this.SetTotal(inttotal);
            this.SetQuestsAndType(quest,description,type); 
            Console.Clear();
        }

        public override int Record()
        {
            int points = 25;

            if(GetCompletions() == GetTotal())
                {SetCompletion();}
            else
                this.SetCompletions(1);

            return points;
        }

       
    }
}
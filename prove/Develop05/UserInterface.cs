namespace Develop05
{
    using System.Collections.Generic;
    class UserInterface
    {
        private List<Quest> _quests= new List<Quest>();
        private int _points;

        public void MainMenuDisplay()
        {
            Console.WriteLine($"you have {_points} points");

                Console.WriteLine("Menu Options:");
                Console.WriteLine("   1. Create New Goal");
                Console.WriteLine("   2. List Goals");
                Console.WriteLine("   3. Record");
                Console.WriteLine("   4. Save");
                Console.WriteLine("   5. Load");
                Console.WriteLine("   6. Quit");
                Console.Write("Slect a choice from the menu: ");
        }

         public void QuestTypeMenuDisplay()
         {
            Console.WriteLine("What kind of Quest would you like to create?");
            Console.WriteLine("   1. Eternal");
            Console.WriteLine("   2. Simple");
            Console.WriteLine("   3. Checklist");
            Console.WriteLine("   4. Back");
            Console.Write("Slect a choice from the menu: ");
         }


        
        public void MainMenu()
        {
            string quit = "";

            while(quit != "yes")
            {
                
                this.MainMenuDisplay();
                string choice1 = Console.ReadLine();
                int intchoice1 = Convert.ToInt32(choice1);

                switch(intchoice1)
                {
                    case 1:
                        Console.Clear();
                        this.QuestTypeMenu();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                     
                        foreach(Quest quest in _quests)
                            {
                                string check = "";
                                string completions = "";

                                if(quest.GetCompletion() == true)
                                {check = "X";}

                                if(quest.GetQuestType() == "Eternal")
                                {check = "~";}

                                if(quest.GetQuestType() == "Checklist")
                                {completions = $"{quest.GetCompletions()}/{quest.GetTotal()}";}

                                Console.WriteLine($"[{check}] {quest.GetQuestType()} Quest: {quest.GetQuest()} ({quest.GetDescription()}) {completions}");    
                            }
                        
                        Console.Write("\nHit enter to continue: ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    
                    case 3:
                        Console.Clear();
                        int b = 0;
                        foreach(Quest quest in _quests)
                            {
                                b++;
                                Console.WriteLine($"{b}. {quest.GetQuestType()} Quest: {quest.GetQuest()} ({quest.GetDescription()})");
                            }
                        Console.WriteLine("Which goal would you like to complete?");
                        string input = Console.ReadLine();
                        int intinput = Convert.ToInt32(input);
                        _points += _quests[intinput - 1].Record();
                        Console.WriteLine("\nCongratulations! You have completed a quest");

                        Console.Write("Hit enter to continue: ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    
                    case 4:
                        Console.Clear();
                        using (StreamWriter outputFile = File.AppendText("myFile.txt"))    
                        {
                            foreach(Quest quest in _quests)
                            {
                                outputFile.WriteLine($"{quest.GetQuestType()}:{quest.GetQuest()}:{quest.GetDescription()}:{quest.GetCompletion()}:{quest.GetCompletions()}:{quest.GetTotal()}");  
                            } 
                        }   
                        
                        Console.WriteLine("Your Quests have been saved! please hit enter to continue: ");
                        Console.ReadLine();
                        Console.Clear();
                    break;


                    case 5:
                    Console.Clear();
                    string filename = "myFile.txt";
                    string[] lines = System.IO.File.ReadAllLines(filename);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(":");
                        string type = parts[0];

                        switch(type)
                        {
                            case "Eternal":
                            Eternal eternal = new Eternal();
                            eternal.SetQuestsAndType(parts[1],parts[2],parts[0]);
                            if(parts[3] == "true")
                            {
                                eternal.SetCompletion();
                            }
                            eternal.SetCompletions(Convert.ToInt32(parts[4]));
                            eternal.SetTotal(Convert.ToInt32(parts[5]));
                            _quests.Add(eternal);
                            break;

                            case "Simple":
                            Simple simple = new Simple();
                            simple.SetQuestsAndType(parts[1],parts[2],parts[0]);
                            if(parts[3] == "true")
                            {
                                simple.SetCompletion();
                                _points += simple.Record();
                            }
                            simple.SetCompletions(Convert.ToInt32(parts[4]));
                            simple.SetTotal(Convert.ToInt32(parts[5]));
                            _quests.Add(simple);
                         
                            break;

                            case "Checklist":
                            Checklist checklist = new Checklist();
                            checklist.SetQuestsAndType(parts[1],parts[2],parts[0]);
                            
                            if(parts[3] == "true")
                            {checklist.SetCompletion();}
                            checklist.SetCompletions(Convert.ToInt32(parts[4]));
                            if(checklist.GetCompletions() > 0)
                            {_points += checklist.Record();}
                            checklist.SetTotal(Convert.ToInt32(parts[5]));
                            _quests.Add(checklist);
                            break;
                        }
                    }
                    Console.WriteLine("Your Quests have been loaded! please hit enter to continue: ");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                    case 6:
                        quit = "yes";
                        break;
                }
            }

        }
        
        public int QuestTypeMenu()
        {
            string choice2 = "";

            QuestTypeMenuDisplay();
            choice2 = Console.ReadLine();

            switch(choice2)
            {
                case "1":
                Eternal eternal = new Eternal();
                eternal.Create("Eternal");
                _quests.Add(eternal);
                return 0;
    
                case "2":
                Simple simple = new Simple();
                simple.Create("Simple");
                _quests.Add(simple);
                return 0;
                
                case "3":
                Checklist checklist = new Checklist();
                checklist.Create("Checklist");
                _quests.Add(checklist);
                return 0;

                default:
                Console.Clear();
                return 0;
            }
                   

        }


       
    }
}
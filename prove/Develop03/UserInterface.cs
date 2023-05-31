using System;
using System.IO;
using System.Collections.Generic;

namespace Develop03 
{
    class UserInterface
    {
        private string _quit = "";
        private int _counter = 0;
        private string[] _splitWords;
        public string EnterReference()
        {
            string reference = "Heleman 5:12";

            return reference;
        }    
        public string EnterScripture()
        {   
            string scripture = "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; " +
            "that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power" +
            "over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.";
            
            return scripture;
        }

        public int Counter(string[] words, int counter) 
        {
            for(int i = 0; i < words.Length; i++)
                {
                    if (words[i].Substring(0,1) == "_")
                    {
                        counter += 1;
                    }                  
                }

            return counter;
        }

        public void Display()
        {
            Scripture scripture = new Scripture();       
            Word word = new Word();
            
            _splitWords = scripture.GetWords();

            Random rnd = new Random();
            

            while(_quit != "quit")
            {
                _counter = 0;
                int num1 = rnd.Next(_splitWords.Length);
                int num2 = rnd.Next(_splitWords.Length);

    
                for(int i = 0; i < _splitWords.Length; i++)
                {
                    if (i != num1 && i !=num2)
                    {
                        Console.Write($"{_splitWords[i]} ");
                    }

                    else if (i == num1 || i == num2)
                    {
                        if(_splitWords[i].Substring(0,1) == "_")
                        { 
                            Console.Write($"{_splitWords[i]} ");
                        }

                        else
                        {
                            _splitWords[i] = word.hide(_splitWords[i]);
                        }
                    }
                }

                
                _counter = this.Counter(_splitWords,_counter);


                //Testing Console.WriteLine($"\n\n{_counter}\n\n");
                //Testing Console.WriteLine($"{splitWords.Length}");
                Console.WriteLine("\n\nHit enter to continue or type quit to end");
                _quit = Console.ReadLine();
                if(_counter == _splitWords.Length){break;}
                Console.Clear();
            }
        }
        
    } 

}
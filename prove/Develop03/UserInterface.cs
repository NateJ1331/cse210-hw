using System;
using System.IO;
using System.Collections.Generic;

namespace Develop03 
{
    class UserInterface
    {
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

        public void Display()
        {
            Scripture scripture = new Scripture();       
            Word words = new Word();

            Console.WriteLine($"{this.EnterReference()}:");
            string[] splitWords = scripture.GetWords();

            foreach (string eachWord in splitWords)
            {
                Console.Write($"{words.GetWord(eachWord)} ");
            }
        }
        
    } 

}
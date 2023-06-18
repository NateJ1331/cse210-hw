using System;
namespace Develop04
{
    public class BreathingActivity : Activity
    {
        public void BreathIn()
        {
            Console.Write("\nBreath in: ");
            for(int i = 2 ; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        
        }

        public void BreathOut()
        {
            Console.Write("\nBreath out: ");
            for(int i = 3 ; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine();
        
        }


        public void Breathing(float duration)
        {
           
            this.ActivityStart();

            for (float i = duration/5; i > 0; i--)
            {
                this.BreathIn();
                this.BreathOut();
            }

            Console.Clear();

            


        }



    }
}
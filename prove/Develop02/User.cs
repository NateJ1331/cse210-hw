using System;

namespace Develop02
{
    class User
    {
        public string GetResponse(string prompt)
        {
            Console.WriteLine(prompt,"\n >");
            string response = Console.ReadLine();
            return response;
        }
    }

}
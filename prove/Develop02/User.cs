using System;

namespace Develop02
{
    class User
    {
        public string GetResponse(string prompt)
        {
            Console.WriteLine(prompt);
            Console.Write("> ");
            string response = Console.ReadLine();
            return response;
        }
    }

}
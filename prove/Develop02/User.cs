using System;

namespace Develop02
{
    class User
    {
        public string getResponse(string prompt)
        {
            Console.WriteLine(prompt);
            string response = Console.ReadLine();
            return response;
        }
    }

}
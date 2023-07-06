using System.IO; 
using System.Collections.Generic;
namespace Develop05
{
    class File
    {
        public void save(string type, string quest, string description, bool completion, int completions, int total)
        {
          Console.WriteLine($"{type}:{quest}:{description}:{completion}:{completions}:{total}");   
        }
    }
}

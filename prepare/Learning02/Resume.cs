using System.Collections.Generic;
public class Resume
{
    public string _name;
    public List<Job> jobs = new List<Job>();
    
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs: ");
        for(int i = 0; i < jobs.Count ; i++)
        {
            Console.WriteLine($"{jobs[i]._jobTitle} ({jobs[i]._company}) {jobs[i]._startYear}-{jobs[i]._endYear}");
            i = i++;
            
        }
    }
}
using System;
using System.Collections.Generic;
class Program
{
     static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();
        Resume resume = new Resume();

        resume._name = "Rebecca";

        job1._company = "Apple";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2017;
        job1._endYear = 2023;

        job2._company = "Microsoft";
        job2._jobTitle = "HR";
        job2._startYear = 2009;
        job2._endYear = 2012;

        resume.jobs.Add(job2);
        resume.jobs.Add(job1);

        
        resume.Display();
    }
}
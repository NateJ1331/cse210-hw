using System;

class Program
{

    public class Job
    {
        public string _company;
        public string _jobTitle;
        public int _startYear;
        public int _endYear;

        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }

    }

    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();

        job1._company = "Apple";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2017;
        job1._endYear = 2023;

        job2._company = "Microsoft";
        job2._jobTitle = "HR";
        job2._startYear = 2009;
        job2._endYear = 2012;

        job1.Display();
        job2.Display();

    }
}
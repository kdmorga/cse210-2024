using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Google";
        job1._startYear = 2017;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Sales";
        job2._company = "Microsoft";
        job2._startYear = 2019;
        job2._endYear = 2021;

        Resume myResume = new Resume();
        myResume._name = "Jamie Smith";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);


        myResume.Display();
    }
}
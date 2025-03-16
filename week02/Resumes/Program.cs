using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._starterYear = 2019;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "Designer";
        job2._company = "Amazon";
        job2._starterYear = 2012;
        job2._endYear = 2015;

        Resume myResume = new Resume();
        myResume._name = "Okoro Ikechi";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}
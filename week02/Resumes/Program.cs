using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Netlan";
        job1._startYear = 2016;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Tecnico";
        job2._company = "La Bodeguita";
        job2._startYear = 2010;
        job2._endYear = 2015;

        Resume myResume = new Resume();
        myResume._name = "Gabriel Muñoz";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}
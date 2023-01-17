using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Sales";
        job1._company = "Slimy Car Dealership";
        job1._startYear = 2000;
        job1._endYear = 2010;

        Job job2 = new Job();
        job2._jobTitle = "Customer Service";
        job2._company = "Angry Customers Inc.";
        job2._startYear = 2010;
        job2._endYear = 2014;

        Resume resume1 = new Resume();
        resume1._name = "Acme Person";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.DisplayResume();
    }
}
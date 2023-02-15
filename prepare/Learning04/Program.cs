using System;

class Program
{
    static void Main(string[] args)
    {
    // Assignment assignment1 = new Assignment("Emily Wall", "computer programming");
    // Console.WriteLine(assignment1.GetSummary());

    // MathAssignment assignment2 = new MathAssignment("Gid Wall", "math", "3.1", "10-12");
    // Console.WriteLine(assignment2.GetSummary());
    // Console.WriteLine(assignment2.GetHomeworkList());

    WritingAssignment assignment3 = new WritingAssignment("Si Wall", "English", "Some Writing");
    Console.WriteLine(assignment3.GetSummary());
    Console.WriteLine(assignment3.GetWritingInformation());
    }


}
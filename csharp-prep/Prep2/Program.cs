using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        
        if (grade >= 90)
        {
            Console.WriteLine("You have an A. Good job!");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("You have a B. Pretty good job!");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("You have a C. You're a very average student.");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("You have a D. You need to work harder.");
        }
        else
        {
            Console.WriteLine("You have an F. Yikes!");
        }

        if (grade >= 70)
        {
            Console.WriteLine("Good job passing the class!");
        }

        else 
        {
            Console.WriteLine("Do you really want to fail this class? Work harder!");
        }
    }
}
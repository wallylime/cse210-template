using System;

class Program
{
    static void Main(string[] args)
    {
        //The main difference that I noticed between my solution and the sample solution was that I wrote the functions first and then called them--whereas the sample solution had them last. Is there a style guideline that says you should write them last or is it a matter of personal preference?
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int SquareNumber(int number)
        {
            int sqNum = number * number;
            return sqNum;
        }
        static void DisplayResult(int sqNum, string name)
        {
            Console.WriteLine($"{name}, the square of your number is {sqNum}");
        }
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int sqNumber = SquareNumber(number);
        DisplayResult(sqNumber, name);
    }
}
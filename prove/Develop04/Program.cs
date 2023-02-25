using System;

class Program
{
  static void Main(string[] args)
  {
    bool quit = false;
    Console.WriteLine("Welcome to the Improving Mindfulness program.");
    while (quit == false)
    {
      DisplayMenu();
      ProcessUserChoice();
    }

    void DisplayMenu()
    {
      Console.WriteLine("\nHere are the menu options:");
      Console.WriteLine("1. Start breathing activity");
      Console.WriteLine("2. Start reflecting activity");
      Console.WriteLine("3. Start listing activity");
      Console.WriteLine("4. Quit");
    }

    void ProcessUserChoice()
    {
      Console.WriteLine("Please type the number that corresponds to your menu choice:");
      string userChoice = Console.ReadLine();
      switch (userChoice)
      {
        case "1":
          Console.WriteLine("This will eventually run the breathing activity.");
          Console.WriteLine("Test BeginActivity function so far:");
          Activity newAct = new Activity("testActivity", "testDescription");
          newAct.BeginActivity();
          break;

        case "2":
          Console.WriteLine("This will eventually run the reflecting activity.");
          break;

        case "3":
          Console.WriteLine("This will eventually run the listing activity.");
          break;

        case "4":
          quit = true;
          break;

        default:
          Console.WriteLine("Sorry, that is not a valid response.");
          Console.WriteLine("Please type a number 1-4 to select one of the menu options.");
          break;
      }

    }
  }
}
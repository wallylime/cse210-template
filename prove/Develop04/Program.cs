/*
Exceeding requirements:
-Made sure the prompts and questions in the reflecting activity
don't repeat and that they restart when all of them have been used.
-Cooler pause animation.
*/

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
          BreathingActivity breathingActivity = new BreathingActivity("breathing activity", "\nThis activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.\n");
          breathingActivity.RunBreathingActivity();
          break;

        case "2":
          ReflectingActivity reflectingActivity = new ReflectingActivity("reflecting activity", "\nThis activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.\n");
          reflectingActivity.RunReflectingActivity();
          break;

        case "3":
          ListingActivity listingActivity = new ListingActivity("listing activity", "\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");
          listingActivity.RunListingActivity();
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
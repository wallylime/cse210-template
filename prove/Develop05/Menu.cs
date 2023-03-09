using System;

//This class deals with the different menus used in the program
public class Menu
{
  private bool quit = false;
  public void RunStartupMenu()
  {
    while (quit == false)
    {
      Console.WriteLine("What would you like to do?" +
      "\n  1. Set up new goals and rewards" +
      "\n  2. Load a saved file" +
      "\n  3. Quit");
      Console.Write("\nChoice number: ");
      ProcessUserChoice();
    }
  }
private void ProcessUserChoice()
  {
    string userChoice = Console.ReadLine();

    switch (userChoice)
    {
      case "1":
      Console.WriteLine("This will eventually set up the goal program by creating goals and setting user rewards.");
      break;

      case "2":
          Console.WriteLine("This will load a saved file.");
        break;

      case "3":
        quit = true;
        break;

      default:
        Console.WriteLine("Sorry, that wasn't one of the options. Please select the \nnumber that corresponds to your choice.\n");
        break;
    }

  }
  // public void RunMainMenu()
  // {
  //   do
  //   {
  //     Console.WriteLine("What would you like to do?" +
  //     "\n  1. Create a new goal" +
  //     "\n  2. List goals" +
  //     "\n  3. Save goals" +
  //     "\n  4. Record an event" +
  //     "\n  5. Quit");
  //     ProcessUserChoice("mainMenu");
  //   } while (quit == false);

  // }

  // public void ChooseGoalOptions()
  // {
  //   while (valid == false)
  //   {
  //     Console.WriteLine("What type of goal would you like to set up?" +
  //     "\n  1. SIMPLE GOAL: gets completed once and then checked off" +
  //     "\n  2. ETERNAL GOAL: more like a habit that should be done on a" +
  //     "\n     continuous basis and is never marked complete" +
  //     "\n  3. CHECKLIST GOAL: needs to be done a set number of times before" +
  //     "\n     being marked complete");
  //     ProcessUserChoice("goalOptions");
  //   }
  // }

  
}
using System;

//This class deals with the different menus used in the program
public class Menu
{
  private bool quit = false;
  //Setting up valid as an attribute to check if the goal options
  //menu has valid input and to repeat the menu if it doesn't
  private bool valid = false;
  public void RunInitialMenu()
  {
    do
    {
      Console.WriteLine("What would you like to do?");
      Console.WriteLine("  1. Set up new goals and rewards");
      Console.WriteLine("  2. Load a saved file");
      Console.WriteLine("  3. Quit");
      ProcessUserChoice("initialMenu");
    } while (quit == false);
  }

  public void RunMainMenu()
  {
    do
    {
      Console.WriteLine("What would you like to do?");
      Console.WriteLine("  1. Create a new goal");
      Console.WriteLine("  2. List goals");
      Console.WriteLine("  3. Save goals");
      Console.WriteLine("  4. Record an event");
      Console.WriteLine("  5. Quit");
      ProcessUserChoice("mainMenu");
    } while (quit == false);

  }

  public void ChooseGoalOptions()
  {
    while (valid == false)
    {
      Console.WriteLine("What type of goal would you like to set up?");
      Console.WriteLine("  1. Simple goal: gets completed once and then checked off\n");
      Console.WriteLine("  2. Eternal goal: more like a habit that should be done on a \n  continuous basis and is never marked complete\n");
      Console.WriteLine("  3. Checklist goal: needs to be done a set number of times before \n  being marked complete");
      ProcessUserChoice("goalOptions");
    }
  }

  private void ProcessUserChoice(string menuName)
  {
    Console.Write("\nChoice number: ");
    string userChoice = Console.ReadLine();

    switch (userChoice)
    {
      case "1":
        if (menuName == "initialMenu")
        {
          Console.WriteLine("This will eventually set up the goal program by creating goals and setting user rewards.");
        }
        if (menuName == "mainMenu")
        {
          Console.WriteLine("This will eventually allow the user to create a new goal.");
        }
        if (menuName == "goalOptions")
        {
          Console.WriteLine("This will choose simple goal as the goal option.");
          valid = true;
        }
        break;

      case "2":
        if (menuName == "initialMenu")
        {
          Console.WriteLine("This will load a saved file.");
        }
        if (menuName == "mainMenu")
        {
          Console.WriteLine("This will list the user's goals.");
        }
        if (menuName == "goalOptions")
        {
          Console.WriteLine("This will choose eternal goal as the goal option.");
          valid = true;
        }
        break;

      case "3":
        if (menuName == "initialMenu")
        {
          quit = true;
        }
        if (menuName == "mainMenu")
        {
          Console.WriteLine("This will save goals to a file.");
        }
        if (menuName == "goalOptions")
        {
          Console.WriteLine("This will choose checklist goal as the goal option.");
          valid = true;
        }
        break;

      case "4":
        if (menuName == "initialMenu" || menuName == "goalOptions")
        {
          Console.WriteLine("Sorry, that wasn't one of the options. Please select the \nnumber that corresponds to your choice.\n");
          break;
        }
        Console.WriteLine("This will record a goal event.");
        break;

      case "5":
        if (menuName == "initialMenu" || menuName == "goalOptions")
        {
          Console.WriteLine("Sorry, that wasn't one of the options. Please select the \nnumber that corresponds to your choice.\n");
          break;
        }
        quit = true;
        break;

      default:
        Console.WriteLine("Sorry, that wasn't one of the options. Please select the \nnumber that corresponds to your choice.\n");
        break;
    }

  }
}
using System;

//This class deals with the different menus used in the program
public class Menu
{
  private string _userChoice = "";
  private Rewards _rewards = new Rewards();
  private SimpleGoal _simpleGoal = new SimpleGoal();
  private EternalGoal _eternalGoal = new EternalGoal();
  private ChecklistGoal _checklistGoal = new ChecklistGoal();
  private File _file = new File();
  public void RunStartupMenu()
  {
    while (_userChoice != "1" && _userChoice != "2" && _userChoice != "3")
    {
      Console.WriteLine("What would you like to do?" +
      "\n  1. Set up new goals and rewards" +
      "\n  2. Load a saved file" +
      "\n  3. Quit");
      Console.Write("\nChoice number: ");
      _userChoice = Console.ReadLine();

      switch (_userChoice)
      {
        case "1":
          _rewards.SetUserReward();
          Console.WriteLine("Now you can set some goals and allocate how many points you would" +
          "\nlike to earn every time you accomplish a particular goal.");
          ChooseGoalOptions();
          RunMainMenu();
          break;

        case "2":
          Console.WriteLine("This will load a saved file.");
          break;

        case "3"://This will just quit the program
          break;

        default:
          Console.WriteLine("Sorry, that wasn't one of the options. Please select the \nnumber that corresponds to your choice.\n");
          break;
      }

    }
  }

  private void ChooseGoalOptions()
  {
    _userChoice = "";
    while (_userChoice != "1" && _userChoice != "2" && _userChoice != "3")
    {
      Console.WriteLine("\nWhat type of goal would you like to set up?" +
      "\n  1. SIMPLE GOAL: gets completed once and then checked off" +
      "\n  2. ETERNAL GOAL: more like a habit that should be done on a" +
      "\n     continuous basis and is never marked complete" +
      "\n  3. CHECKLIST GOAL: needs to be done a set number of times before" +
      "\n     being marked complete");
      Console.Write("\nChoice number: ");
      _userChoice = Console.ReadLine();

      switch (_userChoice)
      {
        case "1":
          _simpleGoal.SetGoal();
          break;

        case "2":
          _eternalGoal.SetGoal();
          break;

        case "3":
          _checklistGoal.SetGoal();
          break;

        default:
          Console.WriteLine("Sorry, that wasn't one of the options. Please select a number 1-3 \nthat corresponds with your goal type choice.");
          break;
      }
    }
  }
  private void RunMainMenu()
  {
    bool quit = false;
    while (quit == false)
    {
      Console.WriteLine("\nWhat would you like to do?" +
      "\n  1. Create a new goal" +
      "\n  2. List goals" +
      "\n  3. Save goals" +
      "\n  4. Record an event" +
      "\n  5. Quit");
      Console.Write("\nChoice number: ");
      string userChoice = Console.ReadLine();

      switch (userChoice)
      {
        case "1":
          ChooseGoalOptions();
          break;

        case "2":
          Console.WriteLine("This will eventually list goals.");
          break;

        case "3":
          Console.WriteLine("This will eventually save goals.");
          break;

        case "4":
          Console.WriteLine("This will eventually record an event.");
          break;

        case "5":
          quit = true;
          break;

        default:
          Console.WriteLine("Sorry, that wasn't one of the options. Please select the number 1-5 \nthat corresponds with your menu choice.");
          break;
      }
    }

  }


}
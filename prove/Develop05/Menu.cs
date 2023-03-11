using System;

//This class deals with the different menus used in the program
public class Menu
{
  private string _userChoice = "";
  private Rewards _rewards = new Rewards();
  private List<SimpleGoal> _goals = new List<SimpleGoal>();

  public void RunStartupMenu()
  {
    while (_userChoice != "1" && _userChoice != "2" && _userChoice != "3")
    {
      Console.WriteLine("What would you like to do?" +
      "\n  1. Set up new goals and rewards" +
      "\n  2. Load a saved file" +
      "\n  3. Quit");
      Console.Write("Choice number: ");
      _userChoice = Console.ReadLine();
      Console.WriteLine("");

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
      Console.Write("Choice number: ");
      _userChoice = Console.ReadLine();
      Console.WriteLine("");

      switch (_userChoice)
      {
        case "1":
          SimpleGoal simpleGoal = new SimpleGoal();
          simpleGoal.SetGoal();
          _goals.Add(simpleGoal);
          break;

        case "2":
          EternalGoal eternalGoal = new EternalGoal();
          eternalGoal.SetGoal();
          _goals.Add(eternalGoal);
          break;

        case "3":
          ChecklistGoal checklistGoal = new ChecklistGoal();
          checklistGoal.SetGoal();
          _goals.Add(checklistGoal);
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
      "\n  4. Record a goal accomplishment" +
      "\n  5. Quit");
      Console.Write("Choice number: ");
      string userChoice = Console.ReadLine();
      Console.Clear();

      switch (userChoice)
      {
        case "1":
          ChooseGoalOptions();
          break;

        case "2":
          _rewards.DisplayRewardStatus();
          DisplayGoals();
          break;

        case "3":
          SaveToFile();          
          break;

        case "4":
          DisplayGoals();
          Console.Write("Please enter the number for the goal that you accomplished: ");
          int goalSelection = Convert.ToInt32(Console.ReadLine());
          foreach (SimpleGoal goal in _goals)
          {
            if (goalSelection == (_goals.IndexOf(goal) + 1))
            {
              int points = goal.DidGoal();
              _rewards.SetCurrentPoints(points);
              Console.Clear();
              Console.WriteLine($"Good job! You got {points} points!");
            }
          }
            _rewards.DisplayRewardStatus();
          DisplayGoals();
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
  private void DisplayGoals()
  {
    Console.WriteLine("Here are your goals:");
    foreach (SimpleGoal goal in _goals)
    {
      Console.Write($"  {_goals.IndexOf(goal) + 1}. ");
      goal.DisplayGoal();
    }
  }
  private void SaveToFile()
  {
    Console.WriteLine("What would you like to call this file? (It must be a .txt file.) ");
    string fileName = Console.ReadLine();
    using (StreamWriter goalFile = new StreamWriter(fileName))
    {
      goalFile.WriteLine(_rewards.FormatForFile());
      foreach (SimpleGoal goal in _goals)
      {
        goalFile.WriteLine(goal.FormatForFile());
      }
    }
    Console.WriteLine($"\nGreat! Your goals have been saved in {fileName}.");
  }

}
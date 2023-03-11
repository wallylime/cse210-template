using System;
//This class is for goals that need to be completed
//more than once to be checked off. Extra bonus points
//are awarded when this type of goal is completely checked off.
public class ChecklistGoal : SimpleGoal
{
  private int _timesSoFar = 0;
  private int _timesToComplete;
  private int _bonusPoints;
  public ChecklistGoal()
  {
  }

  //This constructor will be used for reading strings back in from the file
  public ChecklistGoal(string goalName, string goalDescription, string pointAllocation, string isComplete, string timesSoFar, string timesToComplete, string bonusPoints) : base(goalName, goalDescription, pointAllocation, isComplete)
  {
    _timesSoFar = Convert.ToInt32(timesSoFar);
    _timesToComplete = Convert.ToInt32(timesToComplete);
    _bonusPoints = Convert.ToInt32(bonusPoints);
  }
  public override void SetGoal()
  {
    Console.Write("Enter the name of your goal: ");
    _goalName = Console.ReadLine();
    Console.WriteLine("Enter a short description of your goal: ");
    _goalDescription = Console.ReadLine();
    Console.WriteLine("How many times do you need to do this before marking it complete?");
    Console.Write("Number of times: ");
    _timesToComplete = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("How many points would you like to get each time you do this goal?");
    Console.Write("Number of points: ");
    _pointAllocation = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("When you completely finish this goal, how many bonus points would you like to get?");
    Console.Write("Number of points: ");
    _bonusPoints = Convert.ToInt32(Console.ReadLine());
  }

  public override void DisplayGoal()
  {
    if (_isComplete == false)
    {
      Console.Write("[] ");
    }
    else
    {
      Console.Write("[X] ");
    }
    Console.WriteLine($"{_goalName} ({_goalDescription}) | Currently completed: {_timesSoFar}/{_timesToComplete}");
  }
  public override int DidGoal()
  {
    //Ensuring that a user can't get points again for a goal
    //that has already been marked complete.
    if (_isComplete == true)
    {
      Console.WriteLine("Sorry, you've already marked this goal complete.");
      return 0;
    }
    else
    {
      _timesSoFar++;
      int points = _pointAllocation;
      if (_timesSoFar == _timesToComplete)
      {
        _isComplete = true;
        points += _bonusPoints;
      }
      return points;
    }
  }

  public override string FormatForFile()
  {
    return $"ChecklistGoal | {_goalName} | {_goalDescription} | {_pointAllocation} | {_isComplete} | {_timesSoFar} | {_timesToComplete} | {_bonusPoints}";
  }
}
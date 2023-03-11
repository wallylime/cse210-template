using System;

public class SimpleGoal {
  protected string _goalName;
  protected string _goalDescription;
  protected int _pointAllocation;
  protected bool _isComplete = false;

  public SimpleGoal() {
  }

//This constructor will be used for reading strings back in from the file
  public SimpleGoal(string goalName, string goalDescription, string pointAllocation, string isComplete) {
    _goalName = goalName;
    _goalDescription = goalDescription;
    _pointAllocation = Convert.ToInt32(pointAllocation);
    _isComplete = Convert.ToBoolean(isComplete);
  }

  public virtual void SetGoal()
  {
    Console.Write("Enter the name of your goal: ");
    _goalName = Console.ReadLine();
    Console.WriteLine("Enter a short description of your goal: ");
    _goalDescription = Console.ReadLine();
    Console.WriteLine("How many points would you like this goal to be worth?");
    Console.Write("Number of points: ");
    _pointAllocation = Convert.ToInt32(Console.ReadLine());
  }

public virtual void DisplayGoal() {
  if (_isComplete == false) {
    Console.Write("[] ");
  }
  else {
    Console.Write("[X] ");
  }
  Console.WriteLine($"{_goalName} ({_goalDescription})");
}

public virtual int DidGoal() {
  //Ensuring that a user can't get points again for a goal
  //that has already been marked complete.
  if (_isComplete == true) {
    return 0;
  }
  else {
     _isComplete = true;
    return _pointAllocation;
  }
}

public virtual string FormatForFile() {
  return $"SimpleGoal | {_goalName} | {_goalDescription} | {_pointAllocation} | {_isComplete}";
}

}
using System;

public class Goal {
  protected string _goalName;
  protected string _goalDescription;
  protected int _pointAllocation;
  protected bool _isComplete = false;

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

public virtual void DidGoal() {
  _isComplete = true;
}

}
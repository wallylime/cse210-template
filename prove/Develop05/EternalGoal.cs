using System;

//This type of goal never gets checked off, but does get points
//every time it is completed
public class EternalGoal : SimpleGoal
{

  public EternalGoal()
  {
  }
  //This constructor will be used for reading strings back in from the file
  public EternalGoal(string goalName, string goalDescription, string pointAllocation, string isComplete) : base(goalName, goalDescription, pointAllocation, isComplete)
  {
  }
  public override int DidGoal()
  {
    //not changing the _isComplete attribute to true
    return _pointAllocation;
  }

  public override string FormatForFile()
  {
    return $"EternalGoal | {_goalName} | {_goalDescription} | {_pointAllocation} | {_isComplete}";
  }
}
using System;

public class ChecklistGoal : Goal {

  private int _timesToComplete;
  private int _bonusPoints;
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
}
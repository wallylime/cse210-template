using System;

//Base class for the other activities
public class Activity
{
  private string _activityName;
  private string _activityDescription;
  private int _durationInSeconds;

  private DateTime _startTime;
  private DateTime _endTime;

  //Here's the constructor
  public Activity(string activityName, string activityDescription)
  {
    _activityName = activityName;
    _activityDescription = activityDescription;
  }

  protected void BeginActivity()
  {
    Console.WriteLine($"Welcome to the {_activityName}.");
    Console.WriteLine(_activityDescription);
    GetDuration();
    Console.WriteLine("Get ready...");
    PauseAnimation(3);
    _startTime = DateTime.Now;
    _endTime = _startTime.AddSeconds(_durationInSeconds);
  }

  protected void EndActivity()
  {
    Console.WriteLine("Well done!");
    PauseAnimation(1);
    Console.WriteLine($"You have completed {_durationInSeconds} seconds of the {_activityName}.");
    PauseAnimation(1);
  }
  private void GetDuration()
  {
    Console.WriteLine("How long, in seconds, would you like your session to last?");
    string durationResponse = Console.ReadLine();
    _durationInSeconds = int.Parse(durationResponse);
  }
  private void PauseAnimation(int iterations)
  {
    for (int i = 0; i < iterations; i++)
    {
      for (int j = 0; j < 3; j++)
      {
        Console.Write("<");
        Thread.Sleep(400);
      }
      for (int k = 0; k < 3; k++)
      {
        Console.Write(">");
        Thread.Sleep(400);
      }
      Thread.Sleep(500);
      Console.Write("\b\b\b\b\b\b      \b\b\b\b\b\b");
      Thread.Sleep(500);
    }
  }
  public void Countdown() {
    for (int i = 5; i > 0; i--)
    {
      Console.Write(i);
      Thread.Sleep(1000);
      Console.Write("\b \b");
    }
  }
}
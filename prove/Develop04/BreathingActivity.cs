using System;

public class BreathingActivity : Activity
{

  //Here's the constructor
  public BreathingActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
  {
  }

  public void RunBreathingActivity()
  {
    BeginActivity();
    /*
    Trying to increase duration time accuracy with the if loop in the middle of this while
    loop. I used to have one function named breathe that did both breathe in and breathe
    out, but I realized that it messed with the accuracy of the activity time since each time
    the function was called, it would do 10 seconds (even if the user selected a time period
    of 5 or 25 seconds, for example). The time still isn't perfect, since the user could select
    something weird like 4 seconds and the breathing would still run for 5 seconds. I don't think
    there's a good way to get around this and still have the countdown timer.
    */
    while (DateTime.Now < _endTime)
    {
      BreatheIn();
      if (DateTime.Now < _endTime)
      {
        BreatheOut();
      }
    }
    EndActivity();
  }
  private void BreatheIn()
  {
    Console.Write("\nSlowly breathe in...");
    Countdown();
  }

  private void BreatheOut()
  {
    Console.Write("\nSlowly breathe out...");
    Countdown();
    Console.WriteLine("");
  }

}
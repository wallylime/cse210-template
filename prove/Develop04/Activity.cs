using System;

//Base class for the other activities
public class Activity {
  private string _activityName;
  private string _activityDescription;
  private int _durationInSeconds;

  private DateTime startTime;
  private DateTime futureTime;

  private DateTime currentTime;

  //Here's the constructor
  public Activity(string activityName, string activityDescription) {
    _activityName = activityName;
    _activityDescription = activityDescription;
  }

  public void BeginActivity() {
    Console.WriteLine($"Welcome to the {_activityName}.");
    Console.WriteLine(_activityDescription);
    GetDuration();
    //This next line is for testing:
    Console.WriteLine(_durationInSeconds);
    Console.WriteLine("Get ready!");
    PauseAnimation();
  }
  private void GetDuration() {
    Console.WriteLine("How long, in seconds, would you like your session to last?");
    string durationResponse = Console.ReadLine();
    _durationInSeconds = int.Parse(durationResponse);
  }
  private void PauseAnimation() {
    for (int i = 0; i < 3; i++) {
      for (int j = 0; j < 3; j++) {
        Console.Write("<");
        Thread.Sleep(400);
      }
      for (int k = 0; k < 3; k++) {
        Console.Write(">");
        Thread.Sleep(400);
      }
      Thread.Sleep(500);
      Console.Write("\b\b\b\b\b\b      \b\b\b\b\b\b");
      Thread.Sleep(500);
    }
    
  }
}
using System;

//Base class for the other activities
public class Activity {
  private string _activityName;
  private string _activityDescription;
  private string _closingMessage = "Well done! You have completed ";
  private int _durationInSeconds;

  //Here's the constructor; commenting out to test just the pause animation.
  // public Activity(string activityName, string activityDescription) {
  //   _activityName = activityName;
  //   _activityDescription = activityDescription;
  // }

  public void BeginActivity() {
    Console.WriteLine($"Welcome to the {_activityName}.");
    Console.WriteLine(_activityDescription);
    GetDuration();
    Console.WriteLine("Get ready!");
    // DateTime startTime = DateTime.Now;
    // DateTime futureTime = startTime.add
  }
  private void GetDuration() {
    Console.WriteLine("How long, in seconds, would you like your session to last?");
    string durationResponse = Console.ReadLine();
    _durationInSeconds = int.Parse(durationResponse);
  }

  //Temporarily making this public in order to test my animation
  public void PauseAnimation() {
    for (int i = 0; i < 3; i++) {
      for (int j = 0; j < 3; j++) {
        Console.Write("-");
        Thread.Sleep(300);
      }
      Console.Write(">");
      Thread.Sleep(500);
      Console.Write("\b\b\b\b    \b\b\b\b");
      Thread.Sleep(500);
    }
    
  }
}
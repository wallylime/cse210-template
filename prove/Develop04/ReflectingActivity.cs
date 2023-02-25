using System;

public class ReflectingActivity : Activity {
  
  //The count attribute is for going through the prompts so that they aren't repeated
  //as they might be with the random number generator.
  private int count = 0;
  private string[] _prompts = {"Think of a time when you stood up for someone else.",
  "Think of a time when you did something really difficult.",
  "Think of a time when you helped someone in need",
  "Think of a time when you did something truly selfless"};
  

  //Here's the constructor
  public ReflectingActivity(string activityName, string activityDescription) : base(activityName, activityDescription) {
  }

  public void RunReflectingActivity() {
    Console.Clear();
    BeginActivity();
    while (DateTime.Now < _endTime) {
      Console.WriteLine("\nConsider the following prompt: \n");
      GetPrompt();
      Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
      //I don't need to save the user's response or compare it to anything. I'm just
      //making sure the program doesn't continue until the user hits enter.
      Console.ReadLine();
      Console.WriteLine("Now ponder on the following questions as they relate to the experience.");
      Console.Write("\nYou may begin in...");
      Countdown();
    }
    EndActivity();
  }
  private void GetPrompt()
  {
    if (count < _prompts.Length) {
      string prompt = _prompts[count];
      Console.WriteLine($">>>{prompt}<<<");
      count++;
    }
    else {
      Console.WriteLine("You have reflected on all of the prompts that we currently have available.");
      Console.WriteLine("We will restart with the first prompt.");
      count = 0;
    }
  }
}
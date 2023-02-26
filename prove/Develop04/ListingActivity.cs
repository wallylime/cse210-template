using System;

public class ListingActivity : Activity
{

  //This will keep track of how many items the user lists
  private int _count = 0;
  private string[] _prompts = {"Who are people that you appreciate?",
  "What are personal strengths of yours?",
  "Who are people that you have helped this week?",
  "When have you felt the Holy Ghost this month?",
  "Who are some of your personal heroes?"};
  //Here's the constructor
  public ListingActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
  {
  }
  public void RunListingActivity()
  {
    Console.Clear();
    BeginActivity();
    while (DateTime.Now < _endTime)
    {
      Console.WriteLine("List as many responses as you can to the following prompt: \n");
      GetPrompt();
      Console.Write("\nYou may begin in...");
      Countdown();
      Console.WriteLine("");
      while (DateTime.Now < _endTime)
      {
        Console.Write("> ");
        Console.ReadLine();
        _count++;
      }
    }
    Console.WriteLine($"\nYou listed {_count} items.");
    EndActivity();
  }

  private void GetPrompt()
  {
    Random randomGenerator = new Random();
    int randomNumber = randomGenerator.Next(0, _prompts.Length);
    string prompt = _prompts[randomNumber];
    Console.WriteLine($">>>{prompt}<<<");
  }

}
using System;

public class ReflectingActivity : Activity
{

  //The i attribute is for going through the prompts so that they aren't repeated
  //as they might be with the random number generator.
  private int _i = 0;
  //The j attribute is for going through the questions so that they aren't repeated
  private int _j = 0;
  private string[] _prompts = {"Think of a time when you stood up for someone else.",
  "Think of a time when you did something really difficult.",
  "Think of a time when you helped someone in need",
  "Think of a time when you did something truly selfless"};

  private string[] _questions = {"Why was this experience meaningful to you?",
  "Have you ever done anything like this before?",
  "How did you get started?",
  "How did you feel when it was complete?",
  "What made this time different than other times when you were not as successful?",
  "What is your favorite thing about this experience?",
  "What could you learn from this experience that applies to other situations?",
  "What did you learn about yourself through this experience?",
  "How can you keep this experience in mind in the future?"};

  //Here's the constructor
  public ReflectingActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
  {
  }

  public void RunReflectingActivity()
  {
    BeginActivity();
    while (DateTime.Now < _endTime)
    {
      Console.WriteLine("\nConsider the following prompt: \n");
      GetPrompt();
      Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
      //I don't need to save the user's response or compare it to anything. I'm just
      //making sure the program doesn't continue until the user hits enter.
      Console.ReadLine();
      Console.WriteLine("Now ponder on the following questions as they relate to the experience.");
      Console.Write("\nYou may begin in...");
      Countdown();
      Console.WriteLine("");
      while ((_j < _questions.Length) && (DateTime.Now < _endTime))
      {
        GetQuestion();
        PauseAnimation(3);
      }
    }
    EndActivity();
  }
  private void GetPrompt()
  {
    //I want to reset j which keeps track of where I'm at in the question array whenever I get a new prompt
    _j = 0;
    if (_i < _prompts.Length)
    {
      string prompt = _prompts[_i];
      Console.WriteLine($">>>{prompt}<<<");
      _i++;
    }
    else
    {
      Console.WriteLine("You have reflected on all of the prompts that we currently have available.");
      Console.WriteLine("We will restart with the first prompt.");
      _i = 0;
    }
  }

  private void GetQuestion()
  {
    string question = _questions[_j];
    Console.WriteLine($"\n> {question}");
    _j++;
  }
}
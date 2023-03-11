//Need to address the achieving of rewards better and if at target points ask to set a new user goal
//Jokes when at or passed point number
using System;

//This class keeps track of the points and rewards system
public class Rewards
{
  private int _currentPoints = 0;

  //Since I'm allowing the user to control setting the points,
  //this joke interval is kind of a wild card.
  //If the user only sets a few points per goal completion,
  //it could take a very long time to get to a joke and if they
  //set a lot of points, the jokes would have to repeat a lot.
  //I'm okay with that for now.
  private int _jokeInterval = 100;
  private int _jokeIndex = 0;
  private int _targetPoints;

  //The jokes in this array came from this source: https://www.goodhousekeeping.com/life/entertainment/a41779929/corny-jokes/?utm_source=google&utm_medium=cpc&utm_campaign=arb_ga_ghk_md_dsa_prog_org_usx_a41779929&gclid=CjwKCAiAr4GgBhBFEiwAgwORremRi9KG1_5sRuJePdaVtxg6PLjwRQhxNsCGl4tWWyEXFccpBSkCrBoCzRMQAvD_BwE
  private string[] _dadJokes = {
    "What did the horse say after it tripped?\nAnswer: Help! I've fallen and I can't giddyup! :)",
    "Why did the bicycle fall over?\nAnswer: Because it was two tired. :)",
    "Why was Cinderella so bad at soccer?\nAnswer: She kept running away from the ball! :)",
    "What did one toilet say to another?\nAnswer: You look flushed. :)",
    "What do you call an angry carrot?\nAnswer: A steamed veggie. :)",
    "What do lawyers wear to court?\nAnswer: Lawsuits. :)",
    "What's red and bad for your teeth?\nAnswer: A brick. :)",
    "Why were the fish's grades bad?\nAnswer: They were below sea level. :)",
    "What's Forrest Gump's password?\nAnswer: 1forrest1. :)",
    "What did the tomato say to the other tomato during a race?\nAnswer: Ketchup. :)"
    };
  private string _userReward = "";

  public Rewards(){
  }
//This constructor will be used for reading strings back in from the file
  public Rewards(string currentPoints, string targetPoints, string userReward) {
    _currentPoints = Convert.ToInt32(currentPoints);
    _targetPoints = Convert.ToInt32(targetPoints);
    _userReward = userReward;
  }
  public void SetUserReward()
  {
    Console.WriteLine("Set a Reward:\n" +
    "Think of something that you would like to have or do. Maybe you would" +
    "\nlike to go to the movies or buy a new pair of shoes or go on a trip, for example." +
    "\n\nPick one experience or item to use as your personal reward and enter it here: ");
    _userReward = Console.ReadLine();
    SetTargetPoints();
  }

  private void SetTargetPoints() {
    Console.WriteLine("\nHow many points would you like to reach before getting this reward?");
    Console.Write("Number of points: ");
    _targetPoints = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    Console.WriteLine($"\nGreat! When you get to {_targetPoints} points, you can reward yourself with {_userReward}.\n");
  }
  public void SetCurrentPoints(int points)
  {
    _currentPoints += points;
  }
  public void DisplayRewardStatus()
  {
    if (_currentPoints == _jokeInterval)
    {
      Console.WriteLine($"You have {_currentPoints} points.\nSurprise! You've earned a dad joke!\n");
      Console.WriteLine(_dadJokes[_jokeIndex]);
      Console.WriteLine("");
      Console.WriteLine($"{_targetPoints - _currentPoints} points left until you get {_userReward}.\n");
      _jokeInterval += 100;
      //I'm subtracting 1 from _dadJokes.Length because I realized
      //that the index could be at 9 and have 1 added to it which would
      //make it exceed the array because of the first array item being 
      //indexed at 0
      if (_jokeIndex < _dadJokes.Length - 1)
      {
        _jokeIndex += 1;
      }
      else
      {
        //Start over in the joke array
        _jokeIndex = 0;
      }
    }
    else
    {
      Console.WriteLine($"You have {_currentPoints} points.\n{_targetPoints - _currentPoints} points left until you get {_userReward}!\n");
    }
  }

  public string FormatForFile() {
    return $"{_currentPoints} | {_targetPoints} | {_userReward}";
  }
}
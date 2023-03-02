using System;

public class Rewards {
  private int _currentPoints = 0;
  private int _targetPoints = 1000;
  private string[] _jokes = {};
  private string[] _quotes = {};
  private string _userReward = "";
  public string GetUserReward() {
    return _userReward;
  }
  public void SetUserReward() {
    Console.WriteLine("Think of something that you would like to have or do. Maybe you have been wanting\nto go to the movies or buy a new pair of shoes or go on a trip, for example.\n");
    Console.WriteLine("Pick one experience or item to use as your personal reward and enter it here: ");
    _userReward = Console.ReadLine();
  }
}
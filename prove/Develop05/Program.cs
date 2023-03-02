using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Goal Quest!\n");
        Rewards rewards = new Rewards();
        if (rewards.GetUserReward() == "") {
           rewards.SetUserReward();
        }
        //Testing:
        rewards.DisplayRewardStatus();
        rewards.SetCurrentPoints(100);
        rewards.DisplayRewardStatus();
        rewards.SetCurrentPoints(150);
        rewards.DisplayRewardStatus();
        rewards.SetCurrentPoints(200);
        rewards.DisplayRewardStatus();     
    }
}
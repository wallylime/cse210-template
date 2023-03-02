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
        Console.WriteLine(rewards.GetUserReward());

     
    }
}
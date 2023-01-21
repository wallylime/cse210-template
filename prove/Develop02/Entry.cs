using System;

public class Entry
{
  public string[] _prompts = 
  {"What am I thankful for today?", 
  "Did I have any funny experiences today?", 
  "How did I see the hand of the Lord in my life today?", 
  "Who did I help today?", 
  "What was the most challenging part of my day?", 
  "What am I looking forward to in the next week?",
  "Did anyone do something nice for me today?"};

  public string GetDate() {
    return DateTime.Now.ToShortDateString();
  }

  public string GetPrompt() {
    Random randomGenerator = new Random();
    int randomNumber = randomGenerator.Next(0, 7);
    string prompt = _prompts[randomNumber];
    return prompt;
  }

}
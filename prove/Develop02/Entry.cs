using System;

public class Entry
{
  public string _date;
  public string _prompt;
  public string _response;
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
    int randomNumber = randomGenerator.Next(0, _prompts.Length);
    string prompt = _prompts[randomNumber];
    return prompt;
  }
  public void CreateEntry() {
    _date = GetDate();
    _prompt = GetPrompt();
    Console.WriteLine(_prompt);
    _response = Console.ReadLine();
  }
  public string EntryToString() {
    return $"Date: {_date}\n Prompt: {_prompt}\n Response: {_response}\n";
  }
 
}
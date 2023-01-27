using System;
public class Entry
{
  public string _date;
  public string _prompt;
  public string _response;
  public string _meals;
  public string GetDate()
  {
    return DateTime.Now.ToShortDateString();
  }
  public void CreateEntry()
  {
    _date = GetDate();
    PromptGenerator prompt = new PromptGenerator();
    _prompt = prompt.GetPrompt();
    Console.WriteLine(_prompt);
    _response = Console.ReadLine();
    Meals todaysMeals = new Meals();
    todaysMeals.GetMeals();
    _meals = todaysMeals.MealsToString();
  }
  public string EntryToString()
  {
    return $"Date: {_date}\n Prompt: {_prompt}\n Response: {_response}";
  }

}
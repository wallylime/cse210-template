using System;

public class Meals
{
  public string _breakfast;
  public string _lunch;
  public string _dinner;
  public void GetMeals()
  {
    Console.WriteLine("What did you eat for breakfast?");
    _breakfast = Console.ReadLine();
    Console.WriteLine("What did you eat for lunch?");
    _lunch = Console.ReadLine();
    Console.WriteLine("What did you eat for dinner?");
    _dinner = Console.ReadLine();
  }
  public string MealsToString()
  {
    return $"Breakfast - {_breakfast} | Lunch - {_lunch} | Dinner - {_dinner}";
  }
}
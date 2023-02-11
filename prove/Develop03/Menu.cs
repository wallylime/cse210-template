/*
This will run the main menu for the scripture memorizer.
It will show the user options and process the user's response.
*/

using System;
public class Menu
{
  private bool _quit = false;
  private Scripture scripture = new Scripture("1 Peter", "5", "6-7", "Humble yourselves therefore under the mighty hand of God, that he may exalt you in due time: Casting all your care upon him; for he careth for you.");
  public void RunMenu()
  {
    while ((_quit == false) && (scripture.GetHiddenStatus() == false))
    {
      Console.WriteLine("\nPress the Enter key to continue. Type \"quit\" to finish.");
      string userInput = Console.ReadLine();
      ProcessInput(userInput);
    }
  }
  private void ProcessInput(string userInput)
  {
    if (userInput == "")
    {
      scripture.DisplayScripture();
    }
    else if (userInput == "quit")
    {
      _quit = true;
    }
    else
    {
      Console.WriteLine("Sorry, that's not a valid response.");
    }
  }
}
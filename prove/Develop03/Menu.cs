/*
This will run the main menu for the scripture memorizer.
*/
using System;
public class Menu
{
  private bool _quit = false;
  public void RunMenu()
  {
    while (_quit == false)
    {
      Console.WriteLine("Press the Enter key to continue. Type \"quit\" to finish.");
      string userInput = Console.ReadLine();
      ProcessInput(userInput);
    }
  }
  private void ProcessInput(string userInput)
  {
    if (userInput == "")
    {
      Console.WriteLine("User has pressed enter. This will eventually do something.");
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

/*  
    using this setter for quit because I also want to set it to true once all
    of the scripture words are hidden which is handled in the scripture class
*/
  public void SetQuit(bool quit)
  {
    _quit = quit;
  }
}
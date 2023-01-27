/*Exceeded Requirements: I added a food journal component that keeps track of the user's meals for the day.*/
using System;
class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Welcome to the Journal Program!");
    JournalMenu menu = new JournalMenu();
    while (menu._quitProgram == false)
    {
      menu.ShowOptions();//Lets the user know what they can do in the program
      menu.ProcessUserInput();//Gets the user's input and does the requested action 
    }

  }
}
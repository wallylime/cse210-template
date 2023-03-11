//This is my goal program.
/*Exceeded requirements by:
-adding user-selected reward & target number of points
-adding surprise joke rewards every 100 points
-checks to make sure that a user hasn't already marked
 a goal complete before awarding points
-additional menu at the start of the program to make the
 menu options make more sense */
using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Welcome to Goal Quest!\n");
    Menu menu = new Menu();
    menu.RunStartupMenu();
  }

}
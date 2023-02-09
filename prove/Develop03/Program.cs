/*
This program is for memorizing scriptures by taking out a few
words at a time until all of the words are hidden.
*/

using System;
class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Welcome to the scripture memorizer!");
    Menu menu = new Menu();
    menu.RunMenu();
  }
}
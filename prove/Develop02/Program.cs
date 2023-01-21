using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Menu menu = new Menu();
        menu.ShowOptions();
        string userInput = Console.ReadLine();
        if (userInput == "1") {
            menu.WriteEntry();
        }
        else if (userInput == 2) {
            menu.DisplayEntries();
        }
        else if (userInput == 3) {
            menu.LoadFile();
        }
        else if (userInput == 4) {
            menu.SaveFile();
        }
        else if (userInput == 5) {
            menu.QuitProgram();
        }
        else {
            Console.Write("Sorry, that wasn't one of the menu options. Please type a number 1-5 and hit enter.");
        }
}
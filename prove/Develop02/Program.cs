using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        JournalMenu menu = new JournalMenu();
        while (menu._quitProgram == false) {
            menu.ShowOptions();//Lets the user know what they can do in the program
            menu.ProcessUserInput();//Gets the user's input and does the requested action 
        }
        
    }
}
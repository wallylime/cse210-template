/*In addition to the core requirements, I tried to improve the user-friendliness of this program. For example, I added an "else" condition for an improper response to the menu options that lets the user know that they need to type a number 1-5. I display the entries when loading the file. I give the user a message letting them know that their file has been saved. I also did things with formatting and white space to make it look better in the terminal.*/
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Menu menu = new Menu();
        bool isDone = false;
        while (!menu.isDone)
        {
            menu.ShowOptions();//Lets the user know what they can do in the program
            menu.ProcessUserInput();//Gets the user's input and does the requested action
        }
    }
}
using System;
public class Menu
{
  public string _fileName = "";

  public void ShowOptions(){
    Console.WriteLine("What would you like to do? Please select from one of the following options:");
    Console.WriteLine("1. Write a journal entry");
    Console.WriteLine("2. Display your journal entries");
    Console.WriteLine("3. Load your file");
    Console.WriteLine("4. Save your file");
    Console.WriteLine("5. Quit this program");
  }
  public void WriteEntry() {
    Console.Write("This will eventually be for writing an entry.");
  }

  public void DisplayEntries() {
    Console.Write("This will eventually display the entries.");
  }

  public void LoadFile() {
    Console.Write("This will eventually load the file.");
  }

  public void SaveFile() {
    Console.Write("This will eventually save the file.");
  }

  public void QuitProgram() {
    Console.Write("Thanks for using this journal program.");
  }
}
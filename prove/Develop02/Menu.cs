using System;
public class Menu
{
  public string _fileName = "";
  public List<string> _entries = new List<string>();

  public void ShowOptions(){
    Console.WriteLine("What would you like to do? Please select from one of the following options:");
    Console.WriteLine("1. Write a journal entry");
    Console.WriteLine("2. Display your journal entries");
    Console.WriteLine("3. Load your file");
    Console.WriteLine("4. Save your file");
    Console.WriteLine("5. Quit this program");
  }

  public void ProcessUserInput() {
    string userInput = Console.ReadLine();
      if (userInput == "1") {
        WriteEntry();
      }
      else if (userInput == "2") {
        DisplayEntries();
      }
      else if (userInput == "3") {
        LoadFile();
      }
      else if (userInput == "4") {
        SaveFile();
      }
      else if (userInput == "5") {
        QuitProgram();
      }
      else {
        Console.Write("Sorry, that wasn't one of the menu options. Please type a number 1-5 and hit enter: ");
        ProcessUserInput();
      }
  }
  public void WriteEntry() {
    Entry newEntry = new Entry();
    string date = newEntry.GetDate();
    string prompt = newEntry.GetPrompt();
    Console.WriteLine(prompt);
    string userEntry = Console.ReadLine();
    string completeEntry = $"\n Date: {date} - Prompt: {prompt} \n {userEntry} \n";
    _entries.Add(completeEntry);
    ShowOptions();
    ProcessUserInput();
  }
  public void DisplayEntries() {
    foreach (string entry in _entries) {
      Console.Write(entry);
    }
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
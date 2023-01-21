using System.IO;
public class Menu
{
  public List<string> _entries = new List<string>();

  public void ShowOptions(){
    Console.WriteLine("\nWhat would you like to do? Please select from one of the following options:");
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
        ProcessUserInput();//Allows the user to try again if they have entered something other than 1,2,3,4, or 5
      }
  }
  public void WriteEntry() {
    Entry newEntry = new Entry();
    string date = newEntry.GetDate();
    string prompt = newEntry.GetPrompt();
    Console.WriteLine(prompt);
    string userEntry = Console.ReadLine();
    string completeEntry = $"\nDate: {date} \n Prompt: {prompt} \n Response: {userEntry}";
    _entries.Add(completeEntry);
    ShowOptions();
    ProcessUserInput();
  }
  public void DisplayEntries() {
    foreach (string entry in _entries) {
      Console.WriteLine(entry);
    }
    ShowOptions();
    ProcessUserInput();
  }

  public void LoadFile() {
    Console.WriteLine("What file would you like to load: ");
    string fileName = Console.ReadLine();
    string[] fileEntries = System.IO.File.ReadAllLines(fileName);
    _entries.Clear(); 
    /*Because a user has the option to just write and display without saving to a file or loading a file, I add each new entry to the entries list. However, if the user later decides to save, then the entries loaded from the file will just get added to the list making duplicates. That's why I'm clearing the list before adding the entries from the file.*/
    foreach (string entry in fileEntries)
    {
      _entries.Add(entry);
    }
    DisplayEntries();
    /*The video demo doesn't display the entries after loading the file; it makes the user type the display command after loading the file. However, I think that this isn't user-friendly design. If the user wants to load the file, guaranteed they want to see what's in the file. Why make them type another command? Not having the load command do anything that the user can see also makes the user feel like the load command didn't work. That's why I'm including the display method here.*/
  }
  public void SaveFile() {
    Console.WriteLine("What would you like to call this file? (It must be a .txt file.) ");
    string fileName = Console.ReadLine();
    using (StreamWriter journalFile = new StreamWriter(fileName))
    {
      foreach (string entry in _entries) {
        journalFile.WriteLine(entry);
      }
    }
    Console.WriteLine($"\nGreat! Your entries have been saved in {fileName}");
    /*I feel like users need some confirmation that something actually happened; that's why I've included this message.*/
    ShowOptions();
    ProcessUserInput();
  }
  public void QuitProgram() {
    Console.Write("Thanks for using this journal program.");
  }
}
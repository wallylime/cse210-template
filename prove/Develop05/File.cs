using System;

//This class handles saving to file & loading from file
public class File {
  // public void SaveFile()
  // {
  //   Console.WriteLine("What would you like to call this file? (It must be a .txt file.) ");
  //   string fileName = Console.ReadLine();
  //   using (StreamWriter journalFile = new StreamWriter(fileName))
  //   {
  //     foreach (Entry entry in _entries)
  //     {
  //       journalFile.WriteLine(entry._date);
  //       journalFile.WriteLine(entry._prompt);
  //       journalFile.WriteLine(entry._response);
  //       journalFile.WriteLine(entry._meals);
  //     }
  //   }
  //   Console.WriteLine($"\nGreat! Your entries have been saved in {fileName}.");
  // }

  // public void LoadFile()
  // {
  //   Console.Write("\nWhat file would you like to load: ");
  //   string fileName = Console.ReadLine();
  //   string[] fileEntries = System.IO.File.ReadAllLines(fileName);
  //   _entries.Clear();//Because a user has the option to just write and display without saving to a file or loading a file, I add each new entry to the entries list. However, if the user later decides to save, then the entries loaded from the file will just get added to the list making duplicates. That's why I'm clearing the list before adding the entries from the file.
  //   for (int i = 0; i < fileEntries.Length; i += 4)//Incrementing by 4 because each entry is stored on four lines in this order: date, prompt, response, meals
  //   {
  //     Entry newEntry = new Entry();
  //     newEntry._date = fileEntries[i];
  //     newEntry._prompt = fileEntries[i + 1];
  //     newEntry._response = fileEntries[i + 2];
  //     newEntry._meals = fileEntries[i + 3];
  //     _entries.Add(newEntry);
  //   }
  //   DisplayEntries();
  //   //The video demo doesn't display the entries after loading the file; it makes the user type the display command after loading the file. However, I think that this isn't user-friendly design. If the user wants to load the file, guaranteed they want to see what's in the file. Why make them type another command? Not having the load command do anything that the user can see also makes the user feel like the load command didn't work. That's why I'm including the display method here.
  // }
}
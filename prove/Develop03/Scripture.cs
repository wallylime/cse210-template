/*
Most of the program is here in the scripture class.
*/
using System;

public class Scripture
{
  private Reference _reference;
  private List<Word> _verseText = new List<Word>();
  private bool _isAllHidden = false;
  private List<int> _numbersChosen = new List<int>();//stretch challenge to keep track of what words are already hidden and not rehide randomly

  //Use this constructor to get all the parts that we need
  public Scripture(string book, string chapter, string verses, string verseText)
  {
    _reference = new Reference(book, chapter, verses);
    string[] verseWords = verseText.Split(" ");
    foreach (string verseWord in verseWords)
    {
      Word word = new Word(verseWord);
      _verseText.Add(word);
    }
  }
  public void DisplayScripture()
  {
    CheckAllHidden();
    Console.Clear();
    Console.WriteLine(_reference.GetReference());
    foreach (Word word in _verseText)
    {
      if (word.GetIsHidden() == true)
      {
        Console.Write($"{word.HideWord()} ");
      }
      else
      {
        Console.Write($"{word.GetWord()} ");
      }
    }
    HideWords();
  }
    private void HideWords()//I will hide three words at a time
    {
      _verseText[GetRandomNumber()].SetIsHidden(true);
      _verseText[GetRandomNumber()].SetIsHidden(true);
      _verseText[GetRandomNumber()].SetIsHidden(true);
    }
  private int GetRandomNumber()
  {
    Random randomGenerator = new Random();
    int randomNumber;
    do {
      randomNumber = randomGenerator.Next(0, _verseText.Count());
    }
    while (_numbersChosen.Contains(randomNumber));//if the number is already in the list, get a new random number
    _numbersChosen.Add(randomNumber);
    return randomNumber;
  }
  private void CheckAllHidden() {
    if (_numbersChosen.Count() == _verseText.Count()) {
      _isAllHidden = true;
    }
  }
    public bool GetHiddenStatus()
    {
      return _isAllHidden;
    }
  }
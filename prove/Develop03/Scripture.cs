/*
This is for everything to do with the scripture.
*/
using System;

public class Scripture
{
  private Reference _reference;
  private List<Word> _verseText = new List<Word>();
  private bool _isAllHidden = false;
  /*
  The following list is for use with the random number generator
  to keep track of which words have already been hidden for the
  stretch challenge and is also used to compare with the _verseText
  list for an easy way to know when all of the words are hidden.
  */
  private List<int> _numbersChosen = new List<int>();

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
  private void HideWords()
  {
    if (_numbersChosen.Count() == _verseText.Count())
    {
      _isAllHidden = true;
    }
    else
    {
      for (int i = 0; i < 2; i++)
      {
        _verseText[GetRandomNumber()].SetIsHidden(true);
      }
    }
  }
  private int GetRandomNumber()
  {
    Random randomGenerator = new Random();
    int randomNumber;
    do
    {
      randomNumber = randomGenerator.Next(0, _verseText.Count());
    }
    while (_numbersChosen.Contains(randomNumber));//if the number is already in the list, get a new random number
    _numbersChosen.Add(randomNumber);
    return randomNumber;
  }
  public bool GetHiddenStatus()
  {
    return _isAllHidden;
  }
}
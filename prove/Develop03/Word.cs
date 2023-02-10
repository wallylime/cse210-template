/*
This part of the program deals with the details of each individual word
*/
using System;

public class Word
{
  private string _word;
  /*all words should be displayed initially
  so setting below bool to false*/
  private bool _isHidden = false;
  /*
  Constructor below has a word parameter,
  eliminating the need for a word setter
  */
  public Word(string word)
  {
    _word = word;
  }
  public void SetIsHidden(bool isHidden) {
    _isHidden = isHidden;
  }
  public bool GetIsHidden()
  {
    return _isHidden;
  }
  public string GetWord()
  {
    return _word;
  }
  public string HideWord()
  {
    string hiddenWord = "";
    for (int i = 0; i < _word.Length; i++)
    {
      char character = _word[i];
      bool letter = Char.IsLetter(character);
      if (letter)
      {
        hiddenWord += "_";
      }
      else
      {
        hiddenWord += character;
      }
    }
    return hiddenWord;
  }
}
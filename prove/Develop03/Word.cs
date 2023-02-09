/*
This part of the program deals with the details of each word,
such as hiding it and knowing whether it is hidden.
*/
using System;

public class Word {
  private string _word;
  /*
  Giving _isHidden a value of false to begin with since I will
  want all of the words to be displayed initially
  */
  private bool _isHidden = false;
  public Word(string word) {
    _word = word;
  }
  public string GetWord() {
    return _word;
  }
  // public void SetHidden(bool hidden) {
  //   _isHidden = hidden;
  // }
public bool GetHidden() {
  return _isHidden;
}
  public string HideWord() {
    string hiddenWord = "";
    for (int i=0; i < _word.Length; i++) {
      char character = _word[i];
      bool letter = Char.IsLetter(character);
      if (letter) {
        hiddenWord += "_";
      }
      else {
        hiddenWord += character;
      }
    }
    _isHidden = true;
    return hiddenWord;
  }
}
/*
This part of the program only deals with the scripture reference.
*/
using System;
public class Reference {
  private string _book;
  private string _chapter;
  private string _verses;
  
  public Reference(string book, string chapter, string verses) {
    _book = book;
    _chapter = chapter;
    _verses = verses;
  }

  /*
  I know that the assignment wanted us to use getters and setters, so I've shown how I would do the setters below. However, these aren't necessary because of the way that I've set up the Reference constructor so that it requires book, chapter, and verses as arguments. If the nature of the program were such that the _book, _chapter, or _verses might need to be set to something else later, I would keep these. But that is unnecessary in this program.

  public void SetBook(string book) {
    _book = book;
  }
  public void SetChapter(string chapter) {
    _chapter = chapter;
  }
  public void SetVerses(string verses) {
    _verses = verses;
  }
  */
  public string GetReference() {
    return $"{_book} {_chapter}:{_verses}";
  }
}
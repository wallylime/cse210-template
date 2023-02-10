/*
This part of the program only deals with the scripture reference.
*/
using System;
public class Reference
{
  private string _book;
  private string _chapter;

  /*
  I'm choosing to store multiple verses the way that
  we would normally write them (for example: 6-9);
  this will be a string parameter in the constructor.
  */
  private string _verses;

  /*
  Constructor has parameters for each attribute and
  since the attributes don't need to change, I'm
  not using any setters.
  */
  public Reference(string book, string chapter, string verses)
  {
    _book = book;
    _chapter = chapter;
    _verses = verses;
  }
  public string GetReference()
  {
    return $"{_book} {_chapter}:{_verses}";
  }
}
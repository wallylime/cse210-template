/*
This will deal with the actual scripture.
*/
using System;

public class Scripture {
  private Reference _reference;
  // private List<Word> _verseText = new List<Word>();  
  // private bool _isAllHidden = false;//Later when I add the logic for being able to tell if every word is hidden, I will set the quit variable from menu to true
  // public void AddVerseText() {

  // }

//Use this constructor to get all the parts that we need
public Scripture(string book, string chapter, string verses, string verseText) {
  _reference = new Reference(book, chapter, verses);
}

public void TestReference() {
  Console.WriteLine(_reference.GetReference());
}
 
}
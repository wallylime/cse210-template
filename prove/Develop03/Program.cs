/*
This program is for memorizing scriptures by taking
out a few words at a time until all of the words are hidden.
In the instructions, it says "When selecting the random words
to hide, for the core requirements, you can select any word at
random, even if the word was already hidden. (As a stretch challenge,
try to randomly select from only those words that are not already hidden.)"
That's what I chose for my stretch challenge. In addition, I kept the
punctuation in the verse, rather than having it show up as an underscore
which doesn't make sense (but that's how he had it in the video).
*/

using System;
class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Welcome to the scripture memorizer!");
    Menu menu = new Menu();
    menu.RunMenu();
  }
}
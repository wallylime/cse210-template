using System;

public class Fraction {

  private int _top;
  private int _bottom;

  public Fraction() {
    _top = 1;
    _bottom = 1;
  }

  public Fraction(int top) {
    _top = top;
    _bottom = 1;
  }

  public Fraction(int top, int bottom) {
    _top = top;
    _bottom = bottom;
  }

  public void GetTop() {
    Console.WriteLine(_top);
  }

  public void SetTop(int top) {
    _top = top;
  }
  public void GetBottom() {
    Console.WriteLine(_bottom);
  }

  public void SetBottom(int bottom) {
    _bottom = bottom;
  }
  public string GetFractionString() {
    return $"{_top}/{_bottom}";
  }
  public double GetDecimalValue() {
    return (double)_top/_bottom;//Note to self: After my first test, I discovered that you can't divide two integers and get a decimal
  }
}
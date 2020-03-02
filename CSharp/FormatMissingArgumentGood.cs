using System;

class FormatMissingArgumentGood
{
  void Hello(string first, string last) {
    Console.WriteLine("Hello {0} {1}", first, last);
  }
}

using System;
using System.IO;

class MissingDisposeCallGood : IDisposable {
  private FileStream stream1 = new FileStream("a.txt", FileMode.Open);
  private FileStream stream2 = new FileStream("b.txt", FileMode.Open);

  public void Dispose() {
    stream1.Dispose();
    stream2.Dispose();
  }
}

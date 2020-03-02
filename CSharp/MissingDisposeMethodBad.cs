using System;
using System.IO;

class MissingDisposeMethodBadBase : IDisposable {
  private FileStream stream1 = new FileStream("a.txt", FileMode.Open);

  public virtual void Dispose() {
    stream1.Dispose();
  }
}

class MissingDisposeMethodBad : MissingDisposeMethodBadBase
{
  private FileStream stream2 = new FileStream("b.txt", FileMode.Open);
}

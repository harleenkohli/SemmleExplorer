using System;
using System.IO;

class MissingDisposeMethodGoodBase : IDisposable {
  private FileStream stream1 = new FileStream("a.txt", FileMode.Open);

  public virtual void Dispose() {
    stream1.Dispose();
  }
}

class MissingDisposeMethodGood : MissingDisposeMethodGoodBase
{
  private FileStream stream2 = new FileStream("b.txt", FileMode.Open);

  public override void Dispose() {
    base.Dispose();
    stream2.Dispose();
  }
}

using System;

class InconsistentEqualsGetHashCodeBad
{
  private int id;

  public InconsistentEqualsGetHashCodeBad(int Id) { this.id = Id; }

  public override bool Equals(object other) {
    if (other is InconsistentEqualsGetHashCodeBad b && b.GetType() == typeof(InconsistentEqualsGetHashCodeBad))
      return this.id == b.id;
    return false;
  }
}

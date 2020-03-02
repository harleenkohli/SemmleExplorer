using System;

class InconsistentEqualsGetHashCodeGood
{
  private int id;

  public InconsistentEqualsGetHashCodeGood(int Id) { this.id = Id; }

  public override bool Equals(object other) {
    if (other is InconsistentEqualsGetHashCodeGood b && b.GetType() == typeof(InconsistentEqualsGetHashCodeGood))
      return this.id == b.id;
    return false;
  }

  public override int GetHashCode() => id;
}

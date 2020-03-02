using System;

class IncorrectCompareToSignatureGood : IComparable<IncorrectCompareToSignatureGood> {
  public int CompareTo(IncorrectCompareToSignatureGood g) => 0;
}

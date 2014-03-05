using System;

namespace Algorithms.Sorting
{
  interface ILinearSort
  {
    void Sort<T>(T[] a) where T : IComparable<T>;
  }
}

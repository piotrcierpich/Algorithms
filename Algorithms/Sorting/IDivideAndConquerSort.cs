using System;

namespace Algorithms.Sorting
{
  interface IDivideAndConquerSort
  {
    T[] Sort<T>(T[] a) where T : IComparable<T>;
    void SortInPlace<T>(T[] a) where T : IComparable<T>;
  }
}
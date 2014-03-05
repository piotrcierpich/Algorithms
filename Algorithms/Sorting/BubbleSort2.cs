using System;

namespace Algorithms.Sorting
{
  /// <summary>
  /// enhanced bubble sort where limiting condition is that if no swaps occured in the last iteration, the algorithm ceases
  /// after each iteration, last element contains least element
  /// </summary>
  class BubbleSort2 : ILinearSort
  {
    public void Sort<T>(T[] a) where T : IComparable<T>
    {
      for (int i = a.Length - 1; i >= 0; i--)
      {
        bool swapsOccured = false;
        for (int j = 0; j < i; j++)
        {
          if (a[j].CompareTo(a[j + 1]) <= 0)
            continue;

          a.Swap(j, j + 1);
          swapsOccured = true;
        }

        if (!swapsOccured)
          return;
      }
    }
  }
}

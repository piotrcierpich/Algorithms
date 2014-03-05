using System;

namespace Algorithms.Sorting
{
  /// <summary>
  /// search of least element in an array and swap with first position. Then search of second least element
  /// in the array except first element (which is already least) and swap with second element and so on and so forth
  /// After each iteration until index i all elements are sorted (and placed in the right position)
  /// </summary>
  class SelectionSort : ILinearSort
  {
    public void Sort<T>(T[] a) where T : IComparable<T>
    {
      for (int i = 0; i < a.Length; i++)
      {
        int leastIndex = i;
        for (int j = i + 1; j < a.Length; j++)
        {
          if (a[j].CompareTo(a[leastIndex]) < 0)
            leastIndex = j;
        }

        a.Swap(i, leastIndex);
      }
    }
  }
}

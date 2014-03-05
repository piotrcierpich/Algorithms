using System;

namespace Algorithms.Sorting
{
  /// <summary>
  /// double loop swaping elements if needed
  /// </summary>
  class BubbleSort : ILinearSort
  {
    public void Sort<T>(T[] a) where T : IComparable<T>
    {
      for (int i = 0; i < a.Length; i++)
      {
        for (int j = 0; j < a.Length - 1; j++)
        {
          if (a[j + 1].CompareTo(a[j]) < 0)
            a.Swap(j + 1, j);
        }
      }
    }
  }
}

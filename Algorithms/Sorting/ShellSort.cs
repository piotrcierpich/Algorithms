using System;

namespace Algorithms.Sorting
{
  class ShellSort : IDivideAndConquerSort
  {
    public void SortInPlace<T>(T[] a) where T : IComparable<T>
    {
      throw new NotImplementedException();
    }

    public T[] Sort<T>(T[] a) where T : IComparable<T>
    {
      int N = a.Length;
      int h = 1;
      while (h < N/3)
      {
        h = 3*h + 1; // 1, 4, 13, 40, 121, 364, 1093, ...
      }

      while (h >= 1)
      {
        // h-sort the array.
        for (int i = h; i < N; i++)
        {
          // insertion sort - instead of step 1 while inserting, the step is h
          // Insert a[i] among a[i-h], a[i-2*h], a[i-3*h]... .
          for (int j = i; j >= h && a[j].CompareTo(a[j - h]) < 0; j -= h)
            a.Swap(j, j - h);
        }
        h = h/3;
      }

      return a;
    }
  }
}

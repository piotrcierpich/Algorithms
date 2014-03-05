using System;

namespace Algorithms.Sorting
{
  internal class Quicksort : IDivideAndConquerSort
  {
    T[] IDivideAndConquerSort.Sort<T>(T[] a) 
    {
      throw new NotImplementedException();
    }

    public void SortInPlace<T>(T[] a) where T : IComparable<T>
    {
      Sort(a, 0, a.Length - 1);
    }

    private void Sort<T>(T[] a, int low, int high) where T : IComparable<T>
    {
      if (low >= high)
        return;

      int j = Partition(a, low, high);
      Sort(a, low, j - 1);
      Sort(a, j + 1, high);
    }

    private int Partition<T>(T[] a, int low, int high) where T : IComparable<T>
    {
      int i = low + 1;
      int j = high;

      T pivot = a[low];

      while (true)
      {
        while (a[i].CompareTo(pivot) < 0)
        {
          i++;
        }
        while (a[j].CompareTo(pivot) > 0)
        {
          j--;
        }

        if (i >= j)
          break;

        a.Swap(i, j);
      }

      a.Swap(low, j);
      return j;
    }
  }
}
using System;

namespace Algorithms.Sorting
{
  /// <summary>
  /// 1. partition. take first element value (pivot) and start from right and left side searching 
  /// and swapping like this:
  /// 1.1 from the left (skipping first element e.g. pivot) search until finding element greater than pivot
  /// 1.2 starting from the right search for the first element less than pivot
  /// 2. swap elements found in 1.1 and 1.2
  /// 3. continue until indices from 1.1 and 1.2 intersect e.g. 1.1 index >= 1.2 index
  /// 4. swap pivot element with element at 1.2 index
  /// 5. recursively call sort for both partitioned sides
  /// </summary>
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
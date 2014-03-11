using System;

namespace Algorithms.Sorting
{
  class HeapSort : ILinearSort
  {
    public void Sort<T>(T[] a) where T : IComparable<T>
    {
      // copy to array with length +1 with empty first element
      T[] a1 = new T[a.Length + 1];
      for (int i = 0; i < a.Length; i++)
      {
        a1[i + 1] = a[i];
      }

      // heapify
      for (int k = a1.Length / 2; k >= 1; k--)
      {
        Sink(a1, k, a.Length);
      }

      // delete maximum
      int N = a.Length;
      while (N > 1)
      {
        // swap current maximum, so the top of the heap, with the 
        a1.Swap(1, N--);
        Sink(a1, 1, N);
      }

      for (int i = 1; i < a1.Length; i++)
      {
        a[i - 1] = a1[i];
      }
    }

    private void Sink<T>(T[] a1, int i, int N) where T : IComparable<T>
    {
      while (2 * i <= N)
      {
        int j = 2 * i;
        // select which of two leafs of a1[i] is greater
        if (j < N && Less(a1[j], a1[j + 1]))
          j++;

        if (Less(a1[i], a1[j]))
        {
          a1.Swap(i, j);
          i = j;
        }
        else
        {
          break;
        }
      }
    }

    private bool Less<T>(T comparable, T comparable1) where T : IComparable<T>
    {
      return comparable.CompareTo(comparable1) < 0;
    }
  }
}

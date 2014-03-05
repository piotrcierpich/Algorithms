using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Sorting
{
  internal class MergeSort : IDivideAndConquerSort
  {
    public T[] Sort<T>(T[] a) where T : IComparable<T>
    {
      if (a.Length == 1)
        return a;

      int middle = a.Length / 2;
      T[] left = a.Take(middle).ToArray();
      T[] right = a.Skip(middle).ToArray();

      T[] sortedLeft = Sort(left);
      T[] sortedRight = Sort(right);
      T[] merged = Merge(sortedLeft.AsEnumerable(), sortedRight).ToArray();
      return merged;
    }

    void IDivideAndConquerSort.SortInPlace<T>(T[] a)
    {
      throw new NotImplementedException();
    }

    private IEnumerable<T> Merge<T>(IEnumerable<T> a, IEnumerable<T> b) where T : IComparable<T>
    {
      using (IEnumerator<T> aEnumerator = a.GetEnumerator())
      {
        using (IEnumerator<T> bEnumerator = b.GetEnumerator())
        {
          bool aHasElements = aEnumerator.MoveNext();
          bool bHasElements = bEnumerator.MoveNext();

          while (true)
          {
            if (aHasElements && bHasElements)
            {
              if (aEnumerator.Current.CompareTo(bEnumerator.Current) < 0)
              {
                yield return aEnumerator.Current;
                aHasElements = aEnumerator.MoveNext();
              }
              else
              {
                yield return bEnumerator.Current;
                bHasElements = bEnumerator.MoveNext();
              }
            }
            else if (aHasElements)
            {
              yield return aEnumerator.Current;
              aHasElements = aEnumerator.MoveNext();
            }
            else if (bHasElements)
            {
              yield return bEnumerator.Current;
              bHasElements = bEnumerator.MoveNext();
            }
            else
            {
              break;
            }
          }
        }
      }
    }

    // alternative merge
    private T[] Merge<T>(T[] a, T[] b) where T : IComparable<T>
    {
      int index = 0;
      int indexA = 0;
      int indexB = 0;
      T[] returnTable = new T[a.Length + b.Length];

      while (true)
      {
        if (indexA < a.Length && indexB < b.Length)
        {
          returnTable[index++] = a[indexA].CompareTo(b[indexB]) < 0 ? a[indexA++] : b[indexB++];
        }
        else if (indexB < b.Length)
        {
          returnTable[index++] = b[indexB++];
        }
        else if (indexA < a.Length)
        {
          returnTable[index++] = a[indexA++];
        }
        else
        {
          break;
        }
      }

      return returnTable;
    }
  }
}

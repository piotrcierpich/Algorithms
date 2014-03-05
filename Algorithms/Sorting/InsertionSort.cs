using System;

namespace Algorithms.Sorting
{
  /// <summary>
  /// for each element in array, insert it in the correct position
  /// after each iteration, collection to the left of picked element is sorted
  /// 1. pick first element as pivot
  /// 2. if element on the left of pivot is less than 1 shift element from the left to the right
  /// 3. repeat until reach beggining of an array (i.e. index is 0) or until encountering element less than the examined one 
  /// (collection to the left is already sorted, but not necessarily with the right elements)
  /// </summary>
  class InsertionSort : ILinearSort
  {
    public void Sort<T>(T[] a) where T : IComparable<T>
    {
      for (int i = 1; i < a.Length; i++)
      {
        //examined element
        T elementToInsert = a[i];
        int j = i;
        while (j > 0)
        {
          // if element to the left is less, than we should stop
          if (a[j - 1].CompareTo(elementToInsert) <= 0)
            break;
          
          // shift element from left to right
          a[j] = a[j - 1];
          j--;
        }
        // insert examined element to the position
        a[j] = elementToInsert;
      }
    }
  }
}

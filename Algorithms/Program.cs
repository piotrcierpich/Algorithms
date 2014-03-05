using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Algorithms.Sorting;

namespace Algorithms
{
  class Program
  {
    static void Main()
    {
      int[] set = GenerateRandomArray(10);
      Console.WriteLine("Random set: " + set.EnumerableToString());
      //new BubbleSort().Sort(set);
      //new BubbleSort2().Sort(set);
      //new SelectionSort().Sort(set);
      //new InsertionSort().Sort(set);
      //set = new MergeSort().Sort(set);
      //new Quicksort().SortInPlace(set);
      new ShellSort().Sort(set);

      EnsureAscending(set);
      Console.WriteLine("Sorted set: " + set.EnumerableToString());
    }

    private static int[] GenerateRandomArray(int count)
    {
      return GenerateRandomEnumerable(count).ToArray();
    }

    private static IEnumerable<int> GenerateRandomEnumerable(int count)
    {
      Random r = new Random();
      for (int i = 0; i < count; i++)
      {
        yield return r.Next(count);
      }
    }


    private static void EnsureAscending(int[] randomSet)
    {
      for (int i = 0; i < randomSet.Length - 2; i++)
      {
        Debug.Assert(randomSet[i + 1] >= randomSet[i], "Unsorted array: " + randomSet.EnumerableToString());
      }
    }
  }
}

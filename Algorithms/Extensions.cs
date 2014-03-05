using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
  public static class Extensions
  {
    public static void Swap<T>(this T[] a, int index1, int index2)
    {
      T buffer = a[index1];
      a[index1] = a[index2];
      a[index2] = buffer;
    }


    public static string EnumerableToString<T>(this IEnumerable<T> randomSet)
    {
      return randomSet.Select(e => e.ToString()).Aggregate((e, f) => e + " " + f);
    }
  }
}

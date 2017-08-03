using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeverwinterGuildTool
{
    static class EnumerableExtensions
    {
        // Note: This is essentially the same as the MoreLinq MaxBy extension method. Providing an implementation in the project to avoid
        // external dependencies.

        public static T MaxBy<T, U>(this IEnumerable<T> source, Func<T, U> selector)
          where U : IComparable<U>
        {
            if (source == null) throw new ArgumentNullException("source");
            bool first = true;
            T maxObj = default(T);
            U maxKey = default(U);
            foreach (var item in source)
            {
                if (first)
                {
                    maxObj = item;
                    maxKey = selector(maxObj);
                    first = false;
                }
                else
                {
                    U currentKey = selector(item);
                    if (currentKey.CompareTo(maxKey) > 0)
                    {
                        maxKey = currentKey;
                        maxObj = item;
                    }
                }
            }
            if (first) throw new InvalidOperationException("Sequence is empty.");
            return maxObj;
        }
    }
}

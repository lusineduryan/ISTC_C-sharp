using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public static class ExtensionMethods
    {
        public static IEnumerable<object> Select<TSource>(this IEnumerable<TSource> source, Func<TSource, object> predicate)
        {
            foreach (TSource item in source)
            {
                yield return item;
            }
        }

        public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            foreach (TSource item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }

        public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            foreach (TSource item in source)
            {
                if (predicate(item))
                {
                    return item;
                }
                else
                {
                    source.GetEnumerator().MoveNext();
                }
            }
            return default(TSource);
        }
    }
}

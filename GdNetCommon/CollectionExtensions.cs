using System;
using System.Collections.Generic;
using System.Linq;

namespace GdNet.Common
{
    public static class CollectionExtensions
    {
        /// <summary>
        /// Check if a collection is null or empty
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns>True if collection is null or has no element. Otherwise false.</returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> collection)
        {
            return collection == null || !collection.Any();
        }

        /// <summary>
        /// Check if a collection is not null or empty
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns>True if collection is not null and has at least one element. Otherwise false.</returns>
        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> collection)
        {
            return collection != null && collection.Any();
        }

        /// <summary>
        /// Projects safely each element of a sequence into a new form. Returns an empty collection if the input collection is null or empty
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="collection"></param>
        /// <param name="selector"></param>
        /// <returns></returns>
        public static IEnumerable<U> SelectSafe<T, U>(this IEnumerable<T> collection, Func<T, U> selector)
        {
            if (collection.IsNullOrEmpty())
            {
                return Enumerable.Empty<U>();
            }

            return collection.Select(selector);
        }
    }
}
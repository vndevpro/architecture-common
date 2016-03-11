using System;
using System.Collections.Generic;
using System.Linq;

namespace GdNet.Common.Extensions
{
    public static class ResultExtension
    {
        /// <summary>
        /// Convert a result set to another result set
        /// </summary>
        /// <param name="result">Source result set</param>
        /// <param name="action">The action will be performed for each item on the source result set</param>
        public static Result<TOutput> ConvertTo<TSource, TOutput>(this Result<TSource> result, Func<TSource, TOutput> action)
        {
            var outputItems = result.Items.Select(action);
            return new Result<TOutput>(outputItems)
                {
                    Total = result.Total,
                };
        }

        /// <summary>
        /// Convert to result set
        /// </summary>
        /// <param name="result">Source result set</param>
        /// <param name="action">The action will be performed for each item on the source result set</param>
        public static Result<TOutput> ConvertTo<TSource, TOutput>(this IList<TSource> result, Func<TSource, TOutput> action)
        {
            var outputItems = result.Select(action);
            return new Result<TOutput>(outputItems)
            {
                Total = result.Count
            };
        }
    }
}

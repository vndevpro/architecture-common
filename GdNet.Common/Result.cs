using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace GdNet.Common
{
    /// <summary>
    /// Object to hold a page of items
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Result<T>
    {
        /// <summary>
        /// An empty page of items
        /// </summary>
        public static readonly Result<T> Empty = new Result<T>(new List<T>());

        /// <summary>
        /// 
        /// </summary>
        public IReadOnlyCollection<T> Items { get; private set; }

        /// <summary>
        /// Total number of items in data source
        /// </summary>
        public long Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        public Result(IEnumerable<T> items)
            : this(items.ToList())
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        public Result(IList<T> items)
        {
            Items = new ReadOnlyCollection<T>(items);
        }
    }
}

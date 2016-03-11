using System.Collections.Generic;
using System.Linq;

namespace GdNet.Common
{
    public class Result<T>
    {
        public static readonly Result<T> Empty = new Result<T>(new List<T>());

        public IList<T> Items { get; private set; }

        public long Total { get; set; }

        public Result(IEnumerable<T> items)
            : this((items is IList<T>) ? (IList<T>)items : items.ToList())
        {
        }

        public Result(IList<T> items)
        {
            Items = items;
        }
    }
}

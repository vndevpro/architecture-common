using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GdNet.Common
{
    public class PaginatedResult<T> : PaginatedResult
    {
        public IReadOnlyCollection<T> Items { get; private set; }

        public PaginatedResult(IList<T> items)
        {
            Items = new ReadOnlyCollection<T>(items);
        }
    }

    public abstract class PaginatedResult
    {
        public int? PageNumber { get; private set; }

        public int TotalPages { get; private set; }

        public int? PageSize { get; private set; }

        public long TotalCount { get; private set; }

        public static PaginatedResult<T> Create<T>(IList<T> items, long totalCount, int? pageNumber, int? pageSize)
        {
            {
                ValidateInput();

                return new PaginatedResult<T>(items)
                {
                    PageNumber = pageNumber,
                    PageSize = pageSize,
                    TotalPages = (pageSize.HasValue && pageSize.Value > 0)
                            ? (int)Math.Ceiling(totalCount / (double)pageSize)
                            : 1,
                    TotalCount = totalCount,
                };
            }

            void ValidateInput()
            {
                if (items.IsNull())
                {
                    throw new ArgumentNullException(nameof(items));
                }

                if (totalCount < items.Count)
                {
                    throw new ArgumentException($"Must be greater than or equals to {items.Count}", nameof(totalCount));
                }
            }
        }
    }
}

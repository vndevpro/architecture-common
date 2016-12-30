namespace GdNet.Common
{
    /// <summary>
    /// Extension methods for <see cref="Page">Page</see>
    /// </summary>
    public static class PageExtensions
    {
        public static bool IsValid(this Page page)
        {
            return (page != null) && (page.PageIndex >= 0) && (page.ItemsPerPage >= 1);
        }

        public static int GetOffset(this Page page)
        {
            return page.PageIndex * page.ItemsPerPage;
        }

        /// <summary>
        /// Zero based page index
        /// </summary>
        public static int GetPageIndex(this int? page)
        {
            return (!page.HasValue || page.Value < 1) ? 0 : page.Value - 1;
        }
    }
}
namespace GdNet.Common
{
    /// <summary>
    /// Pagination info
    /// </summary>
    public class Page
    {
        /// <summary>
        /// The page which contains all items
        /// </summary>
        public static Page AllItems
        {
            get
            {
                return new Page(0, int.MaxValue);
            }
        }

        /// <summary>
        /// Construct a new page with pageIndex = 0 an itemsPerPage = 10
        /// </summary>
        public static Page Default
        {
            get { return new Page(0, 10); }
        }

        /// <summary>
        /// Zero based page number
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// Number of items to be fetched
        /// </summary>
        public int ItemsPerPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="itemsPerPage"></param>
        public Page(int pageIndex, int itemsPerPage)
        {
            PageIndex = pageIndex;
            ItemsPerPage = itemsPerPage;
        }
    }
}

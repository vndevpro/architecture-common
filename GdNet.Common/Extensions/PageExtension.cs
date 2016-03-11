namespace GdNet.Common.Extensions
{
    public static class PageExtension
    {
        public static bool IsValid(this Page page)
        {
            return (page != null) && (page.PageIndex >= 0) && (page.ItemsPerPage >= 1);
        }

        public static int GetOffset(this Page page)
        {
            return page.PageIndex * page.ItemsPerPage;
        }
    }
}

namespace GdNet.Common
{
    /// <summary>
    /// Extension methods for String
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Trim a string
        /// </summary>
        public static string TrimSafe(this string input)
        {
            return (input == null) ? null : input.Trim();
        }
    }
}
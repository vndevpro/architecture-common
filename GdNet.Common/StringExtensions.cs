using System.IO;
using System.Linq;

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

        /// <summary>
        /// Build a safe file name from a given string candidate. The result file will have no space.
        /// </summary>
        public static string GetSafeFileName(this string input, string spaceReplacement = "-")
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }

            var fileName = input.TrimSafe().Replace(" ", spaceReplacement);

            return string.Join(string.Empty, fileName.Where(x => !Path.GetInvalidFileNameChars().Contains(x)));
        }
    }
}
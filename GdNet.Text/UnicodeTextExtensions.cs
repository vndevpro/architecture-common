using System.Text.RegularExpressions;
using Unidecode.NET;

namespace GdNet.Text
{
    public static class UnicodeTextExtensions
    {
        /// <summary>
        /// Create a frienly id from given input string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string BuildFriendlyId(this string input)
        {
            return input.BuildFriendlyId("-");
        }

        public static string BuildFriendlyId(this string input, string separator)
        {
            if (!string.IsNullOrWhiteSpace(input))
            {
                var result = input.Unidecode().ToLowerInvariant();

                result = Regex.Replace(result, @"\s+", "-");
                result = Regex.Replace(result, @"[^a-z0-9\-]", "");
                result = Regex.Replace(result, @"-+", "-");

                return result;
            }

            return string.Empty;
        }
    }
}

using System;

namespace GdNet.Common
{
    public static class GuidExtensions
    {
        /// <summary>
        /// Remove all '-' characters from a GUID
        /// </summary>
        public static string ToShortString(this Guid guid)
        {
            return guid.ToString("N").ToUpper();
        }

        /// <summary>
        /// Parse short string of GUID to Guid object
        /// </summary>
        public static Guid ToGuid(this string shortGuidString)
        {
            return Guid.ParseExact(shortGuidString, "N");
        }
    }
}
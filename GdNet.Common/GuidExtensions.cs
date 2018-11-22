using System;

namespace GdNet.Common
{
    public static class GuidExtensions
    {
        /// <summary>
        /// Remove all '-' characters from a GUID
        /// </summary>
        public static string ToShortId(this Guid guid)
        {
            return guid.ToString().Replace("-", string.Empty).ToLower();
        }
    }
}
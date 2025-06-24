using System;
using System.Globalization;
using System.IO;

namespace GdNet.Common
{
    /// <summary>
    /// Format file size from byte to most relevent unit
    /// </summary>
    public static class FileSizeExtensions
    {
        /// <summary>
        /// Converts a numeric value into a string that represents the number expressed as a size value in bytes,
        /// kilobytes, megabytes, or gigabytes, depending on the size.
        /// </summary>
        /// <param name="fileSize">The numeric value to be converted.</param>
        /// <returns>The converted string.</returns>
        public static string FormatByteSize(this long fileSize)
        {
            var unit = FileSizeUnit.B;
            var sizeAsDouble = Convert.ToDouble(fileSize);

            while (sizeAsDouble >= 1024 && unit < FileSizeUnit.YB)
            {
                sizeAsDouble = sizeAsDouble / 1024;
                unit++;
            }

            return string.Format("{0} {1}", sizeAsDouble.ToString("0.##", CultureInfo.CurrentUICulture), unit);
        }

        /// <summary>
        /// Converts a numeric value into a string that represents the number expressed as a size value in bytes,
        /// kilobytes, megabytes, or gigabytes, depending on the size.
        /// </summary>
        /// <param name="fileInfo"></param>
        /// <returns>The converted string.</returns>
        public static string FormatByteSize(this FileInfo fileInfo)
        {
            return FormatByteSize(fileInfo.Length);
        }

        internal enum FileSizeUnit : byte
        {
            B = 0,
            KB = 1,
            MB = 2,
            GB = 3,
            TB = 4,
            PB = 5,
            EB = 6,
            ZB = 7,
            YB = 8
        }
    }
}

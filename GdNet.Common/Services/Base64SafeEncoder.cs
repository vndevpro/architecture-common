using System;
using System.Text;

namespace GdNet.Common.Services
{
    /// <summary>
    /// Encode/decode to/from base64 string with safe to use for URL
    /// </summary>
    public class Base64SafeEncoder
    {
        /// <summary>
        /// Encode a byte array
        /// </summary>
        public string Encode(byte[] bytes)
        {
            char[] padding = { '=' };
            return Convert.ToBase64String(bytes).Trim(padding).Replace("+", "-").Replace("/", "_");
        }

        /// <summary>
        /// Encode a string
        /// </summary>
        public string Encode(string text)
        {
            return Encode(Encoding.ASCII.GetBytes(text));
        }

        /// <summary>
        /// Decode to a byte array
        /// </summary>
        public byte[] DecodeBytes(string safeEncodedText)
        {
            var base64 = safeEncodedText.Replace('_', '/').Replace('-', '+');

            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }

            return Convert.FromBase64String(base64);
        }

        /// <summary>
        /// Decode to a string
        /// </summary>
        public string Decode(string safeEncodedText)
        {
            return Encoding.ASCII.GetString(DecodeBytes(safeEncodedText));
        }
    }
}
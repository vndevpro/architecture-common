using System;
using System.Collections.Generic;
using System.Text;

namespace GdNet.Common
{
    /// <summary>
    /// Generate new random string with difference options
    /// </summary>
    public class RandomString
    {
        private readonly int _length;

        private const string LowerChars = "abcdefgijkmnopqrstwxyz";
        private const string UpperChars = "ABCDEFGHJKLMNPQRSTWXYZ";
        private const string Numbers = "0123456789";
        private const string SpecialChars = "~!@#$%^&*()-_+={}[]:;?<>";

        private readonly string _allChars;

        /// <summary>
        /// Options use to generate new random string
        /// </summary>
        [Flags]
        public enum Options
        {
            /// <summary>
            /// Generate only numbers
            /// </summary>
            Numbers = 1,
            /// <summary>
            /// Generate only lower characters
            /// </summary>
            LowerChars = 2,
            /// <summary>
            /// Generate only upper characters
            /// </summary>
            UpperChars = 4,
            /// <summary>
            /// Generate only special characters
            /// </summary>
            SpecialChars = 8,
            /// <summary>
            /// Expect any characters
            /// </summary>
            Any = Numbers | LowerChars | UpperChars | SpecialChars
        }

        /// <summary>
        /// New instance with default options (Length = 6 and only Numbers)
        /// </summary>
        public RandomString()
            : this(6, Options.Numbers)
        {
        }

        /// <summary>
        /// New instance with custom options
        /// </summary>
        public RandomString(int length, Options options)
        {
            if (length < 3)
            {
                throw new ArgumentException("Length must not less than 3");
            }

            _length = length;
            _allChars = BuildAllChars(options);
        }

        /// <summary>
        /// Generate new random string with given options
        /// </summary>
        public string NextValue()
        {
            return InternalGetNextValue(new StringBuilder(), new Random());
        }

        /// <summary>
        /// Generate a number of random strings
        /// </summary>
        public IEnumerable<string> NextValues(int count)
        {
            var sb = new StringBuilder();
            var random = new Random();

            for (int i = 0; i < count; i++)
            {
                sb.Clear();
                yield return InternalGetNextValue(sb, random);
            }
        }

        private string InternalGetNextValue(StringBuilder sb, Random random)
        {
            while (sb.Length < _length)
            {
                var index = random.Next(_allChars.Length);
                sb.Append(_allChars[index]);
            }

            return sb.ToString();
        }

        private string BuildAllChars(Options options)
        {
            var allChars = new StringBuilder();

            if (options.HasFlag(Options.Numbers))
            {
                allChars.Append(Numbers);
            }
            if (options.HasFlag(Options.LowerChars))
            {
                allChars.Append(LowerChars);
            }
            if (options.HasFlag(Options.UpperChars))
            {
                allChars.Append(UpperChars);
            }
            if (options.HasFlag(Options.SpecialChars))
            {
                allChars.Append(SpecialChars);
            }

            return allChars.ToString();
        }
    }
}

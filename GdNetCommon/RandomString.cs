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
        protected readonly int Length;
        protected readonly StringBuilder AllChars = new StringBuilder();

        public const string LowerChars = "abcdefgijkmnopqrstwxyz";
        public const string UpperChars = "ABCDEFGHJKLMNPQRSTWXYZ";
        public const string Numbers = "0123456789";
        public const string SpecialChars = "~!@#$%^&*()-_+={}[]:;?<>";

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
            {
                ValidateInput();

                Length = length;
                BuildAllChars();
            }

            void ValidateInput()
            {
                if (length < 3)
                {
                    throw new ArgumentException($"{nameof(length)} must be at least 3");
                }
            }

            void BuildAllChars()
            {
                if (options.HasFlag(Options.Numbers))
                {
                    AllChars.Append(Numbers);
                }
                if (options.HasFlag(Options.LowerChars))
                {
                    AllChars.Append(LowerChars);
                }
                if (options.HasFlag(Options.UpperChars))
                {
                    AllChars.Append(UpperChars);
                }
                if (options.HasFlag(Options.SpecialChars))
                {
                    AllChars.Append(SpecialChars);
                }
            }
        }

        /// <summary>
        /// Generate a number of random strings
        /// </summary>
        public IEnumerable<string> NextValues(int counter)
        {
            for (int i = 0; i < counter; i++)
            {
                yield return NextValue();
            }
        }

        /// <summary>
        /// Generate a new random string
        /// </summary>
        public string NextValue()
        {
            var result = string.Empty;
            var random = new Random();

            while (result.Length < Length)
            {
                var index = random.Next(AllChars.Length);
                result = string.Concat(result, AllChars[index]);
            }

            return result;
        }
    }
}

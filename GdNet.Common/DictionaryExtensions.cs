using System.Collections.Generic;
using System.Dynamic;

namespace GdNet.Common
{
    /// <summary>
    /// Extension methods for Dictionary type
    /// </summary>
    public static class DictionaryExtensions
    {
        /// <summary>
        /// Adds new item into the dictionary if the key is not exist yet, otherwise update old value.
        /// </summary>
        public static void AddOrSet(this IDictionary<string, string> dictionary, string key, string value)
        {
            if (dictionary.ContainsKey(key))
            {
                dictionary[key] = value;
            }
            else
            {
                dictionary.Add(key, value);
            }
        }

        /// <summary>
        /// Get item in a dictionary
        /// </summary>
        public static string GetOrDefault(this IDictionary<string, string> dictionary, string key)
        {
            return dictionary.GetOrDefault(key, default(string));
        }

        /// <summary>
        /// Get item in a dictionary
        /// </summary>
        public static string GetOrDefault(this IDictionary<string, string> dictionary, string key, string @default)
        {
            return dictionary.ContainsKey(key) ? dictionary[key] : @default;
        }

        /// <summary>
        /// Convert a dictionary to dynamic object so we can access an item by its key
        /// </summary>
        public static dynamic ToDynamic(this IDictionary<string, string> dictionary)
        {
            IDictionary<string, object> expando = new ExpandoObject();

            foreach (var kvp in dictionary)
            {
                expando.Add(kvp.Key, kvp.Value);
            }

            return expando;
        }
    }
}

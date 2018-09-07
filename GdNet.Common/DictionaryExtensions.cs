using System.Collections.Generic;

namespace GdNet.Common
{
    public static class DictionaryExtensions
    {
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

        public static string GetOrDefault(this IDictionary<string, string> dictionary, string key)
        {
            return dictionary.GetOrDefault(key, default(string));
        }

        public static string GetOrDefault(this IDictionary<string, string> dictionary, string key, string @default)
        {
            return dictionary.ContainsKey(key) ? dictionary[key] : @default;
        }
    }
}

using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Xml.Linq;

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
        /// Get item in a dictionary by its key
        /// </summary>
        public static TValue GetOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
        {
            return dictionary.GetOrDefault(key, default);
        }

        /// <summary>
        /// Get item in a dictionary
        /// </summary>
        public static TValue GetOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue @default)
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

        /// <summary>
        /// Returns a xml document for the dictionary, root element is items and child elements are item
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Xml documents contain all items</returns>
        public static string ToXml<TKey, TValue>(this IDictionary<TKey, TValue> data)
        {
            var xmlContent = data.Select(x => new XElement("item", new XAttribute("key", x.Key), new XAttribute("value", x.Value)));
            var xElem = new XElement("items", xmlContent);
            return xElem.ToString();
        }

        /// <summary>
        /// Returns a xml document for the dictionary, root element is items and child elements are item (not containing any null or empty value on key/value)
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Xml documents contain all items</returns>
        public static string ToXmlIgnoreNullOrEmpty<TKey, TValue>(this IDictionary<TKey, TValue> data)
        {
            var xmlContent = data
                .Where(x => x.Key != null && x.Value != null)
                .Select(x => new XElement("item", new XAttribute("key", x.Key), new XAttribute("value", x.Value)));

            var xElem = new XElement("items", xmlContent);
            return xElem.ToString();
        }
    }
}

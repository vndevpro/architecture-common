using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace GdNet.Common
{
    /// <summary>
    /// Extension methods to work with XML
    /// </summary>
    public static class XmlExtensions
    {
        /// <summary>
        /// Returns a xml document for the dictionary, root element is items and child elements are item
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string ToXml(this IDictionary<string, string> data)
        {
            var xmlContent = data.Select(x => new XElement("item", new XAttribute("key", x.Key), new XAttribute("value", x.Value)));
            var xElem = new XElement("items", xmlContent);
            return xElem.ToString();
        }

        /// <summary>
        /// Returns a xml document for the dictionary, root element is items and child elements are item (not containing any null or empty value on key/value)
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string ToXmlIgnoreNullOrEmpty(this IDictionary<string, string> data)
        {
            var xmlContent = data
                .Where(x => !string.IsNullOrEmpty(x.Key) && !string.IsNullOrEmpty(x.Value))
                .Select(x => new XElement("item", new XAttribute("key", x.Key), new XAttribute("value", x.Value)));

            var xElem = new XElement("items", xmlContent);
            return xElem.ToString();
        }

        /// <summary>
        /// Parse xml doucment to dictionary, input must be value of ToXml method
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static IDictionary<string, string> ParseXml(string xml)
        {
            var xElem = XElement.Parse(xml);
            var dict = xElem.Descendants("item")
                                .ToDictionary(
                                    x => (string)x.Attribute("key"),
                                    x => (string)x.Attribute("value"));
            return dict;
        }
    }
}
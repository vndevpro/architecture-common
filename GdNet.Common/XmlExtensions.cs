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
        /// Returns xml document for the dictionary, root element is items and child element is item
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string ToXml(this IDictionary<string, string> data)
        {
            var xElem = new XElement("items",
                data.Select(x => new XElement("item", new XAttribute("key", x.Key), new XAttribute("value", x.Value)))
            );
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
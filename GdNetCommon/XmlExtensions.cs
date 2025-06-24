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
        /// Parse xml doucment to dictionary, input must be value of ToXml method
        /// </summary>
        /// <param name="xml"></param>
        /// <returns>A dictionary representing from all items having key/value attributes</returns>
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
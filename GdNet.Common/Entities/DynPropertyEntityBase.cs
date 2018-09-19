using System.Collections.Generic;

namespace GdNet.Common.Entities
{
    /// <summary>
    /// Base class for entities support to define new properties dynamically (values are stored in a dictionary)
    /// </summary>
    public abstract class DynPropertyEntityBase : IDynPropertyEntity
    {
        /// <summary>
        /// Dictionary contains all dyn properties
        /// </summary>
        protected IDictionary<string, string> _metadata = new Dictionary<string, string>();

        /// <summary>
        /// Gets or sets dynamic properties dictionary as string
        /// </summary>
        public string MetadataXml
        {
            get
            {
                return _metadata.ToXmlIgnoreNullOrEmpty();
            }
            set
            {
                _metadata = XmlExtensions.ParseXml(value);
            }
        }

        /// <summary>
        /// Add or change value of a property
        /// </summary>
        public void SetProperty(string name, string value)
        {
            _metadata.AddOrSet(name, value);
        }

        /// <summary>
        /// Get value of a property
        /// </summary>
        public string GetProperty(string name)
        {
            return _metadata.GetOrDefault(name, null);
        }
    }
}

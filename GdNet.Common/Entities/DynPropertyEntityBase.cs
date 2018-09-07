using System.Collections.Generic;

namespace GdNet.Common.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class DynPropertyEntityBase : IDynPropertyEntity
    {
        /// <summary>
        /// Dictionary contains all dyn properties
        /// </summary>
        protected IDictionary<string, string> _metadata;

        protected DynPropertyEntityBase()
        {
            _metadata = new Dictionary<string, string>();
        }

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
    }
}

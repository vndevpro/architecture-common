using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;

namespace GdNet.Common
{
    /// <summary>
    /// Extension methods for Object type
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Convert an anonymous object to dynamic object so that it's possible to use on other namespaces (eg on cshtml)
        /// </summary>
        public static dynamic ToDynamic(this object anonymousObject)
        {
            IDictionary<string, object> expando = new ExpandoObject();

            foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(anonymousObject))
            {
                var obj = propertyDescriptor.GetValue(anonymousObject);
                expando.Add(propertyDescriptor.Name, obj);
            }

            return expando;
        }

        public static bool IsNull(this object obj)
        {
            return obj == null;
        }

        public static bool IsNotNull(this object obj)
        {
            return obj != null;
        }
    }
}

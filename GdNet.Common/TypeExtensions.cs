using System;
using System.Collections.Generic;
using System.Linq;

namespace GdNet.Common
{
    /// <summary>
    /// 
    /// </summary>
    public static class TypeExtensions
    {
        /// <summary>
        /// Check the given type is implemented a given interface or not
        /// </summary>
        public static bool IsImplemented(this Type type, Type interfaceType)
        {
            return interfaceType.IsAssignableFrom(type);
        }

        public static Type GetBaseTypeUntil(this Type mainType, Type leafType)
        {
            var baseType = mainType.BaseType;

            while (baseType != null && baseType.GUID != leafType.GUID)
            {
                baseType = baseType.BaseType;
            }

            return baseType;
        }

        public static string GetFirstGenericTypeName(this Type genericType)
        {
            var argumentType = genericType.GenericTypeArguments.First();
            return argumentType.CalculateSafeTableName();
        }

        private static string CalculateSafeTableName(this Type type)
        {
            var typeName = type.Name;

            var sqlObjectNames = new List<string>
            {
                "user",
                "file"
            };

            return sqlObjectNames.Any(x => string.Equals(x, typeName, StringComparison.InvariantCultureIgnoreCase))
                ? string.Format("[{0}]", typeName)
                : typeName;
        }
    }
}
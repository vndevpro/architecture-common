using System;
using System.Linq.Expressions;
using System.Reflection;

namespace GdNet.Common
{
    /// <summary>
    /// Extension methods on reflection
    /// </summary>
    public static class ReflectionExtensions
    {
        /// <summary>
        /// Get PropertyInfo of the generic type
        /// </summary>
        public static PropertyInfo GetPropertyInfo<T>(this Expression<Func<T, object>> property)
        {
            var propertyName = property.GetPropertyName();
            return typeof(T).GetProperty(propertyName);
        }

        /// <summary>
        /// Get property name by its expression
        /// </summary>
        public static string GetPropertyName<T>(this Expression<Func<T>> property)
        {
            return property.Body.GetPropertyName();
        }

        /// <summary>
        /// Get property name by its expression
        /// </summary>
        public static string GetPropertyName<T>(this Expression<Func<T, object>> property)
        {
            return property.Body.GetPropertyName();
        }

        private static string GetPropertyName(this Expression exp)
        {
            var member = exp as MemberExpression;
            if (member != null)
            {
                return member.Member.Name;
            }

            var unary = exp as UnaryExpression;
            if (unary != null)
            {
                return ((MemberExpression)unary.Operand).Member.Name;
            }

            throw new ApplicationException($"Cannot get property name from expression {exp.ToString()}");
        }
    }
}
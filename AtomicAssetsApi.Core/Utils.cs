using System;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace AtomicAssetsApi.Core
{
    public static class Utils
    {
        public static string ConvertToString(object value, CultureInfo cultureInfo)
        {
            if (value == null)
            {
                return "";
            }

            if (value is Enum)
            {
                var name = Enum.GetName(value.GetType(), value);
                if (name != null)
                {
                    var field = value.GetType().GetTypeInfo().GetDeclaredField(name);
                    if (field != null)
                    {
                        if (field.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute attribute)
                        {
                            return attribute.Value ?? name;
                        }
                    }

                    return Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
                }
            }
            else if (value is bool boolVal)
            {
                return Convert.ToString(boolVal, cultureInfo).ToLowerInvariant();
            }
            else if (value is byte[] bytesVal)
            {
                return Convert.ToBase64String(bytesVal);
            }
            else if (value.GetType().IsArray)
            {
                var array = ((Array)value).OfType<object>();
                return string.Join(",", array.Select(o => ConvertToString(o, cultureInfo)));
            }

            return Convert.ToString(value, cultureInfo) ?? "";
        }
    }
}

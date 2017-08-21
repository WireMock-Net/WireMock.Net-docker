using System;
using System.Globalization;
using System.Reflection;

namespace CommandLineParserTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo _cultureInfo = CultureInfo.InvariantCulture;

            string stringValue = "12";

            Type type = typeof(int?);
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                type = Nullable.GetUnderlyingType(type);
            }

            MethodInfo mi = type.GetMethod("Parse", new[] { typeof(string), typeof(CultureInfo) });

            if (mi != null)
            {
                if (mi.IsStatic && mi.ReturnType == type)
                {
                    object x = mi.Invoke(null, new object[] { stringValue, _cultureInfo });
                    Console.WriteLine($"x1 = '{x}'");
                }
            }

            stringValue = null;

            type = typeof(int?);
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                type = Nullable.GetUnderlyingType(type);
            }

            mi = type.GetMethod("Parse", new[] { typeof(string), typeof(CultureInfo) });

            if (mi != null)
            {
                if (mi.IsStatic && mi.ReturnType == type)
                {
                    object x = stringValue != null ? mi.Invoke(null, new object[] { stringValue, _cultureInfo }) : null;
                    Console.WriteLine($"x2 = '{x}'");
                }
            }
        }
    }
}
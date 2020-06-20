using System;
using System.Text.RegularExpressions;

namespace UC.Common.Extend
{
    /// <summary>
    /// A set of extensions for string
    /// </summary>
    public static class Str
    {
        /// <summary>
        /// Checks if given string is empty, null or whitespace
        /// </summary>
        /// <param name="str">The given string to test</param>
        /// <returns></returns>
        public static bool IsBlank(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }

        /// <summary>
        /// Checks if given string is not empty, null or whitespace
        /// </summary>
        /// <param name="str">The given string to test</param>
        /// <returns></returns>
        public static bool IsNotBlank(this string str)
        {
            return !string.IsNullOrWhiteSpace(str);
        }

        /// <summary>
        /// Removes XML characters from a string
        /// </summary>
        /// <param name="text">String to remove XML characters</param>
        public static string EscapeXMLCharacters(this string text)
        {
            // From xml spec valid chars: 
            // #x9 | #xA | #xD | [#x20-#xD7FF] | [#xE000-#xFFFD] | [#x10000-#x10FFFF]     
            // any Unicode character, excluding the surrogate blocks, FFFE, and FFFF. 
            //string re = @"[^\x09\x0A\x0D\x20-\xD7FF\xE000-\xFFFD\x10000-x10FFFF]";
            string re = @"\x01";
            return Regex.Replace(text, re, "|");
        }

        /// <summary>
        /// Removes CRLF and tab characters from string
        /// </summary>
        /// <param name="text">String to remove characters</param>
        /// <returns>String</returns>
        public static string EscapeCRLFTabs(this string text)
        {
            return Regex.Replace(text, @"\t|\n|\r", " ");
        }

        /// <summary>
        /// Parse value to given type
        /// </summary>
        /// <param name="value">The value to parse</param>
        /// <param name="type">The type to parse to</param>
        /// <returns></returns>
        public static object Parse(this string value, Type type)
        {
            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Char:
                    return char.TryParse(value, out var charValue) ? new char?(charValue) : null;

                case TypeCode.Int16:
                    return short.TryParse(value, out var shortValue) ? new short?(shortValue) : null;

                case TypeCode.Int32:
                    return int.TryParse(value, out var intValue) ? new int?(intValue) : null;

                case TypeCode.Int64:
                    return long.TryParse(value, out var longValue) ? new long?(longValue) : null;

                case TypeCode.Double:
                    return double.TryParse(value, out var doubleValue) ? new double?(doubleValue) : null;

                case TypeCode.Single:
                    return float.TryParse(value, out var floatValue) ? new float?(floatValue) : null;

                case TypeCode.Boolean:
                    return bool.TryParse(value, out var boolValue) ? new bool?(boolValue) : null;

                case TypeCode.SByte:
                    return sbyte.TryParse(value, out var sbyteValue) ? new sbyte?(sbyteValue) : null;

                case TypeCode.Byte:
                    return byte.TryParse(value, out var byteValue) ? new byte?(byteValue) : null;

                case TypeCode.UInt16:
                    return ushort.TryParse(value, out var ushortValue) ? new ushort?(ushortValue) : null;

                case TypeCode.UInt32:
                    return uint.TryParse(value, out var uintValue) ? new uint?(uintValue) : null;

                case TypeCode.UInt64:
                    return ulong.TryParse(value, out var ulongValue) ? new ulong?(ulongValue) : null;

                case TypeCode.Decimal:
                    return decimal.TryParse(value, out var decimalValue) ? new decimal?(decimalValue) : null;

                case TypeCode.DateTime:
                    return DateTime.TryParse(value, out var dateTimeValue) ? new DateTime?(dateTimeValue) : null;

                case TypeCode.String:
                case TypeCode.Object:
                case TypeCode.DBNull:
                    return value;

                case TypeCode.Empty:
                default:
                    return null;
            }
        }
    }
}

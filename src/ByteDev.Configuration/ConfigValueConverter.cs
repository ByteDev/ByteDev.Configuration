using System;

namespace ByteDev.Configuration
{
    internal static class ConfigValueConverter
    {
        public static char GetChar(string key, string value)
        {
            if (!char.TryParse(value, out var result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(char));
            }
            return result;
        }

        public static bool GetBool(string key, string value)
        {
            if (!bool.TryParse(value, out var result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(bool));
            }
            return result;
        }

        public static byte GetByte(string key, string value)
        {
            if (!byte.TryParse(value, out var result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(byte));
            }
            return result;
        }

        public static int GetInt(string key, string value)
        {
            if (!int.TryParse(value, out var result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(int));
            }
            return result;
        }

        public static long GetLong(string key, string value)
        {
            if (!long.TryParse(value, out var result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(long));
            }
            return result;
        }

        public static short GetShort(string key, string value)
        {
            if (!short.TryParse(value, out var result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(short));
            }
            return result;
        }
        
        public static float GetFloat(string key, string value)
        {
            if (!float.TryParse(value, out var result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(float));
            }
            return result;
        }

        public static double GetDouble(string key, string value)
        {
            if (!double.TryParse(value, out var result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(double));
            }
            return result;
        }

        public static decimal GetDecimal(string key, string value)
        {
            if (!decimal.TryParse(value, out var result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(decimal));
            }
            return result;
        }

        public static Uri GetAbsoluteUri(string key, string value)
        {
            if (!Uri.TryCreate(value, UriKind.Absolute, out var result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(Uri));
            }
            return result;
        }

        public static Guid GetGuid(string key, string value)
        {
            if (!Guid.TryParse(value, out var result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(Guid));
            }
            return result;
        }
    }
}
using System;

namespace ByteDev.Configuration
{
    internal class ConfigValueConverter
    {
        public char GetChar(string key, string value)
        {
            if (!char.TryParse(value, out var result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(char));
            }
            return result;
        }

        public bool GetBool(string key, string value)
        {
            if (!bool.TryParse(value, out var result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(bool));
            }
            return result;
        }

        public byte GetByte(string key, string value)
        {
            if (!byte.TryParse(value, out var result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(byte));
            }
            return result;
        }

        public int GetInt(string key, string value)
        {
            if (!int.TryParse(value, out var result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(int));
            }
            return result;
        }

        public long GetLong(string key, string value)
        {
            if (!long.TryParse(value, out var result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(long));
            }
            return result;
        }

        public short GetShort(string key, string value)
        {
            if (!short.TryParse(value, out var result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(short));
            }
            return result;
        }
        
        public float GetFloat(string key, string value)
        {
            if (!float.TryParse(value, out var result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(float));
            }
            return result;
        }

        public double GetDouble(string key, string value)
        {
            if (!double.TryParse(value, out var result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(double));
            }
            return result;
        }

        public decimal GetDecimal(string key, string value)
        {
            if (!decimal.TryParse(value, out var result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(decimal));
            }
            return result;
        }

        public Uri GetAbsoluteUri(string key, string value)
        {
            if (!Uri.TryCreate(value, UriKind.Absolute, out var result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(Uri));
            }
            return result;
        }

        public Guid GetGuid(string key, string value)
        {
            if (!Guid.TryParse(value, out var result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(Guid));
            }
            return result;
        }
    }
}
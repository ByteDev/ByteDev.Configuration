using System;

namespace ByteDev.Configuration
{
    internal class ConfigValueConverter
    {
        public char GetChar(string key, string value)
        {
            char result;
            if (!char.TryParse(value, out result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(char));
            }
            return result;
        }

        public bool GetBool(string key, string value)
        {
            bool result;
            if (!bool.TryParse(value, out result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(bool));
            }
            return result;
        }

        public byte GetByte(string key, string value)
        {
            byte result;
            if (!byte.TryParse(value, out result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(byte));
            }
            return result;
        }

        public int GetInt(string key, string value)
        {
            int result;
            if (!int.TryParse(value, out result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(int));
            }
            return result;
        }

        public long GetLong(string key, string value)
        {
            long result;
            if (!long.TryParse(value, out result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(long));
            }
            return result;
        }

        public short GetShort(string key, string value)
        {
            short result;
            if (!short.TryParse(value, out result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(short));
            }
            return result;
        }
        
        public float GetFloat(string key, string value)
        {
            float result;
            if (!float.TryParse(value, out result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(float));
            }
            return result;
        }

        public double GetDouble(string key, string value)
        {
            double result;
            if (!double.TryParse(value, out result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(double));
            }
            return result;
        }

        public decimal GetDecimal(string key, string value)
        {
            decimal result;
            if (!decimal.TryParse(value, out result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(decimal));
            }
            return result;
        }

        public Uri GetAbsoluteUri(string key, string value)
        {
            Uri result;
            if (!Uri.TryCreate(value, UriKind.Absolute, out result))
            {
                throw new UnexpectedConfigValueTypeException(key, value, typeof(Uri));
            }
            return result;
        }
    }
}
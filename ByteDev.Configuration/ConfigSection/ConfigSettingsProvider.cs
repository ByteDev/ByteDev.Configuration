using System;
using System.Collections.Specialized;

namespace ByteDev.Configuration.ConfigSection
{
    public class ConfigSettingsProvider : IConfigSettingsProvider
    {
        private readonly IConfigSectionProvider _configSectionProvider;

        public ConfigSettingsProvider(IConfigSectionProvider configSectionProvider)
        {
            _configSectionProvider = configSectionProvider;
        }

        public string GetString(string key, string sectionName)
        {
            var section = GetSection(sectionName);
            var value = section[key];

            if (value == null)
            {
                throw new ConfigSettingsProviderException(string.Format("Key '{0}' missing from section '{1}' in config file", key, sectionName));
            }
            return value;
        }

        public string GetString(Enum key, Enum sectionName)
        {
            return GetString(key.ToString(), sectionName.ToString());
        }

        public char GetChar(string key, string sectionName)
        {
            char result;

            if (!char.TryParse(GetString(key, sectionName), out result))
            {
                ThrowUnexpectedConfigValueTypeException(key, sectionName, typeof(char));
            }
            return result;
        }

        public char GetChar(Enum key, Enum sectionName)
        {
            return GetChar(key.ToString(), sectionName.ToString());
        }

        public bool GetBool(string key, string sectionName)
        {
            bool result;

            if (!bool.TryParse(GetString(key, sectionName), out result))
            {
                ThrowUnexpectedConfigValueTypeException(key, sectionName, typeof(bool));
            }
            return result;
        }

        public bool GetBool(Enum key, Enum sectionName)
        {
            return GetBool(key.ToString(), sectionName.ToString());
        }

        public byte GetByte(string key, string sectionName)
        {
            byte result;

            if (!byte.TryParse(GetString(key, sectionName), out result))
            {
                ThrowUnexpectedConfigValueTypeException(key, sectionName, typeof(byte));
            }
            return result;
        }

        public byte GetByte(Enum key, Enum sectionName)
        {
            return GetByte(key.ToString(), sectionName.ToString());
        }

        public short GetShort(string key, string sectionName)
        {
            short value;

            if (!short.TryParse(GetString(key, sectionName), out value))
            {
                ThrowUnexpectedConfigValueTypeException(key, sectionName, typeof(short));
            }
            return value;
        }

        public short GetShort(Enum key, Enum sectionName)
        {
            return GetShort(key.ToString(), sectionName.ToString());
        }

        public int GetInt(string key, string sectionName)
        {
            int result;

            if (!int.TryParse(GetString(key, sectionName), out result))
            {
                ThrowUnexpectedConfigValueTypeException(key, sectionName, typeof(int));
            }
            return result;
        }

        public int GetInt(Enum key, Enum sectionName)
        {
            return GetInt(key.ToString(), sectionName.ToString());
        }

        public long GetLong(string key, string sectionName)
        {
            long result;

            if (!long.TryParse(GetString(key, sectionName), out result))
            {
                ThrowUnexpectedConfigValueTypeException(key, sectionName, typeof(long));
            }
            return result;
        }

        public long GetLong(Enum key, Enum sectionName)
        {
            return GetLong(key.ToString(), sectionName.ToString());
        }

        public float GetFloat(string key, string sectionName)
        {
            float result;

            if (!float.TryParse(GetString(key, sectionName), out result))
            {
                ThrowUnexpectedConfigValueTypeException(key, sectionName, typeof(float));
            }
            return result;
        }

        public float GetFloat(Enum key, Enum sectionName)
        {
            return GetFloat(key.ToString(), sectionName.ToString());
        }

        public double GetDouble(string key, string sectionName)
        {
            double result;

            if (!double.TryParse(GetString(key, sectionName), out result))
            {
                ThrowUnexpectedConfigValueTypeException(key, sectionName, typeof(double));
            }
            return result;
        }

        public double GetDouble(Enum key, Enum sectionName)
        {
            return GetDouble(key.ToString(), sectionName.ToString());
        }

        public decimal GetDecimal(string key, string sectionName)
        {
            decimal result;

            if (!decimal.TryParse(GetString(key, sectionName), out result))
            {
                ThrowUnexpectedConfigValueTypeException(key, sectionName, typeof(decimal));
            }
            return result;
        }

        public decimal GetDecimal(Enum key, Enum sectionName)
        {
            return GetDecimal(key.ToString(), sectionName.ToString());
        }


        private static void ThrowUnexpectedConfigValueTypeException(string key, string sectionName, Type expectedType)
        {
            throw new UnexpectedConfigValueTypeException(string.Format("Config setting '{0}' in section '{1}' is not a valid {2} value", key, sectionName, expectedType));
        }

        private NameValueCollection GetSection(string sectionName)
        {
            var section = _configSectionProvider.GetSection(sectionName);

            if (section == null)
            {
                throw new ConfigSettingsProviderException(string.Format("Config section '{0}' does not exist", sectionName));
            }
            return section;
        }
    }
}
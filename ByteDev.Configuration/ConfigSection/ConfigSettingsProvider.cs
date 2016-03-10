using System;
using System.Collections.Specialized;

namespace ByteDev.Configuration.ConfigSection
{
    public class ConfigSettingsProvider : IConfigSettingsProvider
    {
        private readonly IConfigSectionProvider _configSectionProvider;
        private readonly ConfigValueConverter _configValueConverter;

        public ConfigSettingsProvider(IConfigSectionProvider configSectionProvider)
        {
            _configSectionProvider = configSectionProvider;
            _configValueConverter = new ConfigValueConverter();
        }

        public string GetString(string key, string sectionName)
        {
            var section = GetSection(sectionName);
            var value = section[key];

            if (value == null)
            {
                throw new ConfigSettingsProviderException(string.Format("Key '{0}' missing from section '{1}' in config.", key, sectionName));
            }
            return value;
        }

        public string GetString(Enum key, Enum sectionName)
        {
            return GetString(key.ToString(), sectionName.ToString());
        }

        public char GetChar(string key, string sectionName)
        {
            var value = GetString(key, sectionName);
            return _configValueConverter.GetChar(key, value);
        }

        public char GetChar(Enum key, Enum sectionName)
        {
            return GetChar(key.ToString(), sectionName.ToString());
        }

        public bool GetBool(string key, string sectionName)
        {
            var value = GetString(key, sectionName);
            return _configValueConverter.GetBool(key, value);
        }

        public bool GetBool(Enum key, Enum sectionName)
        {
            return GetBool(key.ToString(), sectionName.ToString());
        }

        public byte GetByte(string key, string sectionName)
        {
            var value = GetString(key, sectionName);
            return _configValueConverter.GetByte(key, value);
        }

        public byte GetByte(Enum key, Enum sectionName)
        {
            return GetByte(key.ToString(), sectionName.ToString());
        }

        public short GetShort(string key, string sectionName)
        {
            var value = GetString(key, sectionName);
            return _configValueConverter.GetShort(key, value);
        }

        public short GetShort(Enum key, Enum sectionName)
        {
            return GetShort(key.ToString(), sectionName.ToString());
        }

        public int GetInt(string key, string sectionName)
        {
            var value = GetString(key, sectionName);
            return _configValueConverter.GetInt(key, value);
        }

        public int GetInt(Enum key, Enum sectionName)
        {
            return GetInt(key.ToString(), sectionName.ToString());
        }

        public long GetLong(string key, string sectionName)
        {
            var value = GetString(key, sectionName);
            return _configValueConverter.GetLong(key, value);
        }

        public long GetLong(Enum key, Enum sectionName)
        {
            return GetLong(key.ToString(), sectionName.ToString());
        }

        public float GetFloat(string key, string sectionName)
        {
            var value = GetString(key, sectionName);
            return _configValueConverter.GetFloat(key, value);
        }

        public float GetFloat(Enum key, Enum sectionName)
        {
            return GetFloat(key.ToString(), sectionName.ToString());
        }

        public double GetDouble(string key, string sectionName)
        {
            var value = GetString(key, sectionName);
            return _configValueConverter.GetDouble(key, value);
        }

        public double GetDouble(Enum key, Enum sectionName)
        {
            return GetDouble(key.ToString(), sectionName.ToString());
        }

        public decimal GetDecimal(string key, string sectionName)
        {
            var value = GetString(key, sectionName);
            return _configValueConverter.GetDecimal(key, value);
        }

        public decimal GetDecimal(Enum key, Enum sectionName)
        {
            return GetDecimal(key.ToString(), sectionName.ToString());
        }
        
        public Uri GetAbsoluteUri(string key, string sectionName)
        {
            var value = GetString(key, sectionName);
            return _configValueConverter.GetAbsoluteUri(key, value);
        }

        public Uri GetAbsoluteUri(Enum key, Enum sectionName)
        {
            return GetAbsoluteUri(key.ToString(), sectionName.ToString());
        }

        public Guid GetGuid(string key, string sectionName)
        {
            var value = GetString(key, sectionName);
            return _configValueConverter.GetGuid(key, value);
        }

        public Guid GetGuid(Enum key, Enum sectionName)
        {
            return GetGuid(key.ToString(), sectionName.ToString());
        }

        private NameValueCollection GetSection(string sectionName)
        {
            var section = _configSectionProvider.GetSection(sectionName);

            if (section == null)
            {
                throw new ConfigSettingsProviderException(string.Format("Config section '{0}' does not exist.", sectionName));
            }
            return section;
        }
    }
}
using System;
using System.Collections.Specialized;

namespace ByteDev.Configuration.ConfigSection
{
    /// <summary>
    /// Represents a provider for retrieving values from a config section.
    /// </summary>
    public class ConfigSettingsProvider : IConfigSettingsProvider
    {
        private readonly IConfigSectionProvider _configSectionProvider;
        private readonly ConfigValueConverter _configValueConverter;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Configuration.ConfigSection.ConfigSettingsProvider" /> class.
        /// </summary>
        /// <param name="configSectionProvider">Config section provider.</param>
        public ConfigSettingsProvider(IConfigSectionProvider configSectionProvider)
        {
            _configSectionProvider = configSectionProvider;
            _configValueConverter = new ConfigValueConverter();
        }

        /// <summary>
        /// Retrieves a string value.
        /// </summary>
        /// <param name="key">Key to retrieve the value.</param>
        /// <param name="sectionName">Section name to retrieve the value from.</param>
        /// <returns>Config value for the <paramref name="key" />.</returns>
        /// <exception cref="T:ByteDev.Configuration.ConfigSection.ConfigSettingsProviderException">Key does not exist in the section.</exception>
        public string GetString(string key, string sectionName)
        {
            var section = GetSectionOrThrow(sectionName);
            var value = section[key];

            if (value == null)
            {
                throw new ConfigSettingsProviderException($"Key '{key}' missing from section '{sectionName}' in config.");
            }

            return value;
        }

        /// <summary>
        /// Retrieves a char value.
        /// </summary>
        /// <param name="key">Key to retrieve the value.</param>
        /// <param name="sectionName">Section name to retrieve the value from.</param>
        /// <returns>Config value for the <paramref name="key" />.</returns>
        /// <exception cref="T:ByteDev.Configuration.ConfigSection.ConfigSettingsProviderException">Key does not exist in the section.</exception>
        /// <exception cref="T:ByteDev.Configuration.UnexpectedConfigValueTypeException">Config value is not of type char.</exception>
        public char GetChar(string key, string sectionName)
        {
            var value = GetString(key, sectionName);
            return _configValueConverter.GetChar(key, value);
        }

        /// <summary>
        /// Retrieves a bool value.
        /// </summary>
        /// <param name="key">Key to retrieve the value.</param>
        /// <param name="sectionName">Section name to retrieve the value from.</param>
        /// <returns>Config value for the <paramref name="key" />.</returns>
        /// <exception cref="T:ByteDev.Configuration.ConfigSection.ConfigSettingsProviderException">Key does not exist in the section.</exception>
        /// <exception cref="T:ByteDev.Configuration.UnexpectedConfigValueTypeException">Config value is not of type bool.</exception>
        public bool GetBool(string key, string sectionName)
        {
            var value = GetString(key, sectionName);
            return _configValueConverter.GetBool(key, value);
        }

        /// <summary>
        /// Retrieves a byte value.
        /// </summary>
        /// <param name="key">Key to retrieve the value.</param>
        /// <param name="sectionName">Section name to retrieve the value from.</param>
        /// <returns>Config value for the <paramref name="key" />.</returns>
        /// <exception cref="T:ByteDev.Configuration.ConfigSection.ConfigSettingsProviderException">Key does not exist in the section.</exception>
        /// <exception cref="T:ByteDev.Configuration.UnexpectedConfigValueTypeException">Config value is not of type byte.</exception>
        public byte GetByte(string key, string sectionName)
        {
            var value = GetString(key, sectionName);
            return _configValueConverter.GetByte(key, value);
        }

        /// <summary>
        /// Retrieves a short value.
        /// </summary>
        /// <param name="key">Key to retrieve the value.</param>
        /// <param name="sectionName">Section name to retrieve the value from.</param>
        /// <returns>Config value for the <paramref name="key" />.</returns>
        /// <exception cref="T:ByteDev.Configuration.ConfigSection.ConfigSettingsProviderException">Key does not exist in the section.</exception>
        /// <exception cref="T:ByteDev.Configuration.UnexpectedConfigValueTypeException">Config value is not of type short.</exception>
        public short GetShort(string key, string sectionName)
        {
            var value = GetString(key, sectionName);
            return _configValueConverter.GetShort(key, value);
        }

        /// <summary>
        /// Retrieves a int value.
        /// </summary>
        /// <param name="key">Key to retrieve the value.</param>
        /// <param name="sectionName">Section name to retrieve the value from.</param>
        /// <returns>Config value for the <paramref name="key" />.</returns>
        /// <exception cref="T:ByteDev.Configuration.ConfigSection.ConfigSettingsProviderException">Key does not exist in the section.</exception>
        /// <exception cref="T:ByteDev.Configuration.UnexpectedConfigValueTypeException">Config value is not of type int.</exception>
        public int GetInt(string key, string sectionName)
        {
            var value = GetString(key, sectionName);
            return _configValueConverter.GetInt(key, value);
        }

        /// <summary>
        /// Retrieves a long value.
        /// </summary>
        /// <param name="key">Key to retrieve the value.</param>
        /// <param name="sectionName">Section name to retrieve the value from.</param>
        /// <returns>Config value for the <paramref name="key" />.</returns>
        /// <exception cref="T:ByteDev.Configuration.ConfigSection.ConfigSettingsProviderException">Key does not exist in the section.</exception>
        /// <exception cref="T:ByteDev.Configuration.UnexpectedConfigValueTypeException">Config value is not of type long.</exception>
        public long GetLong(string key, string sectionName)
        {
            var value = GetString(key, sectionName);
            return _configValueConverter.GetLong(key, value);
        }

        /// <summary>
        /// Retrieves a float value.
        /// </summary>
        /// <param name="key">Key to retrieve the value.</param>
        /// <param name="sectionName">Section name to retrieve the value from.</param>
        /// <returns>Config value for the <paramref name="key" />.</returns>
        /// <exception cref="T:ByteDev.Configuration.ConfigSection.ConfigSettingsProviderException">Key does not exist in the section.</exception>
        /// <exception cref="T:ByteDev.Configuration.UnexpectedConfigValueTypeException">Config value is not of type float.</exception>
        public float GetFloat(string key, string sectionName)
        {
            var value = GetString(key, sectionName);
            return _configValueConverter.GetFloat(key, value);
        }

        /// <summary>
        /// Retrieves a double value.
        /// </summary>
        /// <param name="key">Key to retrieve the value.</param>
        /// <param name="sectionName">Section name to retrieve the value from.</param>
        /// <returns>Config value for the <paramref name="key" />.</returns>
        /// <exception cref="T:ByteDev.Configuration.ConfigSection.ConfigSettingsProviderException">Key does not exist in the section.</exception>
        /// <exception cref="T:ByteDev.Configuration.UnexpectedConfigValueTypeException">Config value is not of type double.</exception>
        public double GetDouble(string key, string sectionName)
        {
            var value = GetString(key, sectionName);
            return _configValueConverter.GetDouble(key, value);
        }

        /// <summary>
        /// Retrieves a decimal value.
        /// </summary>
        /// <param name="key">Key to retrieve the value.</param>
        /// <param name="sectionName">Section name to retrieve the value from.</param>
        /// <returns>Config value for the <paramref name="key" />.</returns>
        /// <exception cref="T:ByteDev.Configuration.ConfigSection.ConfigSettingsProviderException">Key does not exist in the section.</exception>
        /// <exception cref="T:ByteDev.Configuration.UnexpectedConfigValueTypeException">Config value is not of type decimal.</exception>
        public decimal GetDecimal(string key, string sectionName)
        {
            var value = GetString(key, sectionName);
            return _configValueConverter.GetDecimal(key, value);
        }

        /// <summary>
        /// Retrieves a Uri value.
        /// </summary>
        /// <param name="key">Key to retrieve the value.</param>
        /// <param name="sectionName">Section name to retrieve the value from.</param>
        /// <returns>Config value for the <paramref name="key" />.</returns>
        /// <exception cref="T:ByteDev.Configuration.ConfigSection.ConfigSettingsProviderException">Key does not exist in the section.</exception>
        /// <exception cref="T:ByteDev.Configuration.UnexpectedConfigValueTypeException">Config value is not of type Uri.</exception>
        public Uri GetUri(string key, string sectionName)
        {
            var value = GetString(key, sectionName);
            return _configValueConverter.GetAbsoluteUri(key, value);
        }

        /// <summary>
        /// Retrieves a Guid value.
        /// </summary>
        /// <param name="key">Key to retrieve the value.</param>
        /// <param name="sectionName">Section name to retrieve the value from.</param>
        /// <returns>Config value for the <paramref name="key" />.</returns>
        /// <exception cref="T:ByteDev.Configuration.ConfigSection.ConfigSettingsProviderException">Key does not exist in the section.</exception>
        /// <exception cref="T:ByteDev.Configuration.UnexpectedConfigValueTypeException">Config value is not of type Guid.</exception>
        public Guid GetGuid(string key, string sectionName)
        {
            var value = GetString(key, sectionName);
            return _configValueConverter.GetGuid(key, value);
        }

        private NameValueCollection GetSectionOrThrow(string sectionName)
        {
            var section = _configSectionProvider.GetSection(sectionName);

            if (section == null)
            {
                throw new ConfigSettingsProviderException($"Config section '{sectionName}' does not exist.");
            }

            return section;
        }
    }
}
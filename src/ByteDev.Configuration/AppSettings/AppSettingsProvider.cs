﻿using System;
using System.Configuration;

namespace ByteDev.Configuration.AppSettings
{
    /// <summary>
    /// Represents a provider for the appSettings section in config.
    /// </summary>
    public class AppSettingsProvider : IAppSettingsProvider
    {
        private readonly ConfigValueConverter _configValueConverter;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Configuration.AppSettings.AppSettingsProvider" /> class.
        /// </summary>
        public AppSettingsProvider()
        {
            _configValueConverter = new ConfigValueConverter();
        }

        /// <summary>
        /// Retrieve an app setting string value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
	    public string GetString(string key)
		{
			var value = ConfigurationManager.AppSettings[key];

			if(value == null)
			{
                throw new AppSettingsKeyNotExistException($"Config file does not contain AppSetting with key: '{key}'.");
			}
			
            return value;
		}

        /// <summary>
        /// Retrieve an app setting char value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        public char GetChar(string key)
        {
            var value = GetString(key);
            return _configValueConverter.GetChar(key, value);
        }

        /// <summary>
        /// Retrieve an app setting bool value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        public bool GetBool(string key)
		{
		    var value = GetString(key);
	        return _configValueConverter.GetBool(key, value);
		}

        /// <summary>
        /// Retrieve an app setting byte value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        public byte GetByte(string key)
	    {
	        var value = GetString(key);
	        return _configValueConverter.GetByte(key, value);
	    }

        /// <summary>
        /// Retrieve an app setting short value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        public short GetShort(string key)
        {
            var value = GetString(key);
            return _configValueConverter.GetShort(key, value);
        }

        /// <summary>
        /// Retrieve an app setting int value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        public int GetInt(string key)
		{
		    var value = GetString(key);
	        return _configValueConverter.GetInt(key, value);
		}

        /// <summary>
        /// Retrieve an app setting long value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        public long GetLong(string key)
        {
            var value = GetString(key);
	        return _configValueConverter.GetLong(key, value);
        }

        /// <summary>
        /// Retrieve an app setting float value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        public float GetFloat(string key)
        {
            var value = GetString(key);
            return _configValueConverter.GetFloat(key, value);
        }

        /// <summary>
        /// Retrieve an app setting double value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        public double GetDouble(string key)
        {
            var value = GetString(key);
            return _configValueConverter.GetDouble(key, value);
        }

        /// <summary>
        /// Retrieve an app setting decimal value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        public decimal GetDecimal(string key)
        {
            var value = GetString(key);
            return _configValueConverter.GetDecimal(key, value);
        }

        /// <summary>
        /// Retrieve an app setting Uri value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        public Uri GetUri(string key)
        {
            var value = GetString(key);
            return _configValueConverter.GetAbsoluteUri(key, value);
        }

        /// <summary>
        /// Retrieve an app setting Guid value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        public Guid GetGuid(string key)
        {
            var value = GetString(key);
            return _configValueConverter.GetGuid(key, value);
        }
    }
}

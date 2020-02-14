using System;
using System.Configuration;

namespace ByteDev.Configuration.AppSettings
{
    /// <summary>
    /// Represents a provider for the appSettings section in config.
    /// </summary>
    public class AppSettingsProvider : IAppSettingsProvider
    {
        /// <summary>
        /// Retrieve an app setting string value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        /// <exception cref="T:ByteDev.Configuration.AppSettings.AppSettingsKeyNotExistException">Config does not contain AppSetting with <paramref name="key" />.</exception>
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
        /// <exception cref="T:ByteDev.Configuration.AppSettings.AppSettingsKeyNotExistException">Config does not contain AppSetting with <paramref name="key" />.</exception>
        /// <exception cref="T:ByteDev.Configuration.UnexpectedConfigValueTypeException">Config value is not of type char.</exception>
        public char GetChar(string key)
        {
            var value = GetString(key);
            return ConfigValueConverter.GetChar(key, value);
        }

        /// <summary>
        /// Retrieve an app setting bool value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        /// <exception cref="T:ByteDev.Configuration.AppSettings.AppSettingsKeyNotExistException">Config does not contain AppSetting with <paramref name="key" />.</exception>
        /// <exception cref="T:ByteDev.Configuration.UnexpectedConfigValueTypeException">Config value is not of type bool.</exception>
        public bool GetBool(string key)
		{
		    var value = GetString(key);
	        return ConfigValueConverter.GetBool(key, value);
		}

        /// <summary>
        /// Retrieve an app setting byte value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        /// <exception cref="T:ByteDev.Configuration.AppSettings.AppSettingsKeyNotExistException">Config does not contain AppSetting with <paramref name="key" />.</exception>
        /// <exception cref="T:ByteDev.Configuration.UnexpectedConfigValueTypeException">Config value is not of type byte.</exception>
        public byte GetByte(string key)
	    {
	        var value = GetString(key);
	        return ConfigValueConverter.GetByte(key, value);
	    }

        /// <summary>
        /// Retrieve an app setting short value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        /// <exception cref="T:ByteDev.Configuration.AppSettings.AppSettingsKeyNotExistException">Config does not contain AppSetting with <paramref name="key" />.</exception>
        /// <exception cref="T:ByteDev.Configuration.UnexpectedConfigValueTypeException">Config value is not of type short.</exception>
        public short GetShort(string key)
        {
            var value = GetString(key);
            return ConfigValueConverter.GetShort(key, value);
        }

        /// <summary>
        /// Retrieve an app setting int value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        /// <exception cref="T:ByteDev.Configuration.AppSettings.AppSettingsKeyNotExistException">Config does not contain AppSetting with <paramref name="key" />.</exception>
        /// <exception cref="T:ByteDev.Configuration.UnexpectedConfigValueTypeException">Config value is not of type int.</exception>
        public int GetInt(string key)
		{
		    var value = GetString(key);
	        return ConfigValueConverter.GetInt(key, value);
		}

        /// <summary>
        /// Retrieve an app setting long value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        /// <exception cref="T:ByteDev.Configuration.AppSettings.AppSettingsKeyNotExistException">Config does not contain AppSetting with <paramref name="key" />.</exception>
        /// <exception cref="T:ByteDev.Configuration.UnexpectedConfigValueTypeException">Config value is not of type long.</exception>
        public long GetLong(string key)
        {
            var value = GetString(key);
	        return ConfigValueConverter.GetLong(key, value);
        }

        /// <summary>
        /// Retrieve an app setting float value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        /// <exception cref="T:ByteDev.Configuration.AppSettings.AppSettingsKeyNotExistException">Config does not contain AppSetting with <paramref name="key" />.</exception>
        /// <exception cref="T:ByteDev.Configuration.UnexpectedConfigValueTypeException">Config value is not of type float.</exception>
        public float GetFloat(string key)
        {
            var value = GetString(key);
            return ConfigValueConverter.GetFloat(key, value);
        }

        /// <summary>
        /// Retrieve an app setting double value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        /// <exception cref="T:ByteDev.Configuration.AppSettings.AppSettingsKeyNotExistException">Config does not contain AppSetting with <paramref name="key" />.</exception>
        /// <exception cref="T:ByteDev.Configuration.UnexpectedConfigValueTypeException">Config value is not of type double.</exception>
        public double GetDouble(string key)
        {
            var value = GetString(key);
            return ConfigValueConverter.GetDouble(key, value);
        }

        /// <summary>
        /// Retrieve an app setting decimal value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        /// <exception cref="T:ByteDev.Configuration.AppSettings.AppSettingsKeyNotExistException">Config does not contain AppSetting with <paramref name="key" />.</exception>
        /// <exception cref="T:ByteDev.Configuration.UnexpectedConfigValueTypeException">Config value is not of type decimal.</exception>
        public decimal GetDecimal(string key)
        {
            var value = GetString(key);
            return ConfigValueConverter.GetDecimal(key, value);
        }

        /// <summary>
        /// Retrieve an app setting Uri value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        /// <exception cref="T:ByteDev.Configuration.AppSettings.AppSettingsKeyNotExistException">Config does not contain AppSetting with <paramref name="key" />.</exception>
        /// <exception cref="T:ByteDev.Configuration.UnexpectedConfigValueTypeException">Config value is not of type Uri.</exception>
        public Uri GetUri(string key)
        {
            var value = GetString(key);
            return ConfigValueConverter.GetAbsoluteUri(key, value);
        }

        /// <summary>
        /// Retrieve an app setting Guid value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        /// <exception cref="T:ByteDev.Configuration.AppSettings.AppSettingsKeyNotExistException">Config does not contain AppSetting with <paramref name="key" />.</exception>
        /// <exception cref="T:ByteDev.Configuration.UnexpectedConfigValueTypeException">Config value is not of type Guid.</exception>
        public Guid GetGuid(string key)
        {
            var value = GetString(key);
            return ConfigValueConverter.GetGuid(key, value);
        }
    }
}

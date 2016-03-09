using System;
using System.Configuration;

namespace ByteDev.Configuration.AppSettings
{
    public class AppSettingsProvider : IAppSettingsProvider
    {
        private readonly ConfigValueConverter _configValueConverter;

        public AppSettingsProvider()
        {
            _configValueConverter = new ConfigValueConverter();
        }

	    public string GetString(string key)
		{
			var value = ConfigurationManager.AppSettings[key];
			if(value == null)
			{
                throw new AppSettingsKeyNotExistException(string.Format("Config file does not contain AppSetting with key: '{0}'.", key));
			}
			return value;
		}

        public char GetChar(string key)
        {
            var value = GetString(key);
            return _configValueConverter.GetChar(key, value);
        }

	    public bool GetBool(string key)
		{
		    var value = GetString(key);
	        return _configValueConverter.GetBool(key, value);
		}

	    public byte GetByte(string key)
	    {
	        var value = GetString(key);
	        return _configValueConverter.GetByte(key, value);
	    }

        public short GetShort(string key)
        {
            var value = GetString(key);
            return _configValueConverter.GetShort(key, value);
        }

        public int GetInt(string key)
		{
		    var value = GetString(key);
	        return _configValueConverter.GetInt(key, value);
		}

        public long GetLong(string key)
        {
            var value = GetString(key);
	        return _configValueConverter.GetLong(key, value);
        }

        public float GetFloat(string key)
        {
            var value = GetString(key);
            return _configValueConverter.GetFloat(key, value);
        }

        public double GetDouble(string key)
        {
            var value = GetString(key);
            return _configValueConverter.GetDouble(key, value);
        }

        public decimal GetDecimal(string key)
        {
            var value = GetString(key);
            return _configValueConverter.GetDecimal(key, value);
        }

        public Uri GetAbsoluteUri(string key)
        {
            var value = GetString(key);
            return _configValueConverter.GetAbsoluteUri(key, value);
        }
    }
}

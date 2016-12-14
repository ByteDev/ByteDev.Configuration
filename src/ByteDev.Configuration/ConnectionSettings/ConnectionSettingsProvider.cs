using System;
using System.Configuration;

namespace ByteDev.Configuration.ConnectionSettings
{
    public class ConnectionSettingsProvider : IConnectionSettingsProvider
    {
        public ConnectionStringSettings GetConnectionSettings(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentException("Connection setting key cannot be null or empty.");
            }
            return ConfigurationManager.ConnectionStrings[key];
        }
    }
}
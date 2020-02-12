using System;
using System.Configuration;

namespace ByteDev.Configuration.ConnectionSettings
{
    /// <summary>
    /// Represents a provider for config based connection settings.
    /// </summary>
    public class ConnectionSettingsProvider : IConnectionSettingsProvider
    {
        /// <summary>
        /// Retrieves connection string settings.
        /// </summary>
        /// <param name="key">Key to use when retrieving settings.</param>
        /// <returns>Connection string settings for the key.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="key" /> is null or empty.</exception>
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
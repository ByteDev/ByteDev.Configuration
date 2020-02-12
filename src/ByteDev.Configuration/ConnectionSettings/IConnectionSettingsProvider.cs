using System.Configuration;

namespace ByteDev.Configuration.ConnectionSettings
{
    /// <summary>
    /// Interface represents a provider for config based connection settings.
    /// </summary>
    public interface IConnectionSettingsProvider
    {
        /// <summary>
        /// Retrieves connection string settings.
        /// </summary>
        /// <param name="key">Key to use when retrieving settings.</param>
        /// <returns>Connection string settings for the key.</returns>
        ConnectionStringSettings GetConnectionSettings(string key);
    }
}
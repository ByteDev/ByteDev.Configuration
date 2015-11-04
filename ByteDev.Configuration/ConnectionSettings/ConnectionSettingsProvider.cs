using System.Configuration;

namespace ByteDev.Configuration.ConnectionSettings
{
    public interface IConnectionSettingsProvider
    {
        ConnectionStringSettings GetConnectionSettings(string key);
    }

    public class ConnectionSettingsProvider : IConnectionSettingsProvider
    {
        public ConnectionStringSettings GetConnectionSettings(string key)
        {
            return ConfigurationManager.ConnectionStrings[key];
        }
    }
}
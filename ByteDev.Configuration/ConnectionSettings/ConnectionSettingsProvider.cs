using System.Configuration;

namespace ByteDev.Configuration.ConnectionSettings
{
    public class ConnectionSettingsProvider : IConnectionSettingsProvider
    {
        public ConnectionStringSettings GetConnectionSettings(string key)
        {
            return ConfigurationManager.ConnectionStrings[key];
        }
    }
}
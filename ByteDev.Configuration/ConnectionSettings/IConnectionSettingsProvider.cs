using System.Configuration;

namespace ByteDev.Configuration.ConnectionSettings
{
    public interface IConnectionSettingsProvider
    {
        ConnectionStringSettings GetConnectionSettings(string key);
    }
}
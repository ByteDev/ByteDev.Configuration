using System.Collections.Specialized;
using System.Configuration;

namespace ByteDev.Configuration.ConfigSection
{
    public interface IConfigSectionProvider
    {
        NameValueCollection GetSection(string sectionName);
    }

    public class ConfigSectionProvider : IConfigSectionProvider
    {
        public NameValueCollection GetSection(string sectionName)
        {
            return ConfigurationManager.GetSection(sectionName) as NameValueCollection;
        }
    }
}
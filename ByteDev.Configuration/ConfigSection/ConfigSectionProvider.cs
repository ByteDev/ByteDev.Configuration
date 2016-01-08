using System.Collections.Specialized;
using System.Configuration;

namespace ByteDev.Configuration.ConfigSection
{
    public class ConfigSectionProvider : IConfigSectionProvider
    {
        public NameValueCollection GetSection(string sectionName)
        {
            return ConfigurationManager.GetSection(sectionName) as NameValueCollection;
        }
    }
}
using System;
using System.Collections.Specialized;
using System.Configuration;

namespace ByteDev.Configuration.ConfigSection
{
    public class ConfigSectionProvider : IConfigSectionProvider
    {
        public NameValueCollection GetSection(string sectionName)
        {
            if (string.IsNullOrEmpty(sectionName))
            {
                throw new ArgumentException("Config section name cannot be null or empty.");
            }
            return ConfigurationManager.GetSection(sectionName) as NameValueCollection;
        }
    }
}
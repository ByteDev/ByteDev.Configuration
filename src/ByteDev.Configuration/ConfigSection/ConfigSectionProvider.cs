using System;
using System.Collections.Specialized;
using System.Configuration;

namespace ByteDev.Configuration.ConfigSection
{
    /// <summary>
    /// Represents a provider for retrieving config sections.
    /// </summary>
    public class ConfigSectionProvider : IConfigSectionProvider
    {
        /// <summary>
        /// Retrieves a config section by name.
        /// </summary>
        /// <param name="sectionName">Config section name.</param>
        /// <returns>Returns a name value pair collection if the section exists; otherwise returns null.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="sectionName" /> is null or empty.</exception>
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
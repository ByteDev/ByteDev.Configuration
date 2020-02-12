using System.Collections.Specialized;

namespace ByteDev.Configuration.ConfigSection
{
    /// <summary>
    /// Represents interface for retrieving config sections.
    /// </summary>
    public interface IConfigSectionProvider
    {
        /// <summary>
        /// Retrieves a config section by name.
        /// </summary>
        /// <param name="sectionName">Config section name.</param>
        /// <returns>Returns a name value pair collection if the section exists; otherwise returns null.</returns>
        NameValueCollection GetSection(string sectionName);
    }
}
using System.Collections.Specialized;

namespace ByteDev.Configuration.ConfigSection
{
    public interface IConfigSectionProvider
    {
        NameValueCollection GetSection(string sectionName);
    }
}
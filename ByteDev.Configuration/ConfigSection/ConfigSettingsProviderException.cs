using System;
using System.Runtime.Serialization;

namespace ByteDev.Configuration.ConfigSection
{
    [Serializable]
    public class ConfigSettingsProviderException : Exception
    {
        public ConfigSettingsProviderException()
        {
        }

        public ConfigSettingsProviderException(string message) : base(message)
        {
        }

        public ConfigSettingsProviderException(string message, Exception inner) : base(message, inner)
        {
        }

        protected ConfigSettingsProviderException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
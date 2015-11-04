using System;
using System.Runtime.Serialization;

namespace ByteDev.Configuration.AppSettings
{
    [Serializable]
    public class AppSettingsKeyNotExistException : Exception
    {
        public AppSettingsKeyNotExistException()
        {
        }

        public AppSettingsKeyNotExistException(string message) : base(message)
        {
        }

        public AppSettingsKeyNotExistException(string message, Exception inner) : base(message, inner)
        {
        }

        protected AppSettingsKeyNotExistException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}

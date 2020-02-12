using System;
using System.Runtime.Serialization;

namespace ByteDev.Configuration.ConfigSection
{
    /// <summary>
    /// Represents an error related to reading settings from a user defined config section.
    /// </summary>
    [Serializable]
    public class ConfigSettingsProviderException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Configuration.ConfigSection.ConfigSettingsProviderException" /> class.
        /// </summary>
        public ConfigSettingsProviderException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Configuration.ConfigSection.ConfigSettingsProviderException" /> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public ConfigSettingsProviderException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Configuration.ConfigSection.ConfigSettingsProviderException" /> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>       
        public ConfigSettingsProviderException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Configuration.ConfigSection.ConfigSettingsProviderException" /> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"></see> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext"></see> that contains contextual information about the source or destination.</param>
        protected ConfigSettingsProviderException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
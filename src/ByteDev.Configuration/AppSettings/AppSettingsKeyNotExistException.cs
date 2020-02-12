using System;
using System.Runtime.Serialization;

namespace ByteDev.Configuration.AppSettings
{
    /// <summary>
    /// Represents an error when a key does not exist in the appSettings section of a config file.
    /// </summary>
    [Serializable]
    public class AppSettingsKeyNotExistException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Configuration.AppSettings.AppSettingsKeyNotExistException" /> class.
        /// </summary>
        public AppSettingsKeyNotExistException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Configuration.AppSettings.AppSettingsKeyNotExistException" /> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public AppSettingsKeyNotExistException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Configuration.AppSettings.AppSettingsKeyNotExistException" /> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>       
        public AppSettingsKeyNotExistException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Configuration.AppSettings.AppSettingsKeyNotExistException" /> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"></see> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext"></see> that contains contextual information about the source or destination.</param>
        protected AppSettingsKeyNotExistException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
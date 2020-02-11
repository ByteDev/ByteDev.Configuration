using System;
using System.Runtime.Serialization;

namespace ByteDev.Configuration
{
    /// <summary>
    /// Represents an unexpected value type in config.
    /// </summary>
    [Serializable]
    public class UnexpectedConfigValueTypeException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Configuration.UnexpectedConfigValueTypeException" /> class.
        /// </summary>
        public UnexpectedConfigValueTypeException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Configuration.UnexpectedConfigValueTypeException" /> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public UnexpectedConfigValueTypeException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Configuration.UnexpectedConfigValueTypeException" /> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>       
        public UnexpectedConfigValueTypeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Configuration.UnexpectedConfigValueTypeException" /> class.
        /// </summary>
        /// <param name="key">The config key.</param>
        /// <param name="value">The config value.</param>
        /// <param name="expectedType">The expected type in config.</param>
        public UnexpectedConfigValueTypeException(string key, string value, Type expectedType)
            : base($"Key: '{key}' value: '{value}' is not of expected type: {expectedType.Name}.")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Configuration.UnexpectedConfigValueTypeException" /> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"></see> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext"></see> that contains contextual information about the source or destination.</param>
        protected UnexpectedConfigValueTypeException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
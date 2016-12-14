using System;
using System.Runtime.Serialization;

namespace ByteDev.Configuration
{
    [Serializable]
    public class UnexpectedConfigValueTypeException : Exception
    {
        public UnexpectedConfigValueTypeException()
        {
        }

        public UnexpectedConfigValueTypeException(string message) : base(message)
        {
        }

        public UnexpectedConfigValueTypeException(string message, Exception inner) : base(message, inner)
        {
        }

        public UnexpectedConfigValueTypeException(string key, string value, Type expectedType)
            : base(string.Format("Key: '{0}' value: '{1}' is not of expected type: {2}.", key, value, expectedType.Name))
        {
        }

        protected UnexpectedConfigValueTypeException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}

using System;
using System.Runtime.Serialization;

namespace _8._1
{
    [Serializable]
    internal class InputNotNumException : Exception
    {
        public InputNotNumException()
        {
        }

        public InputNotNumException(string message) : base(message)
        {
        }

        public InputNotNumException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InputNotNumException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
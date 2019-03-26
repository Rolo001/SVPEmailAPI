using System;
using System.Runtime.Serialization;

namespace Svp.Email.Classes
{
    [Serializable]
    internal class EmailDispatcherException : Exception
    {
        private object e;

        public EmailDispatcherException()
        {
        }

        public EmailDispatcherException(object e)
        {
            this.e = e;
        }

        public EmailDispatcherException(string message) : base(message)
        {
        }

        public EmailDispatcherException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EmailDispatcherException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
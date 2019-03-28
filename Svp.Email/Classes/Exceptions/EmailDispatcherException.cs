namespace Svp.Email.Classes.Exceptions
{
    using System;
    using System.Runtime.Serialization;

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


        //// recommended use!
        public EmailDispatcherException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EmailDispatcherException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
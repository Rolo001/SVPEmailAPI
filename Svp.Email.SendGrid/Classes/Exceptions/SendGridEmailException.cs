namespace Svp.Email.SendGrid.Classes.Exceptions
{
    using System;

    [Serializable]
    internal class SendGridEmailException : Exception
    {
        private Exception e;

        public SendGridEmailException()
        {
        }

        public SendGridEmailException(Exception e)
        {
            this.e = e;
        }

        public SendGridEmailException(string message) : base(message)
        {
        }

        public SendGridEmailException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SendGridEmailException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

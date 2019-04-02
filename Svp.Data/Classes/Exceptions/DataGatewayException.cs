namespace Svp.Data.Classes.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    internal class DataGatewayException : Exception
    {
        private Exception e;

        public DataGatewayException()
        {
        }

        public DataGatewayException(Exception e)
        {
            this.e = e;
            Console.WriteLine(e);
        }

        public DataGatewayException(string message) : base(message)
        {
        }

        public DataGatewayException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DataGatewayException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
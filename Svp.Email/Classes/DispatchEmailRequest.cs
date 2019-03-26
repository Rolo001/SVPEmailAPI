namespace Svp.Email.Classes
{
    using System;
    using System.Diagnostics;
    public class DispatchEmailRequest
    {
        public DispatchEmailRequest(string recipientName, string recipientEmail)
        {
            Debug.Assert(!string.IsNullOrWhiteSpace(recipientName));
            Debug.Assert(!string.IsNullOrWhiteSpace(recipientEmail));

            this.RecipientEmail = recipientEmail;
            this.RecpientName = recipientName;
            this.SenderEmail = "noreply@saasvp.io";
            this.SenderName = "SVP";
        }

        internal bool IsValid()
        {
            //throw new NotImplementedException();
            //validations:
            return false; //temporary return data
        }

        internal string[] GetErrors()
        {
            //error template
            Console.WriteLine("get error method: DispatchEmailRequest");
            return new string[] { "error", "GetError method" };
        }

        public string Subject { get; private set; }
        public string RecipientEmail { get; private set; }
        public string RecpientName { get; private set; }
        public string SenderEmail { get; private set; }
        public string SenderName { get; private set; }
        public string Content { get; private set; }
    }
}
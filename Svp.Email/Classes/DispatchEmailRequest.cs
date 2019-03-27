namespace Svp.Email.Classes
{
    using System;
    using System.Diagnostics;
    using System.ComponentModel.DataAnnotations;

    public class DispatchEmailRequest
    {
        public DispatchEmailRequest(string recipientName, string recipientEmail)
        {
            Debug.Assert(!string.IsNullOrWhiteSpace(recipientName));
            Debug.Assert(!string.IsNullOrWhiteSpace(recipientEmail));

            this.RecipientEmail = recipientEmail;
            this.RecipientName = recipientName;
            this.SenderEmail = "noreply@saasvp.io";
            this.SenderName = "SVP";
        }
        
        //data anotation to controller (properties)
        public string Subject { get; private set; }
        public string RecipientEmail { get; private set; }
        public string RecipientName { get; private set; }
        public string SenderEmail { get; private set; }
        public string SenderName { get; private set; }
        public string Content { get; private set; }


        //Place inside extension if you are to use this!
        public bool IsValid()
        {
            throw new NotImplementedException();
            //why not use data anotations
            //specification pattern
            //return false; //temporary return data
        }

        public string[] GetErrors()
        {
            //get error messages from validations?
            //error template
            Console.WriteLine("get error method: DispatchEmailRequest");
            return new string[] { "error", "GetError method" };
        }
    }
}
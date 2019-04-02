namespace Svp.Email.SendGrid.Extensions
{
    using global::SendGrid.Helpers.Mail;
    using Svp.Email.Classes;
    public static class DispatchEmailRequestExtensions
    {

        //could we place validations here?
        public static SendGridMessage ToSendGridMessage(this DispatchEmailRequest request)
        {
            var result = new SendGridMessage();
            if (request != null)
            {
                result.From = new EmailAddress();
                result.ReplyTo = new EmailAddress();
                result.Subject = request.Subject;
                result.PlainTextContent = request.Content;

                //create single mail
                

            }
            return result;
        }
    }
}

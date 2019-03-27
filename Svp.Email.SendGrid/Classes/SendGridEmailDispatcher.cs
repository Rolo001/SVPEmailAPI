namespace Svp.Email.SendGrid.Classes
{
    using System;
    using System.Net;
    using System.Threading.Tasks;
    using global::SendGrid;
    using Svp.Email.Classes;
    using Svp.Email.Interfaces;
    using Svp.Email.SendGrid.Classes.Exceptions;
    using Svp.Email.SendGrid.Extensions;
    using Svp.Email.SendGrid.Interfaces;

    public class SendGridEmailDispatcher : IEmailDispatcher
    {
        private readonly SendGridClient client;

        public SendGridEmailDispatcher() : this(new DefaultConfigProvider())
        {
        }

        public SendGridEmailDispatcher(IConfigProvider config)
        {
            this.client = new SendGridClient(config.ApiKey);
        }

        public async Task<DispatchEmailResponse> Dispatch(DispatchEmailRequest request)
        {
            var result = DispatchEmailResponse.CreateFailed(request); //purpose?

            try
            {
                var message = request.ToSendGridMessage();
                var response = await this.client.SendEmailAsync(message);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    result = new DispatchEmailResponse(request);
                }
                else
                {
                    result = DispatchEmailResponse.CreateFailed(request, new string[] { await response.Body.ReadAsStringAsync() });
                }
            }
            catch (Exception e)
            {
                throw new SendGridEmailException(e);
            }
            return result;
        }
    }
}
            //this bloc needs SR  --> used extension method DispatchEmailRequestExtensions

            //var message = new SendGridMessage()
            //{
            //    From = new EmailAddress(),
            //    ReplyTo = new EmailAddress(),
            //    Subject = request.Subject,
            //    PlainTextContent = request.Content
            //};

            //message.AddTo(request.RecipientEmail, request.RecpientName);
            //var response = await this.client.SendEmailAsync(message);
            //return new DispatchEmailResponse(request);

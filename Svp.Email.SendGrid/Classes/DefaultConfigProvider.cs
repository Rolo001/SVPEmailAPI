namespace Svp.Email.SendGrid.Classes
{
    using System;
    using Svp.Email.SendGrid.Interfaces;

    public class DefaultConfigProvider : IConfigProvider
    {
        public string ApiKey { get { return Environment.GetEnvironmentVariable("SendGridApiKey"); } }
    }
}

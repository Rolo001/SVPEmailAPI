namespace Svp.Data.Classes
{
    using Svp.Data.Interfaces;
    using Microsoft.Extensions.Configuration;

    public class ConnectionStringProvider : IConnectionStringProvider
    {
        private readonly IConfiguration config;

        public ConnectionStringProvider(IConfiguration config)
        {
            this.config = config;
        }

        public string GetDbConnectionString()
        {
            return this.config.GetValue<string>("DbSQLConnectionString");
        }
    }
}

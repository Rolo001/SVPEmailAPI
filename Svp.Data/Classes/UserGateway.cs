namespace Svp.Data.Classes
{
    using System;
    using System.Data.SqlClient;
    using Svp.Data.Classes.Exceptions;
    using Svp.Data.Classes.Interfaces;

    public class UserGateway : IUserGateway
    {
        private readonly string connectionString;

        public UserGateway(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Save(SaveUserRequest request) // method to sve into datastore or database
        {
            try
            {
                using (var connection = new SqlConnection(this.connectionString))
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {

                    }
                }
            }
            catch (Exception e)
            {
                throw new DataGatewayException(e);
            }
        }       
    }
}

namespace Svp.Data.Classes.CommandFactory
{
    using System.Data;
    using System.Data.SqlClient;

    public class UserSqlCommandFactory : IUserSqlCommandFactory
    {
        public SqlCommand RetrieveUserSqlCommand(int ID)
        { 
            SqlCommand command = new SqlCommand("[dbo].[spGetUser]")
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = 30
            };
            command.Parameters.AddWithValue("id", ID);
            return command;
        }
    }
}

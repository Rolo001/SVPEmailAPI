namespace Svp.Data.Classes.CommandFactory
{
    using System.Data;
    using System.Data.SqlClient;
    using Svp.Data.Model;

    public class UserSqlCommandFactory : IUserSqlCommandFactory
    {
        public SqlCommand AddUserSqlCommand(User user)
        {
            SqlCommand command = new SqlCommand("[dbo].[spAddUser")
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = 30
            };
            command.Parameters.AddWithValue("email", user.Email);
            command.Parameters.AddWithValue("fullName", user.Name);
            command.Parameters.AddWithValue("password", user.Password);
            return command;
        }

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
